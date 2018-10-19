using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace server
{

    public partial class server : Form
    {
        Socket socket = null;
        Socket client = null;
        IPAddress ipAddress = null;

        public server()
        {
            InitializeComponent();
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            this.Text = "서버-윤주혜";
        }
        
        private void server_Load(object sender, EventArgs e)
        {
            IPHostEntry iphe = Dns.GetHostEntry(Dns.GetHostName());
            
            foreach (IPAddress addr in iphe.AddressList)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipAddress = addr;
                    break;
                }
            }
            ipBox.Mask = ipAddress.ToString();
            ipBox.Text = ipAddress.ToString();

            sendBtn.Enabled = false;

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (ipBox.Text != "" && portBox.Text != "" &&nameBox.Text!="")
            {
                if (Convert.ToInt32(portBox.Text) >= 1024 && Convert.ToInt32(portBox.Text) <= 65535)
                {
                    IPEndPoint ipep = new IPEndPoint(ipAddress, Convert.ToInt32(portBox.Text));
                    socket.Bind(ipep);
                    socket.Listen(10);

                    msgBox.Text += "연결되었습니다! \r\n클라이언트 연결 대기중입니다.";

                    startBtn.Enabled = false;
                    sendBtn.Enabled = true;
                    
                    socket.BeginAccept(AcceptCallback, null);

                }
                else
                {
                    MessageBox.Show("포트번호는 1024~65535 사용가능");
                }
            }
            else
            {
                MessageBox.Show("IP와 포트와 사용자 이름을 확인해주세요");
            }
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            //소켓 종료
            socket.Close();

            Close();
        }
        
        List<Socket> connectedClients = new List<Socket>();

        void AcceptCallback(IAsyncResult ar)
        {
            //연결요청을 수락
            client = socket.EndAccept(ar);

            //다른 연결 요청
            socket.BeginAccept(AcceptCallback, null);

            AsyncObject ao = new AsyncObject(4000);
            ao.WorkingSocket = client;

            connectedClients.Add(client);

            msgBox.Text += "\r\n상대방 [" + client.RemoteEndPoint + "]가 연결되었습니다.";

            //클라이언트의 데이터를 받음
            client.BeginReceive(ao.Buffer, 0, 4000, 0, DataReceivced, ao);

        }
        void DataReceivced(IAsyncResult ar)
        {
            AsyncObject ao = (AsyncObject)ar.AsyncState;

            int received = ao.WorkingSocket.EndReceive(ar);
            if (received <= 0)
            {
                ao.WorkingSocket.Close();
                return;
            }
            
            string text = Encoding.UTF8.GetString(ao.Buffer);

            string[] t = text.Split('>');
            string name = t[0];
            string msg = t[1];
            msgBox.Text += "\r\n" + name + ": " + msg;

            for(int i=connectedClients.Count-1; i>=0; i--)
            {
                Socket client_socket = connectedClients[i];
                if (client_socket != ao.WorkingSocket)
                {
                    try { client_socket.Send(ao.Buffer); }
                    catch
                    {
                        try { client_socket.Dispose(); }
                        catch { }
                        connectedClients.RemoveAt(i);
                    }
                }
            }

            ao.ClearBuffer();

            ao.WorkingSocket.BeginReceive(ao.Buffer, 0, 4000, 0, DataReceivced, ao);
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (!socket.IsBound)
            {
                MessageBox.Show("서버가 실행되고 있지 않습니다.");
                return;
            }

            string text = sendBox.Text;
            if (text=="")
            {
                MessageBox.Show("텍스트를 확인해주세요.");
                sendBox.Focus();
                return;
            }
            
            byte[] type = Encoding.UTF8.GetBytes(nameBox.Text + '>' + text);

            for (int i = connectedClients.Count - 1; i >= 0; i--)
            {
                Socket client_socket = connectedClients[i];
                try { client_socket.Send(type); }
                catch
                {
                    try { client_socket.Dispose(); }
                    catch { }
                    connectedClients.RemoveAt(i);
                }
            }
            msgBox.Text += "\r\n" + nameBox.Text + ": " + text;
            sendBox.Clear();
        }
    }
}

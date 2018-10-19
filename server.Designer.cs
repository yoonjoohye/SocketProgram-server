namespace server
{
    partial class server
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ipLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.endBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.TextBox();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.sendBox = new System.Windows.Forms.TextBox();
            this.ipBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ipLabel.Location = new System.Drawing.Point(35, 33);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(60, 17);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "IP 주소";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.portLabel.Location = new System.Drawing.Point(35, 79);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(41, 17);
            this.portLabel.TabIndex = 1;
            this.portLabel.Text = "PORT";
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.startBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startBtn.Location = new System.Drawing.Point(449, 30);
            this.startBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(114, 46);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // endBtn
            // 
            this.endBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.endBtn.FlatAppearance.BorderSize = 0;
            this.endBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endBtn.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.endBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.endBtn.Location = new System.Drawing.Point(449, 104);
            this.endBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(114, 46);
            this.endBtn.TabIndex = 5;
            this.endBtn.Text = "END";
            this.endBtn.UseVisualStyleBackColor = false;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.sendBtn.FlatAppearance.BorderSize = 0;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sendBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendBtn.Location = new System.Drawing.Point(449, 475);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(114, 43);
            this.sendBtn.TabIndex = 8;
            this.sendBtn.Text = "SEND";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // portBox
            // 
            this.portBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.portBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.portBox.Font = new System.Drawing.Font("문체부 돋음체", 15F);
            this.portBox.Location = new System.Drawing.Point(146, 76);
            this.portBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(278, 25);
            this.portBox.TabIndex = 3;
            // 
            // msgBox
            // 
            this.msgBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.msgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msgBox.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.msgBox.Location = new System.Drawing.Point(37, 169);
            this.msgBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.msgBox.Multiline = true;
            this.msgBox.Name = "msgBox";
            this.msgBox.ReadOnly = true;
            this.msgBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.msgBox.Size = new System.Drawing.Size(526, 298);
            this.msgBox.TabIndex = 7;
            // 
            // sendBox
            // 
            this.sendBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sendBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sendBox.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sendBox.Location = new System.Drawing.Point(37, 475);
            this.sendBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendBox.Multiline = true;
            this.sendBox.Name = "sendBox";
            this.sendBox.Size = new System.Drawing.Size(412, 43);
            this.sendBox.TabIndex = 7;
            // 
            // ipBox
            // 
            this.ipBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ipBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipBox.Font = new System.Drawing.Font("문체부 돋음체", 15F);
            this.ipBox.Location = new System.Drawing.Point(146, 30);
            this.ipBox.Mask = "000.000.000.000";
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(278, 25);
            this.ipBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(33, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "사용자 이름";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Font = new System.Drawing.Font("문체부 돋음체", 15F);
            this.nameBox.Location = new System.Drawing.Point(146, 119);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(278, 25);
            this.nameBox.TabIndex = 11;
            // 
            // server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(594, 561);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.sendBox);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.ipLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "server";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button endBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.TextBox sendBox;
        private System.Windows.Forms.MaskedTextBox ipBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
    }
}


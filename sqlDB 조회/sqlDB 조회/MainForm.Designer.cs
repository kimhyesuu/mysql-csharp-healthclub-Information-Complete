namespace sqlDB_조회
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblBigname = new System.Windows.Forms.Label();
            this.lblID_Update = new System.Windows.Forms.Label();
            this.lblID_Del = new System.Windows.Forms.Label();
            this.tbUpUserID = new System.Windows.Forms.TextBox();
            this.tbDelUserID = new System.Windows.Forms.TextBox();
            this.btnUdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnResitM = new System.Windows.Forms.Button();
            this.btnRefM = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdateM = new System.Windows.Forms.Button();
            this.btnDelM = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBigname
            // 
            this.lblBigname.AutoSize = true;
            this.lblBigname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblBigname.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBigname.Location = new System.Drawing.Point(255, 83);
            this.lblBigname.Name = "lblBigname";
            this.lblBigname.Size = new System.Drawing.Size(411, 41);
            this.lblBigname.TabIndex = 0;
            this.lblBigname.Text = "회원 관리 시스템 (VOL 0.01)\r\n";
            // 
            // lblID_Update
            // 
            this.lblID_Update.AutoSize = true;
            this.lblID_Update.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblID_Update.Location = new System.Drawing.Point(385, 22);
            this.lblID_Update.Name = "lblID_Update";
            this.lblID_Update.Size = new System.Drawing.Size(68, 20);
            this.lblID_Update.TabIndex = 7;
            this.lblID_Update.Text = "아이디 : ";
            this.lblID_Update.Visible = false;
            // 
            // lblID_Del
            // 
            this.lblID_Del.AutoSize = true;
            this.lblID_Del.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblID_Del.Location = new System.Drawing.Point(385, 65);
            this.lblID_Del.Name = "lblID_Del";
            this.lblID_Del.Size = new System.Drawing.Size(68, 20);
            this.lblID_Del.TabIndex = 8;
            this.lblID_Del.Text = "아이디 : ";
            this.lblID_Del.Visible = false;
            // 
            // tbUpUserID
            // 
            this.tbUpUserID.Location = new System.Drawing.Point(459, 17);
            this.tbUpUserID.Name = "tbUpUserID";
            this.tbUpUserID.Size = new System.Drawing.Size(161, 25);
            this.tbUpUserID.TabIndex = 9;
            this.tbUpUserID.Visible = false;
            // 
            // tbDelUserID
            // 
            this.tbDelUserID.Location = new System.Drawing.Point(459, 63);
            this.tbDelUserID.Name = "tbDelUserID";
            this.tbDelUserID.Size = new System.Drawing.Size(161, 25);
            this.tbDelUserID.TabIndex = 10;
            this.tbDelUserID.Visible = false;
            // 
            // btnUdate
            // 
            this.btnUdate.Location = new System.Drawing.Point(641, 17);
            this.btnUdate.Name = "btnUdate";
            this.btnUdate.Size = new System.Drawing.Size(147, 25);
            this.btnUdate.TabIndex = 11;
            this.btnUdate.Text = "수정하기";
            this.btnUdate.UseVisualStyleBackColor = true;
            this.btnUdate.Visible = false;
            this.btnUdate.Click += new System.EventHandler(this.btnUdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(641, 62);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(147, 26);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "탈퇴하기";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnDelM);
            this.panel1.Controls.Add(this.btnUpdateM);
            this.panel1.Controls.Add(this.btnRefM);
            this.panel1.Controls.Add(this.btnResitM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 350);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.lblID_Update);
            this.panel2.Controls.Add(this.tbUpUserID);
            this.panel2.Controls.Add(this.btnUdate);
            this.panel2.Controls.Add(this.lblID_Del);
            this.panel2.Controls.Add(this.tbDelUserID);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 14;
            // 
            // btnResitM
            // 
            this.btnResitM.BackColor = System.Drawing.SystemColors.Control;
            this.btnResitM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResitM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResitM.Location = new System.Drawing.Point(0, 0);
            this.btnResitM.Name = "btnResitM";
            this.btnResitM.Size = new System.Drawing.Size(126, 62);
            this.btnResitM.TabIndex = 0;
            this.btnResitM.Text = "회원 등록";
            this.btnResitM.UseVisualStyleBackColor = false;
            this.btnResitM.Click += new System.EventHandler(this.btnResitM_Click);
            // 
            // btnRefM
            // 
            this.btnRefM.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRefM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefM.Location = new System.Drawing.Point(0, 62);
            this.btnRefM.Name = "btnRefM";
            this.btnRefM.Size = new System.Drawing.Size(126, 62);
            this.btnRefM.TabIndex = 1;
            this.btnRefM.Text = "회원 조회";
            this.btnRefM.UseVisualStyleBackColor = false;
            this.btnRefM.Click += new System.EventHandler(this.btnRefM_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Location = new System.Drawing.Point(132, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 61);
            this.panel3.TabIndex = 15;
            // 
            // btnUpdateM
            // 
            this.btnUpdateM.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateM.Location = new System.Drawing.Point(0, 124);
            this.btnUpdateM.Name = "btnUpdateM";
            this.btnUpdateM.Size = new System.Drawing.Size(126, 62);
            this.btnUpdateM.TabIndex = 2;
            this.btnUpdateM.Text = "회원수정";
            this.btnUpdateM.UseVisualStyleBackColor = false;
            this.btnUpdateM.Click += new System.EventHandler(this.btnUpdateM_Click);
            // 
            // btnDelM
            // 
            this.btnDelM.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelM.Location = new System.Drawing.Point(0, 186);
            this.btnDelM.Name = "btnDelM";
            this.btnDelM.Size = new System.Drawing.Size(126, 62);
            this.btnDelM.TabIndex = 3;
            this.btnDelM.Text = "회원탈퇴";
            this.btnDelM.UseVisualStyleBackColor = false;
            this.btnDelM.Click += new System.EventHandler(this.btnDelM_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBigname);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "HY 헬스클럽 회원 정보시스템(ver.0.01)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBigname;
        private System.Windows.Forms.Label lblID_Update;
        private System.Windows.Forms.Label lblID_Del;
        private System.Windows.Forms.TextBox tbUpUserID;
        private System.Windows.Forms.TextBox tbDelUserID;
        private System.Windows.Forms.Button btnUdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefM;
        private System.Windows.Forms.Button btnResitM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelM;
        private System.Windows.Forms.Button btnUpdateM;
    }
}


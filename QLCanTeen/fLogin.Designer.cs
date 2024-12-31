namespace QLCanTeen
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            ckbShowpass = new CheckBox();
            btnExit = new Button();
            btnLogin = new Button();
            panel3 = new Panel();
            txbPassWord = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txbUserName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ckbShowpass);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 307);
            panel1.TabIndex = 0;
            // 
            // ckbShowpass
            // 
            ckbShowpass.AutoSize = true;
            ckbShowpass.Location = new Point(39, 196);
            ckbShowpass.Name = "ckbShowpass";
            ckbShowpass.Size = new Size(128, 24);
            ckbShowpass.TabIndex = 5;
            ckbShowpass.Text = "showPassWord";
            ckbShowpass.UseVisualStyleBackColor = true;
            ckbShowpass.CheckedChanged += ckbShowpass_CheckedChanged;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveCaption;
            btnExit.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(389, 244);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(133, 46);
            btnExit.TabIndex = 4;
            btnExit.Text = "exit ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(236, 244);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(135, 46);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassWord);
            panel3.Controls.Add(label2);
            panel3.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(20, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(502, 73);
            panel3.TabIndex = 2;
            // 
            // txbPassWord
            // 
            txbPassWord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbPassWord.Location = new Point(226, 26);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(252, 34);
            txbPassWord.TabIndex = 1;
            txbPassWord.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 26);
            label2.Name = "label2";
            label2.Size = new Size(129, 29);
            label2.TabIndex = 0;
            label2.Text = "password ";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUserName);
            panel2.Controls.Add(label1);
            panel2.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(20, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(502, 73);
            panel2.TabIndex = 0;
            // 
            // txbUserName
            // 
            txbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbUserName.Location = new Point(226, 26);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(252, 34);
            txbUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 26);
            label1.Name = "label1";
            label1.Size = new Size(137, 29);
            label1.TabIndex = 0;
            label1.Text = "username :";
            // 
            // fLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(569, 327);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "đăng nhập ";
            FormClosing += fLogin_FormClosing;
            Load += fLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox txbUserName;
        private Panel panel3;
        private TextBox txbPassWord;
        private Label label2;
        private Button btnLogin;
        private Button btnExit;
        private CheckBox ckbShowpass;
    }
}

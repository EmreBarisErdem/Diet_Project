namespace Diet_PL
{
    partial class LogInScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btn_SignUp = new Button();
            label1 = new Label();
            btn_Login = new Button();
            txt_Password = new TextBox();
            txt_UserName = new TextBox();
            Password = new Label();
            UserName = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 255, 255);
            groupBox1.Controls.Add(btn_SignUp);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_Login);
            groupBox1.Controls.Add(txt_Password);
            groupBox1.Controls.Add(txt_UserName);
            groupBox1.Controls.Add(Password);
            groupBox1.Controls.Add(UserName);
            groupBox1.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            groupBox1.Location = new Point(14, 12);
            groupBox1.Margin = new Padding(5, 3, 5, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 3, 5, 3);
            groupBox1.Size = new Size(647, 453);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Screen";
            // 
            // btn_SignUp
            // 
            btn_SignUp.BackColor = Color.NavajoWhite;
            btn_SignUp.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_SignUp.Location = new Point(288, 327);
            btn_SignUp.Margin = new Padding(5, 3, 5, 3);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(218, 45);
            btn_SignUp.TabIndex = 6;
            btn_SignUp.Text = "Sign Up";
            btn_SignUp.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            label1.Location = new Point(80, 287);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(426, 62);
            label1.TabIndex = 5;
            label1.Text = "If you are not a member, click here to register";
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Login.Location = new Point(288, 192);
            btn_Login.Margin = new Padding(5, 3, 5, 3);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(218, 45);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(288, 138);
            txt_Password.Margin = new Padding(5, 3, 5, 3);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(218, 33);
            txt_Password.TabIndex = 3;
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(288, 82);
            txt_UserName.Margin = new Padding(5, 3, 5, 3);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(218, 33);
            txt_UserName.TabIndex = 2;
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 11F);
            Password.Location = new Point(82, 138);
            Password.Margin = new Padding(5, 0, 5, 0);
            Password.Name = "Password";
            Password.Size = new Size(123, 30);
            Password.TabIndex = 1;
            Password.Text = "Password";
            // 
            // UserName
            // 
            UserName.Font = new Font("Segoe UI", 11F);
            UserName.Location = new Point(82, 82);
            UserName.Margin = new Padding(5, 0, 5, 0);
            UserName.Name = "UserName";
            UserName.Size = new Size(123, 30);
            UserName.TabIndex = 0;
            UserName.Text = "User Name";
            // 
            // LogInScreen
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 475);
            Controls.Add(groupBox1);
            Name = "LogInScreen";
            Text = "LogInScreen";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_SignUp;
        private Label label1;
        private Button btn_Login;
        private TextBox txt_Password;
        private TextBox txt_UserName;
        private Label Password;
        private Label UserName;
    }
}
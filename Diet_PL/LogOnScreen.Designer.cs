namespace Diet_PL
{
    partial class LogOnScreen
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
            label9 = new Label();
            nud_Height = new NumericUpDown();
            nud_Weight = new NumericUpDown();
            btn_SignUp = new Button();
            cmb_ActvityStatus = new ComboBox();
            cmb_Gender = new ComboBox();
            dtp_BirthDate = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            txt_LastName = new TextBox();
            txt_UserName = new TextBox();
            txt_Password = new TextBox();
            txt_FirstName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_Height).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Weight).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(63, 391);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(71, 28);
            label9.TabIndex = 38;
            label9.Text = "Height";
            // 
            // nud_Height
            // 
            nud_Height.Location = new Point(226, 382);
            nud_Height.Margin = new Padding(5, 3, 5, 3);
            nud_Height.Maximum = new decimal(new int[] { 270, 0, 0, 0 });
            nud_Height.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            nud_Height.Name = "nud_Height";
            nud_Height.Size = new Size(215, 33);
            nud_Height.TabIndex = 33;
            nud_Height.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // nud_Weight
            // 
            nud_Weight.Location = new Point(226, 337);
            nud_Weight.Margin = new Padding(5, 3, 5, 3);
            nud_Weight.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nud_Weight.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            nud_Weight.Name = "nud_Weight";
            nud_Weight.Size = new Size(217, 33);
            nud_Weight.TabIndex = 32;
            nud_Weight.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // btn_SignUp
            // 
            btn_SignUp.BackColor = Color.Bisque;
            btn_SignUp.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_SignUp.Location = new Point(63, 501);
            btn_SignUp.Margin = new Padding(5, 3, 5, 3);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(380, 82);
            btn_SignUp.TabIndex = 35;
            btn_SignUp.Text = "Sign Up";
            btn_SignUp.UseVisualStyleBackColor = false;
            btn_SignUp.Click += btn_SignUp_Click_1;
            // 
            // cmb_ActvityStatus
            // 
            cmb_ActvityStatus.FormattingEnabled = true;
            cmb_ActvityStatus.Location = new Point(226, 431);
            cmb_ActvityStatus.Margin = new Padding(5, 3, 5, 3);
            cmb_ActvityStatus.Name = "cmb_ActvityStatus";
            cmb_ActvityStatus.Size = new Size(216, 33);
            cmb_ActvityStatus.TabIndex = 34;
            // 
            // cmb_Gender
            // 
            cmb_Gender.FormattingEnabled = true;
            cmb_Gender.Location = new Point(226, 294);
            cmb_Gender.Margin = new Padding(5, 3, 5, 3);
            cmb_Gender.Name = "cmb_Gender";
            cmb_Gender.Size = new Size(216, 33);
            cmb_Gender.TabIndex = 31;
            // 
            // dtp_BirthDate
            // 
            dtp_BirthDate.Location = new Point(226, 247);
            dtp_BirthDate.Margin = new Padding(5, 3, 5, 3);
            dtp_BirthDate.Name = "dtp_BirthDate";
            dtp_BirthDate.Size = new Size(218, 33);
            dtp_BirthDate.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(63, 439);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(136, 28);
            label8.TabIndex = 37;
            label8.Text = "Activity Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(63, 346);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 28);
            label7.TabIndex = 36;
            label7.Text = "Weight";
            // 
            // txt_LastName
            // 
            txt_LastName.Location = new Point(226, 92);
            txt_LastName.Margin = new Padding(5, 3, 5, 3);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(216, 33);
            txt_LastName.TabIndex = 24;
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(226, 144);
            txt_UserName.Margin = new Padding(5, 3, 5, 3);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(216, 33);
            txt_UserName.TabIndex = 25;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(226, 196);
            txt_Password.Margin = new Padding(5, 3, 5, 3);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(216, 33);
            txt_Password.TabIndex = 27;
            // 
            // txt_FirstName
            // 
            txt_FirstName.Location = new Point(226, 39);
            txt_FirstName.Margin = new Padding(5, 3, 5, 3);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(216, 33);
            txt_FirstName.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(63, 204);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 30;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(63, 256);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 28);
            label5.TabIndex = 28;
            label5.Text = "Birth Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(63, 302);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 26;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(63, 152);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 23;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(63, 101);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 22;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(63, 47);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 20;
            label1.Text = "First Name";
            // 
            // LogOnScreen
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(508, 635);
            Controls.Add(label9);
            Controls.Add(nud_Height);
            Controls.Add(nud_Weight);
            Controls.Add(btn_SignUp);
            Controls.Add(cmb_ActvityStatus);
            Controls.Add(cmb_Gender);
            Controls.Add(dtp_BirthDate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txt_LastName);
            Controls.Add(txt_UserName);
            Controls.Add(txt_Password);
            Controls.Add(txt_FirstName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LogOnScreen";
            Text = "LogOnScreen";
            Load += LogOnScreen_Load;
            ((System.ComponentModel.ISupportInitialize)nud_Height).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Weight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private NumericUpDown nud_Height;
        private NumericUpDown nud_Weight;
        private Button btn_SignUp;
        private ComboBox cmb_ActvityStatus;
        private ComboBox cmb_Gender;
        private DateTimePicker dtp_BirthDate;
        private Label label8;
        private Label label7;
        private TextBox txt_LastName;
        private TextBox txt_UserName;
        private TextBox txt_Password;
        private TextBox txt_FirstName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
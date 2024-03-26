namespace Diet_PL
{
    partial class Admin
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
            label2 = new Label();
            label1 = new Label();
            btnDeleteFood = new Button();
            lbox_Foods = new ListBox();
            btn_MemberBan = new Button();
            lbox_Members = new ListBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(642, 587);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(499, 25);
            label2.TabIndex = 14;
            label2.Text = "Double Click To Food Name For Detailed Info And Update!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 587);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(385, 25);
            label1.TabIndex = 13;
            label1.Text = "Double Click To UserName For Detailed Info!";
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(616, 486);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(552, 75);
            btnDeleteFood.TabIndex = 12;
            btnDeleteFood.Text = "Delete Food";
            btnDeleteFood.UseVisualStyleBackColor = true;
            btnDeleteFood.Click += btnDeleteFood_Click_1;
            // 
            // lbox_Foods
            // 
            lbox_Foods.FormattingEnabled = true;
            lbox_Foods.ItemHeight = 25;
            lbox_Foods.Location = new Point(616, 32);
            lbox_Foods.Margin = new Padding(5, 3, 5, 3);
            lbox_Foods.Name = "lbox_Foods";
            lbox_Foods.Size = new Size(549, 429);
            lbox_Foods.TabIndex = 11;
            lbox_Foods.MouseDoubleClick += lbox_Foods_MouseDoubleClick;
            // 
            // btn_MemberBan
            // 
            btn_MemberBan.Location = new Point(26, 486);
            btn_MemberBan.Name = "btn_MemberBan";
            btn_MemberBan.Size = new Size(492, 75);
            btn_MemberBan.TabIndex = 10;
            btn_MemberBan.Text = "Ban Member ";
            btn_MemberBan.UseVisualStyleBackColor = true;
            btn_MemberBan.Click += btn_MemberBan_Click_1;
            // 
            // lbox_Members
            // 
            lbox_Members.FormattingEnabled = true;
            lbox_Members.ItemHeight = 25;
            lbox_Members.Location = new Point(28, 32);
            lbox_Members.Margin = new Padding(5, 3, 5, 3);
            lbox_Members.Name = "lbox_Members";
            lbox_Members.Size = new Size(488, 429);
            lbox_Members.TabIndex = 9;
            lbox_Members.MouseDoubleClick += lbox_Members_MouseDoubleClick_1;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 648);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDeleteFood);
            Controls.Add(lbox_Foods);
            Controls.Add(btn_MemberBan);
            Controls.Add(lbox_Members);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnDeleteFood;
        private ListBox lbox_Foods;
        private Button btn_MemberBan;
        private ListBox lbox_Members;
    }
}
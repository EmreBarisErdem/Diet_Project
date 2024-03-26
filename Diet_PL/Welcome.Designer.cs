namespace Diet_PL
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(745, 849);
            button1.Margin = new Padding(5, 3, 5, 3);
            button1.Name = "button1";
            button1.Size = new Size(498, 73);
            button1.TabIndex = 9;
            button1.Text = "Click For Healthy Days\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1061, 149);
            pictureBox2.Margin = new Padding(5, 3, 5, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(807, 520);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(119, 149);
            pictureBox1.Margin = new Padding(5, 3, 5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(923, 520);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(514, 43);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(1105, 82);
            label2.TabIndex = 6;
            label2.Text = "Welcome To The Healthy Diet Program";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(713, 703);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(568, 123);
            label1.TabIndex = 5;
            label1.Text = "You Can Also Lose Weight While Eating\r\nYou Must Wonder How This Works?\r\nClick Below To Find Out!\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1986, 964);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Welcome";
            Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
    }
}
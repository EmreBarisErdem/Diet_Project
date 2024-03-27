namespace Diet_PL
{
    partial class FoodDetailScreen
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
            cmbFoodCategory = new ComboBox();
            btnChangeImg = new Button();
            btnDeleteImg = new Button();
            btnUpdate = new Button();
            pBoxFoodImg = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCalories = new TextBox();
            txtFoodName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pBoxFoodImg).BeginInit();
            SuspendLayout();
            // 
            // cmbFoodCategory
            // 
            cmbFoodCategory.FormattingEnabled = true;
            cmbFoodCategory.Location = new Point(287, 205);
            cmbFoodCategory.Margin = new Padding(5);
            cmbFoodCategory.Name = "cmbFoodCategory";
            cmbFoodCategory.Size = new Size(227, 33);
            cmbFoodCategory.TabIndex = 20;
            // 
            // btnChangeImg
            // 
            btnChangeImg.Location = new Point(645, 501);
            btnChangeImg.Margin = new Padding(5);
            btnChangeImg.Name = "btnChangeImg";
            btnChangeImg.Size = new Size(394, 73);
            btnChangeImg.TabIndex = 19;
            btnChangeImg.Text = "Change Image";
            btnChangeImg.UseVisualStyleBackColor = true;
            btnChangeImg.Click += btnChangeImg_Click_1;
            // 
            // btnDeleteImg
            // 
            btnDeleteImg.Location = new Point(645, 418);
            btnDeleteImg.Margin = new Padding(5);
            btnDeleteImg.Name = "btnDeleteImg";
            btnDeleteImg.Size = new Size(394, 73);
            btnDeleteImg.TabIndex = 18;
            btnDeleteImg.Text = "Delete Image";
            btnDeleteImg.UseVisualStyleBackColor = true;
            btnDeleteImg.Click += btnDeleteImg_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(287, 365);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(229, 73);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // pBoxFoodImg
            // 
            pBoxFoodImg.BackColor = SystemColors.ButtonHighlight;
            pBoxFoodImg.Location = new Point(645, 69);
            pBoxFoodImg.Margin = new Padding(5);
            pBoxFoodImg.Name = "pBoxFoodImg";
            pBoxFoodImg.Size = new Size(394, 317);
            pBoxFoodImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxFoodImg.TabIndex = 16;
            pBoxFoodImg.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 290);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 15;
            label3.Text = "Calories";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 210);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(190, 25);
            label2.TabIndex = 14;
            label2.Text = "Food Category Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 126);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 13;
            label1.Text = "Food Name";
            // 
            // txtCalories
            // 
            txtCalories.Location = new Point(287, 285);
            txtCalories.Margin = new Padding(5);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(227, 33);
            txtCalories.TabIndex = 12;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(287, 121);
            txtFoodName.Margin = new Padding(5);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(227, 33);
            txtFoodName.TabIndex = 11;
            // 
            // FoodDetailScreen
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1113, 642);
            Controls.Add(cmbFoodCategory);
            Controls.Add(btnChangeImg);
            Controls.Add(btnDeleteImg);
            Controls.Add(btnUpdate);
            Controls.Add(pBoxFoodImg);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCalories);
            Controls.Add(txtFoodName);
            Name = "FoodDetailScreen";
            Text = "FoodDetailScreen";
            Load += FoodDetailScreen_Load_1;
            ((System.ComponentModel.ISupportInitialize)pBoxFoodImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFoodCategory;
        private Button btnChangeImg;
        private Button btnDeleteImg;
        private Button btnUpdate;
        private PictureBox pBoxFoodImg;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCalories;
        private TextBox txtFoodName;
    }
}
﻿namespace Diet_PL
{
    partial class AddingFoodScreen
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
            btn_AddImage = new Button();
            btn_AddFoodDetails = new Button();
            pboxImage = new PictureBox();
            label5 = new Label();
            txt_Calorie = new TextBox();
            txt_FoodName = new TextBox();
            cmb_Categori = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pboxImage).BeginInit();
            SuspendLayout();
            // 
            // btn_AddImage
            // 
            btn_AddImage.Font = new Font("Segoe UI", 12F);
            btn_AddImage.Location = new Point(590, 422);
            btn_AddImage.Margin = new Padding(5, 3, 5, 3);
            btn_AddImage.Name = "btn_AddImage";
            btn_AddImage.Size = new Size(352, 58);
            btn_AddImage.TabIndex = 33;
            btn_AddImage.Text = "Choose Image (Optional)";
            btn_AddImage.UseVisualStyleBackColor = true;
            // 
            // btn_AddFoodDetails
            // 
            btn_AddFoodDetails.BackColor = Color.PeachPuff;
            btn_AddFoodDetails.Font = new Font("Segoe UI", 12F);
            btn_AddFoodDetails.Location = new Point(64, 369);
            btn_AddFoodDetails.Margin = new Padding(5, 3, 5, 3);
            btn_AddFoodDetails.Name = "btn_AddFoodDetails";
            btn_AddFoodDetails.Size = new Size(443, 111);
            btn_AddFoodDetails.TabIndex = 32;
            btn_AddFoodDetails.Text = "Add Food";
            btn_AddFoodDetails.UseVisualStyleBackColor = false;
            // 
            // pboxImage
            // 
            pboxImage.BackColor = SystemColors.ButtonHighlight;
            pboxImage.Location = new Point(590, 160);
            pboxImage.Margin = new Padding(5, 3, 5, 3);
            pboxImage.Name = "pboxImage";
            pboxImage.Size = new Size(352, 231);
            pboxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxImage.TabIndex = 31;
            pboxImage.TabStop = false;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            label5.Location = new Point(64, 62);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(618, 50);
            label5.TabIndex = 30;
            label5.Text = "Installing The Required Food";
            // 
            // txt_Calorie
            // 
            txt_Calorie.Location = new Point(300, 278);
            txt_Calorie.Margin = new Padding(5, 3, 5, 3);
            txt_Calorie.Name = "txt_Calorie";
            txt_Calorie.Size = new Size(207, 33);
            txt_Calorie.TabIndex = 29;
            // 
            // txt_FoodName
            // 
            txt_FoodName.Location = new Point(300, 230);
            txt_FoodName.Margin = new Padding(5, 3, 5, 3);
            txt_FoodName.Name = "txt_FoodName";
            txt_FoodName.Size = new Size(207, 33);
            txt_FoodName.TabIndex = 28;
            // 
            // cmb_Categori
            // 
            cmb_Categori.FormattingEnabled = true;
            cmb_Categori.Location = new Point(300, 183);
            cmb_Categori.Margin = new Padding(5, 3, 5, 3);
            cmb_Categori.Name = "cmb_Categori";
            cmb_Categori.Size = new Size(207, 33);
            cmb_Categori.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(64, 281);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(230, 30);
            label3.TabIndex = 26;
            label3.Text = "Type Calory(per 100g)";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(64, 231);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(226, 32);
            label2.TabIndex = 25;
            label2.Text = "Type Food Name";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(64, 184);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(226, 32);
            label1.TabIndex = 24;
            label1.Text = "Choose Category";
            // 
            // AddingFoodScreen
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1024, 539);
            Controls.Add(btn_AddImage);
            Controls.Add(btn_AddFoodDetails);
            Controls.Add(pboxImage);
            Controls.Add(label5);
            Controls.Add(txt_Calorie);
            Controls.Add(txt_FoodName);
            Controls.Add(cmb_Categori);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddingFoodScreen";
            Text = "AddingFoodScreen";
            ((System.ComponentModel.ISupportInitialize)pboxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_AddImage;
        private Button btn_AddFoodDetails;
        private PictureBox pboxImage;
        private Label label5;
        private TextBox txt_Calorie;
        private TextBox txt_FoodName;
        private ComboBox cmb_Categori;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
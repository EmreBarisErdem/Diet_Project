namespace Diet_PL
{
    partial class OgundenYemekSec
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
            nud_Quantity = new NumericUpDown();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            btn_Transfer_Dinner = new Button();
            btn_Remove_Dinner = new Button();
            label10 = new Label();
            lbox_Dinner = new ListBox();
            btn_Transfer_Lunch = new Button();
            btn_Remove_Lunch = new Button();
            lbl_Dinner_Calories = new Label();
            lbl_Lunch_Calories = new Label();
            label8 = new Label();
            lbox_Lunch = new ListBox();
            lbl_Portion = new Label();
            lbl_SelectedFood_Calories = new Label();
            lbl_Quantity = new Label();
            label5 = new Label();
            btn_Transfer_Breakfast = new Button();
            btn_Remove_Breakfast = new Button();
            lbl_Breakfast_Calories = new Label();
            label2 = new Label();
            lbox_Breakfast = new ListBox();
            label6 = new Label();
            txt_SearchFood = new TextBox();
            btn_AddFood = new Button();
            lbox_Foods = new ListBox();
            cmb_Portion = new ComboBox();
            cmb_ChooseMeal = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_Quantity).BeginInit();
            SuspendLayout();
            // 
            // nud_Quantity
            // 
            nud_Quantity.BackColor = SystemColors.Info;
            nud_Quantity.Location = new Point(230, 573);
            nud_Quantity.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nud_Quantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_Quantity.Name = "nud_Quantity";
            nud_Quantity.Size = new Size(224, 33);
            nud_Quantity.TabIndex = 78;
            nud_Quantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline);
            label13.Location = new Point(1272, 81);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(113, 41);
            label13.TabIndex = 77;
            label13.Text = "Dinner";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline);
            label12.Location = new Point(958, 81);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(101, 41);
            label12.TabIndex = 76;
            label12.Text = "Lunch";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline);
            label11.Location = new Point(588, 81);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(154, 41);
            label11.TabIndex = 75;
            label11.Text = "BreakFast";
            // 
            // btn_Transfer_Dinner
            // 
            btn_Transfer_Dinner.BackColor = Color.Gainsboro;
            btn_Transfer_Dinner.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Transfer_Dinner.Location = new Point(1207, 669);
            btn_Transfer_Dinner.Margin = new Padding(8, 5, 8, 5);
            btn_Transfer_Dinner.Name = "btn_Transfer_Dinner";
            btn_Transfer_Dinner.Size = new Size(261, 84);
            btn_Transfer_Dinner.TabIndex = 64;
            btn_Transfer_Dinner.Text = "Confirm";
            btn_Transfer_Dinner.UseVisualStyleBackColor = false;
            btn_Transfer_Dinner.Click += btn_Transfer_Dinner_Click_1;
            // 
            // btn_Remove_Dinner
            // 
            btn_Remove_Dinner.BackColor = Color.Gainsboro;
            btn_Remove_Dinner.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Remove_Dinner.Location = new Point(1207, 557);
            btn_Remove_Dinner.Margin = new Padding(8, 5, 8, 5);
            btn_Remove_Dinner.Name = "btn_Remove_Dinner";
            btn_Remove_Dinner.Size = new Size(261, 74);
            btn_Remove_Dinner.TabIndex = 63;
            btn_Remove_Dinner.Text = "Remove Food From Dinner";
            btn_Remove_Dinner.UseVisualStyleBackColor = false;
            btn_Remove_Dinner.Click += btn_Remove_Dinner_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label10.Location = new Point(1217, 493);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(229, 25);
            label10.TabIndex = 74;
            label10.Text = "Total Calories in the Dinner";
            // 
            // lbox_Dinner
            // 
            lbox_Dinner.BackColor = Color.Gainsboro;
            lbox_Dinner.FormattingEnabled = true;
            lbox_Dinner.ItemHeight = 25;
            lbox_Dinner.Location = new Point(1207, 144);
            lbox_Dinner.Margin = new Padding(5, 3, 5, 3);
            lbox_Dinner.Name = "lbox_Dinner";
            lbox_Dinner.Size = new Size(261, 329);
            lbox_Dinner.TabIndex = 61;
            // 
            // btn_Transfer_Lunch
            // 
            btn_Transfer_Lunch.BackColor = Color.PaleTurquoise;
            btn_Transfer_Lunch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Transfer_Lunch.Location = new Point(884, 669);
            btn_Transfer_Lunch.Margin = new Padding(8, 5, 8, 5);
            btn_Transfer_Lunch.Name = "btn_Transfer_Lunch";
            btn_Transfer_Lunch.Size = new Size(251, 84);
            btn_Transfer_Lunch.TabIndex = 60;
            btn_Transfer_Lunch.Text = "Confirm";
            btn_Transfer_Lunch.UseVisualStyleBackColor = false;
            btn_Transfer_Lunch.Click += btn_Transfer_Lunch_Click_1;
            // 
            // btn_Remove_Lunch
            // 
            btn_Remove_Lunch.BackColor = Color.PaleTurquoise;
            btn_Remove_Lunch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Remove_Lunch.Location = new Point(884, 557);
            btn_Remove_Lunch.Margin = new Padding(8, 5, 8, 5);
            btn_Remove_Lunch.Name = "btn_Remove_Lunch";
            btn_Remove_Lunch.Size = new Size(251, 81);
            btn_Remove_Lunch.TabIndex = 59;
            btn_Remove_Lunch.Text = "Remove Food From Lunch";
            btn_Remove_Lunch.UseVisualStyleBackColor = false;
            btn_Remove_Lunch.Click += btn_Remove_Lunch_Click_1;
            // 
            // lbl_Dinner_Calories
            // 
            lbl_Dinner_Calories.AutoSize = true;
            lbl_Dinner_Calories.Font = new Font("Segoe UI", 9F);
            lbl_Dinner_Calories.Location = new Point(1321, 520);
            lbl_Dinner_Calories.Margin = new Padding(8, 0, 8, 0);
            lbl_Dinner_Calories.Name = "lbl_Dinner_Calories";
            lbl_Dinner_Calories.Size = new Size(64, 25);
            lbl_Dinner_Calories.TabIndex = 73;
            lbl_Dinner_Calories.Text = "...  kcal";
            // 
            // lbl_Lunch_Calories
            // 
            lbl_Lunch_Calories.AutoSize = true;
            lbl_Lunch_Calories.Font = new Font("Segoe UI", 9F);
            lbl_Lunch_Calories.Location = new Point(995, 518);
            lbl_Lunch_Calories.Margin = new Padding(8, 0, 8, 0);
            lbl_Lunch_Calories.Name = "lbl_Lunch_Calories";
            lbl_Lunch_Calories.Size = new Size(64, 25);
            lbl_Lunch_Calories.TabIndex = 72;
            lbl_Lunch_Calories.Text = "...  kcal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label8.Location = new Point(895, 493);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(222, 25);
            label8.TabIndex = 71;
            label8.Text = "Total Calories in the Lunch";
            // 
            // lbox_Lunch
            // 
            lbox_Lunch.BackColor = Color.PaleTurquoise;
            lbox_Lunch.FormattingEnabled = true;
            lbox_Lunch.ItemHeight = 25;
            lbox_Lunch.Location = new Point(884, 144);
            lbox_Lunch.Margin = new Padding(5, 3, 5, 3);
            lbox_Lunch.Name = "lbox_Lunch";
            lbox_Lunch.Size = new Size(251, 329);
            lbox_Lunch.TabIndex = 58;
            // 
            // lbl_Portion
            // 
            lbl_Portion.AutoSize = true;
            lbl_Portion.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lbl_Portion.Location = new Point(86, 619);
            lbl_Portion.Margin = new Padding(8, 0, 8, 0);
            lbl_Portion.Name = "lbl_Portion";
            lbl_Portion.Size = new Size(83, 30);
            lbl_Portion.TabIndex = 67;
            lbl_Portion.Text = "Portion";
            // 
            // lbl_SelectedFood_Calories
            // 
            lbl_SelectedFood_Calories.AutoSize = true;
            lbl_SelectedFood_Calories.Font = new Font("Segoe UI", 11F);
            lbl_SelectedFood_Calories.Location = new Point(377, 669);
            lbl_SelectedFood_Calories.Margin = new Padding(8, 0, 8, 0);
            lbl_SelectedFood_Calories.Name = "lbl_SelectedFood_Calories";
            lbl_SelectedFood_Calories.Size = new Size(77, 30);
            lbl_SelectedFood_Calories.TabIndex = 70;
            lbl_SelectedFood_Calories.Text = "...  kcal";
            // 
            // lbl_Quantity
            // 
            lbl_Quantity.AutoSize = true;
            lbl_Quantity.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lbl_Quantity.Location = new Point(86, 571);
            lbl_Quantity.Margin = new Padding(8, 0, 8, 0);
            lbl_Quantity.Name = "lbl_Quantity";
            lbl_Quantity.Size = new Size(97, 30);
            lbl_Quantity.TabIndex = 68;
            lbl_Quantity.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label5.Location = new Point(86, 669);
            label5.Margin = new Padding(8, 0, 8, 0);
            label5.Name = "label5";
            label5.Size = new Size(288, 30);
            label5.TabIndex = 69;
            label5.Text = "Calories of the selected meal";
            // 
            // btn_Transfer_Breakfast
            // 
            btn_Transfer_Breakfast.BackColor = Color.PapayaWhip;
            btn_Transfer_Breakfast.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Transfer_Breakfast.Location = new Point(529, 665);
            btn_Transfer_Breakfast.Margin = new Padding(8, 5, 8, 5);
            btn_Transfer_Breakfast.Name = "btn_Transfer_Breakfast";
            btn_Transfer_Breakfast.Size = new Size(278, 88);
            btn_Transfer_Breakfast.TabIndex = 57;
            btn_Transfer_Breakfast.Text = "Confirm";
            btn_Transfer_Breakfast.UseVisualStyleBackColor = false;
            btn_Transfer_Breakfast.Click += btn_Transfer_Breakfast_Click_1;
            // 
            // btn_Remove_Breakfast
            // 
            btn_Remove_Breakfast.BackColor = Color.PapayaWhip;
            btn_Remove_Breakfast.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Remove_Breakfast.Location = new Point(529, 559);
            btn_Remove_Breakfast.Margin = new Padding(8, 5, 8, 5);
            btn_Remove_Breakfast.Name = "btn_Remove_Breakfast";
            btn_Remove_Breakfast.Size = new Size(278, 77);
            btn_Remove_Breakfast.TabIndex = 56;
            btn_Remove_Breakfast.Text = "Remove Food From Breakfast";
            btn_Remove_Breakfast.UseVisualStyleBackColor = false;
            btn_Remove_Breakfast.Click += btn_Remove_Breakfast_Click_1;
            // 
            // lbl_Breakfast_Calories
            // 
            lbl_Breakfast_Calories.AutoSize = true;
            lbl_Breakfast_Calories.Font = new Font("Segoe UI", 9F);
            lbl_Breakfast_Calories.Location = new Point(635, 520);
            lbl_Breakfast_Calories.Margin = new Padding(8, 0, 8, 0);
            lbl_Breakfast_Calories.Name = "lbl_Breakfast_Calories";
            lbl_Breakfast_Calories.Size = new Size(64, 25);
            lbl_Breakfast_Calories.TabIndex = 66;
            lbl_Breakfast_Calories.Text = "...  kcal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label2.Location = new Point(539, 493);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(252, 25);
            label2.TabIndex = 65;
            label2.Text = "Total Calories in the BreakFast";
            // 
            // lbox_Breakfast
            // 
            lbox_Breakfast.BackColor = Color.PapayaWhip;
            lbox_Breakfast.FormattingEnabled = true;
            lbox_Breakfast.ItemHeight = 25;
            lbox_Breakfast.Location = new Point(529, 144);
            lbox_Breakfast.Margin = new Padding(5, 3, 5, 3);
            lbox_Breakfast.Name = "lbox_Breakfast";
            lbox_Breakfast.Size = new Size(278, 329);
            lbox_Breakfast.TabIndex = 55;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(61, 103);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(139, 30);
            label6.TabIndex = 62;
            label6.Text = "Search Food";
            // 
            // txt_SearchFood
            // 
            txt_SearchFood.BackColor = SystemColors.Info;
            txt_SearchFood.Location = new Point(216, 100);
            txt_SearchFood.Margin = new Padding(5, 3, 5, 3);
            txt_SearchFood.Name = "txt_SearchFood";
            txt_SearchFood.Size = new Size(238, 33);
            txt_SearchFood.TabIndex = 52;
            txt_SearchFood.TextChanged += txt_SearchFood_TextChanged_1;
            // 
            // btn_AddFood
            // 
            btn_AddFood.BackColor = SystemColors.Info;
            btn_AddFood.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_AddFood.Location = new Point(86, 719);
            btn_AddFood.Margin = new Padding(8, 5, 8, 5);
            btn_AddFood.Name = "btn_AddFood";
            btn_AddFood.Size = new Size(368, 55);
            btn_AddFood.TabIndex = 54;
            btn_AddFood.Text = "Add  Food";
            btn_AddFood.UseVisualStyleBackColor = false;
            btn_AddFood.Click += btn_AddFood_Click_1;
            // 
            // lbox_Foods
            // 
            lbox_Foods.BackColor = SystemColors.Info;
            lbox_Foods.FormattingEnabled = true;
            lbox_Foods.ItemHeight = 25;
            lbox_Foods.Location = new Point(86, 166);
            lbox_Foods.Margin = new Padding(8, 5, 8, 5);
            lbox_Foods.Name = "lbox_Foods";
            lbox_Foods.Size = new Size(368, 379);
            lbox_Foods.TabIndex = 53;
            lbox_Foods.SelectedIndexChanged += lbox_Foods_SelectedIndexChanged_1;
            // 
            // cmb_Portion
            // 
            cmb_Portion.BackColor = SystemColors.Info;
            cmb_Portion.FormattingEnabled = true;
            cmb_Portion.Location = new Point(230, 623);
            cmb_Portion.Margin = new Padding(5, 3, 5, 3);
            cmb_Portion.Name = "cmb_Portion";
            cmb_Portion.Size = new Size(224, 33);
            cmb_Portion.TabIndex = 50;
            // 
            // cmb_ChooseMeal
            // 
            cmb_ChooseMeal.BackColor = SystemColors.Info;
            cmb_ChooseMeal.FormattingEnabled = true;
            cmb_ChooseMeal.Location = new Point(216, 55);
            cmb_ChooseMeal.Margin = new Padding(5, 3, 5, 3);
            cmb_ChooseMeal.Name = "cmb_ChooseMeal";
            cmb_ChooseMeal.Size = new Size(238, 33);
            cmb_ChooseMeal.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(61, 54);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 30);
            label1.TabIndex = 49;
            label1.Text = "Choose Meal";
            // 
            // OgundenYemekSec
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1553, 808);
            Controls.Add(nud_Quantity);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(btn_Transfer_Dinner);
            Controls.Add(btn_Remove_Dinner);
            Controls.Add(label10);
            Controls.Add(lbox_Dinner);
            Controls.Add(btn_Transfer_Lunch);
            Controls.Add(btn_Remove_Lunch);
            Controls.Add(lbl_Dinner_Calories);
            Controls.Add(lbl_Lunch_Calories);
            Controls.Add(label8);
            Controls.Add(lbox_Lunch);
            Controls.Add(lbl_Portion);
            Controls.Add(lbl_SelectedFood_Calories);
            Controls.Add(lbl_Quantity);
            Controls.Add(label5);
            Controls.Add(btn_Transfer_Breakfast);
            Controls.Add(btn_Remove_Breakfast);
            Controls.Add(lbl_Breakfast_Calories);
            Controls.Add(label2);
            Controls.Add(lbox_Breakfast);
            Controls.Add(label6);
            Controls.Add(txt_SearchFood);
            Controls.Add(btn_AddFood);
            Controls.Add(lbox_Foods);
            Controls.Add(cmb_Portion);
            Controls.Add(cmb_ChooseMeal);
            Controls.Add(label1);
            Name = "OgundenYemekSec";
            Text = "Confirm";
            Load += OgundenYemekSec_Load_1;
            ((System.ComponentModel.ISupportInitialize)nud_Quantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nud_Quantity;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button btn_Transfer_Dinner;
        private Button btn_Remove_Dinner;
        private Label label10;
        private ListBox lbox_Dinner;
        private Button btn_Transfer_Lunch;
        private Button btn_Remove_Lunch;
        private Label lbl_Dinner_Calories;
        private Label lbl_Lunch_Calories;
        private Label label8;
        private ListBox lbox_Lunch;
        private Label lbl_Portion;
        private Label lbl_SelectedFood_Calories;
        private Label lbl_Quantity;
        private Label label5;
        private Button btn_Transfer_Breakfast;
        private Button btn_Remove_Breakfast;
        private Label lbl_Breakfast_Calories;
        private Label label2;
        private ListBox lbox_Breakfast;
        private Label label6;
        private TextBox txt_SearchFood;
        private Button btn_AddFood;
        private ListBox lbox_Foods;
        private ComboBox cmb_Portion;
        private ComboBox cmb_ChooseMeal;
        private Label label1;
    }
}
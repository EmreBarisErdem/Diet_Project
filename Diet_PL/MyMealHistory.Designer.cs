namespace Diet_PL
{
    partial class MyMealHistory
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
            btn_MaxFood = new Button();
            btnDailyData = new Button();
            lvi_Food = new ListView();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lvi_Meal = new ListView();
            meal = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            lbl_DifferenceCalories = new Label();
            label10 = new Label();
            lbl_DailyMaxCalories = new Label();
            label8 = new Label();
            lbl_DailyTotalCalories = new Label();
            label3 = new Label();
            lvi_FoodSales = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            btn_MonthlyData = new Button();
            dtp_Time = new DateTimePicker();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_MaxFood
            // 
            btn_MaxFood.BackColor = Color.DarkSeaGreen;
            btn_MaxFood.Location = new Point(656, 361);
            btn_MaxFood.Name = "btn_MaxFood";
            btn_MaxFood.Size = new Size(136, 35);
            btn_MaxFood.TabIndex = 50;
            btn_MaxFood.Text = "Get Max Foods";
            btn_MaxFood.UseVisualStyleBackColor = false;
            btn_MaxFood.Click += btn_MaxFood_Click;
            // 
            // btnDailyData
            // 
            btnDailyData.Location = new Point(45, 373);
            btnDailyData.Name = "btnDailyData";
            btnDailyData.Size = new Size(136, 35);
            btnDailyData.TabIndex = 49;
            btnDailyData.Text = "Get Daily Data";
            btnDailyData.UseVisualStyleBackColor = true;
            btnDailyData.Click += btnDailyData_Click;
            // 
            // lvi_Food
            // 
            lvi_Food.Columns.AddRange(new ColumnHeader[] { columnHeader13, columnHeader14, columnHeader15, columnHeader3 });
            lvi_Food.FullRowSelect = true;
            lvi_Food.GridLines = true;
            lvi_Food.Location = new Point(406, 12);
            lvi_Food.Name = "lvi_Food";
            lvi_Food.Size = new Size(407, 257);
            lvi_Food.TabIndex = 48;
            lvi_Food.UseCompatibleStateImageBehavior = false;
            lvi_Food.View = View.Details;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Food Category Name";
            columnHeader13.Width = 140;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Food Name";
            columnHeader14.Width = 80;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Quantity";
            columnHeader15.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Total Calories";
            columnHeader3.Width = 110;
            // 
            // lvi_Meal
            // 
            lvi_Meal.Columns.AddRange(new ColumnHeader[] { meal, columnHeader1, columnHeader2 });
            lvi_Meal.FullRowSelect = true;
            lvi_Meal.GridLines = true;
            lvi_Meal.Location = new Point(45, 12);
            lvi_Meal.Name = "lvi_Meal";
            lvi_Meal.Size = new Size(323, 257);
            lvi_Meal.TabIndex = 47;
            lvi_Meal.UseCompatibleStateImageBehavior = false;
            lvi_Meal.View = View.Details;
            lvi_Meal.SelectedIndexChanged += lvi_Meal_SelectedIndexChanged;
            // 
            // meal
            // 
            meal.Text = "Meal Name";
            meal.Width = 110;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Meal Date";
            columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Total Calories";
            columnHeader2.Width = 110;
            // 
            // lbl_DifferenceCalories
            // 
            lbl_DifferenceCalories.AutoSize = true;
            lbl_DifferenceCalories.Location = new Point(284, 342);
            lbl_DifferenceCalories.Name = "lbl_DifferenceCalories";
            lbl_DifferenceCalories.Size = new Size(64, 15);
            lbl_DifferenceCalories.TabIndex = 44;
            lbl_DifferenceCalories.Text = "...  Calories";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(45, 342);
            label10.Name = "label10";
            label10.Size = new Size(199, 15);
            label10.TabIndex = 43;
            label10.Text = "The difference between the two data";
            // 
            // lbl_DailyMaxCalories
            // 
            lbl_DailyMaxCalories.AutoSize = true;
            lbl_DailyMaxCalories.Location = new Point(284, 313);
            lbl_DailyMaxCalories.Name = "lbl_DailyMaxCalories";
            lbl_DailyMaxCalories.Size = new Size(64, 15);
            lbl_DailyMaxCalories.TabIndex = 42;
            lbl_DailyMaxCalories.Text = "...  Calories";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 313);
            label8.Name = "label8";
            label8.Size = new Size(136, 15);
            label8.TabIndex = 41;
            label8.Text = "Daily Maximum Calories";
            // 
            // lbl_DailyTotalCalories
            // 
            lbl_DailyTotalCalories.AutoSize = true;
            lbl_DailyTotalCalories.Location = new Point(284, 285);
            lbl_DailyTotalCalories.Name = "lbl_DailyTotalCalories";
            lbl_DailyTotalCalories.Size = new Size(64, 15);
            lbl_DailyTotalCalories.TabIndex = 40;
            lbl_DailyTotalCalories.Text = "...  Calories";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 285);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 39;
            label3.Text = "Daily Total Calories";
            // 
            // lvi_FoodSales
            // 
            lvi_FoodSales.BackColor = Color.DarkSeaGreen;
            lvi_FoodSales.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10 });
            lvi_FoodSales.FullRowSelect = true;
            lvi_FoodSales.GridLines = true;
            lvi_FoodSales.Location = new Point(406, 304);
            lvi_FoodSales.Name = "lvi_FoodSales";
            lvi_FoodSales.Size = new Size(244, 157);
            lvi_FoodSales.TabIndex = 51;
            lvi_FoodSales.UseCompatibleStateImageBehavior = false;
            lvi_FoodSales.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "FoodID";
            columnHeader8.Width = 0;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Food Name";
            columnHeader9.Width = 110;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Quantity";
            columnHeader10.Width = 200;
            // 
            // btn_MonthlyData
            // 
            btn_MonthlyData.Location = new Point(45, 426);
            btn_MonthlyData.Name = "btn_MonthlyData";
            btn_MonthlyData.Size = new Size(136, 35);
            btn_MonthlyData.TabIndex = 52;
            btn_MonthlyData.Text = "Get Monthly Data";
            btn_MonthlyData.UseVisualStyleBackColor = true;
            btn_MonthlyData.Click += btn_MonthlyData_Click;
            // 
            // dtp_Time
            // 
            dtp_Time.Location = new Point(187, 438);
            dtp_Time.Name = "dtp_Time";
            dtp_Time.Size = new Size(161, 23);
            dtp_Time.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 420);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 54;
            label1.Text = "Choose A Month To List";
            // 
            // MyMealHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(825, 482);
            Controls.Add(label1);
            Controls.Add(dtp_Time);
            Controls.Add(btn_MonthlyData);
            Controls.Add(lvi_FoodSales);
            Controls.Add(btn_MaxFood);
            Controls.Add(btnDailyData);
            Controls.Add(lvi_Food);
            Controls.Add(lvi_Meal);
            Controls.Add(lbl_DifferenceCalories);
            Controls.Add(label10);
            Controls.Add(lbl_DailyMaxCalories);
            Controls.Add(label8);
            Controls.Add(lbl_DailyTotalCalories);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "MyMealHistory";
            Text = "MyMealHistory";
            Load += MyMealHistory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_MaxFood;
        private Button btnDailyData;
        private ListView lvi_Food;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ListView lvi_Meal;
        private ColumnHeader meal;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label lbl_DifferenceCalories;
        private Label label10;
        private Label lbl_DailyMaxCalories;
        private Label label8;
        private Label lbl_DailyTotalCalories;
        private Label label3;
        private ColumnHeader columnHeader3;
        private ListView lvi_FoodSales;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Button btn_MonthlyData;
        private DateTimePicker dtp_Time;
        private Label label1;
    }
}
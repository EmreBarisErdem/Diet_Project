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
            btn_DetayGetir = new Button();
            btnDailyData = new Button();
            lvi_Food = new ListView();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            lvi_Meal = new ListView();
            meal = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label1 = new Label();
            dtp_SelectedDay = new DateTimePicker();
            lbl_DifferenceCalories = new Label();
            label10 = new Label();
            lbl_DailyMaxCalories = new Label();
            label8 = new Label();
            lbl_DailyTotalCalories = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_DetayGetir
            // 
            btn_DetayGetir.Location = new Point(231, 415);
            btn_DetayGetir.Name = "btn_DetayGetir";
            btn_DetayGetir.Size = new Size(136, 35);
            btn_DetayGetir.TabIndex = 50;
            btn_DetayGetir.Text = "DetayGetir";
            btn_DetayGetir.UseVisualStyleBackColor = true;
            // 
            // btnDailyData
            // 
            btnDailyData.Location = new Point(45, 415);
            btnDailyData.Name = "btnDailyData";
            btnDailyData.Size = new Size(136, 35);
            btnDailyData.TabIndex = 49;
            btnDailyData.Text = "Get Daily Data";
            btnDailyData.UseVisualStyleBackColor = true;
            // 
            // lvi_Food
            // 
            lvi_Food.Columns.AddRange(new ColumnHeader[] { columnHeader13, columnHeader14, columnHeader15 });
            lvi_Food.FullRowSelect = true;
            lvi_Food.GridLines = true;
            lvi_Food.Location = new Point(406, 63);
            lvi_Food.Name = "lvi_Food";
            lvi_Food.Size = new Size(323, 257);
            lvi_Food.TabIndex = 48;
            lvi_Food.UseCompatibleStateImageBehavior = false;
            lvi_Food.View = View.Details;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "FoodCategoryName";
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "FoodName";
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Calori";
            // 
            // lvi_Meal
            // 
            lvi_Meal.Columns.AddRange(new ColumnHeader[] { meal, columnHeader1, columnHeader2 });
            lvi_Meal.FullRowSelect = true;
            lvi_Meal.GridLines = true;
            lvi_Meal.Location = new Point(45, 63);
            lvi_Meal.Name = "lvi_Meal";
            lvi_Meal.Size = new Size(323, 257);
            lvi_Meal.TabIndex = 47;
            lvi_Meal.UseCompatibleStateImageBehavior = false;
            lvi_Meal.View = View.Details;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 26);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 46;
            label1.Text = "Choose Day";
            // 
            // dtp_SelectedDay
            // 
            dtp_SelectedDay.Location = new Point(182, 23);
            dtp_SelectedDay.Margin = new Padding(3, 2, 3, 2);
            dtp_SelectedDay.Name = "dtp_SelectedDay";
            dtp_SelectedDay.Size = new Size(185, 23);
            dtp_SelectedDay.TabIndex = 45;
            // 
            // lbl_DifferenceCalories
            // 
            lbl_DifferenceCalories.AutoSize = true;
            lbl_DifferenceCalories.Location = new Point(298, 386);
            lbl_DifferenceCalories.Name = "lbl_DifferenceCalories";
            lbl_DifferenceCalories.Size = new Size(64, 15);
            lbl_DifferenceCalories.TabIndex = 44;
            lbl_DifferenceCalories.Text = "...  Calories";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(45, 386);
            label10.Name = "label10";
            label10.Size = new Size(199, 15);
            label10.TabIndex = 43;
            label10.Text = "The difference between the two data";
            // 
            // lbl_DailyMaxCalories
            // 
            lbl_DailyMaxCalories.AutoSize = true;
            lbl_DailyMaxCalories.Location = new Point(298, 362);
            lbl_DailyMaxCalories.Name = "lbl_DailyMaxCalories";
            lbl_DailyMaxCalories.Size = new Size(64, 15);
            lbl_DailyMaxCalories.TabIndex = 42;
            lbl_DailyMaxCalories.Text = "...  Calories";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 362);
            label8.Name = "label8";
            label8.Size = new Size(136, 15);
            label8.TabIndex = 41;
            label8.Text = "Daily Maximum Calories";
            // 
            // lbl_DailyTotalCalories
            // 
            lbl_DailyTotalCalories.AutoSize = true;
            lbl_DailyTotalCalories.Location = new Point(298, 335);
            lbl_DailyTotalCalories.Name = "lbl_DailyTotalCalories";
            lbl_DailyTotalCalories.Size = new Size(64, 15);
            lbl_DailyTotalCalories.TabIndex = 40;
            lbl_DailyTotalCalories.Text = "...  Calories";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 335);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 39;
            label3.Text = "Daily Total Calories";
            // 
            // MyMealHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(765, 482);
            Controls.Add(btn_DetayGetir);
            Controls.Add(btnDailyData);
            Controls.Add(lvi_Food);
            Controls.Add(lvi_Meal);
            Controls.Add(label1);
            Controls.Add(dtp_SelectedDay);
            Controls.Add(lbl_DifferenceCalories);
            Controls.Add(label10);
            Controls.Add(lbl_DailyMaxCalories);
            Controls.Add(label8);
            Controls.Add(lbl_DailyTotalCalories);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "MyMealHistory";
            Text = "MyMealHistory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_DetayGetir;
        private Button btnDailyData;
        private ListView lvi_Food;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ListView lvi_Meal;
        private ColumnHeader meal;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label1;
        private DateTimePicker dtp_SelectedDay;
        private Label lbl_DifferenceCalories;
        private Label label10;
        private Label lbl_DailyMaxCalories;
        private Label label8;
        private Label lbl_DailyTotalCalories;
        private Label label3;
    }
}
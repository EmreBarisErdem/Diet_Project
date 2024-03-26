namespace Diet_PL
{
    partial class MdiForm
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
            menuStrip1 = new MenuStrip();
            addFoodToSystemToolStripMenuItem = new ToolStripMenuItem();
            chooseMealToolStripMenuItem = new ToolStripMenuItem();
            myMealHistoryToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addFoodToSystemToolStripMenuItem, chooseMealToolStripMenuItem, myMealHistoryToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1084, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // addFoodToSystemToolStripMenuItem
            // 
            addFoodToSystemToolStripMenuItem.Name = "addFoodToSystemToolStripMenuItem";
            addFoodToSystemToolStripMenuItem.Size = new Size(196, 29);
            addFoodToSystemToolStripMenuItem.Text = "Add Food To System";
            addFoodToSystemToolStripMenuItem.Click += addFoodToSystemToolStripMenuItem_Click_1;
            // 
            // chooseMealToolStripMenuItem
            // 
            chooseMealToolStripMenuItem.Name = "chooseMealToolStripMenuItem";
            chooseMealToolStripMenuItem.Size = new Size(138, 29);
            chooseMealToolStripMenuItem.Text = "Choose Meal";
            chooseMealToolStripMenuItem.Click += chooseMealToolStripMenuItem_Click_1;
            // 
            // myMealHistoryToolStripMenuItem
            // 
            myMealHistoryToolStripMenuItem.Name = "myMealHistoryToolStripMenuItem";
            myMealHistoryToolStripMenuItem.Size = new Size(165, 29);
            myMealHistoryToolStripMenuItem.Text = "My Meal History";
            myMealHistoryToolStripMenuItem.Click += myMealHistoryToolStripMenuItem_Click_1;
            // 
            // MdiForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 623);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MdiForm";
            Text = "MdiForm";
            Load += MdiForm_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addFoodToSystemToolStripMenuItem;
        private ToolStripMenuItem chooseMealToolStripMenuItem;
        private ToolStripMenuItem myMealHistoryToolStripMenuItem;
    }
}
namespace UI
{
    partial class BestellingMenuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.drinkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lunchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dinnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drinkenToolStripMenuItem,
            this.lunchToolStripMenuItem,
            this.dinnerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // drinkenToolStripMenuItem
            // 
            this.drinkenToolStripMenuItem.Name = "drinkenToolStripMenuItem";
            this.drinkenToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.drinkenToolStripMenuItem.Text = "Drinken";
            this.drinkenToolStripMenuItem.Click += new System.EventHandler(this.drinkenToolStripMenuItem_Click);
            // 
            // lunchToolStripMenuItem
            // 
            this.lunchToolStripMenuItem.Name = "lunchToolStripMenuItem";
            this.lunchToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.lunchToolStripMenuItem.Text = "Lunch";
            // 
            // dinnerToolStripMenuItem
            // 
            this.dinnerToolStripMenuItem.Name = "dinnerToolStripMenuItem";
            this.dinnerToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.dinnerToolStripMenuItem.Text = "Diner";
            // 
            // BestellingMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 444);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BestellingMenuForm";
            this.Text = "Bestelling";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem drinkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lunchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dinnerToolStripMenuItem;
    }
}
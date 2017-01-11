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
            this.bewerken_btn = new System.Windows.Forms.Button();
            this.bestellen_btn = new System.Windows.Forms.Button();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.drinkenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.drinkenToolStripMenuItem.Name = "drinkenToolStripMenuItem";
            this.drinkenToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.drinkenToolStripMenuItem.Text = "Drinken";
            this.drinkenToolStripMenuItem.Click += new System.EventHandler(this.drinkenToolStripMenuItem_Click);
            // 
            // lunchToolStripMenuItem
            // 
            this.lunchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem1});
            this.lunchToolStripMenuItem.Name = "lunchToolStripMenuItem";
            this.lunchToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.lunchToolStripMenuItem.Text = "Lunch";
            // 
            // dinnerToolStripMenuItem
            // 
            this.dinnerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem2});
            this.dinnerToolStripMenuItem.Name = "dinnerToolStripMenuItem";
            this.dinnerToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.dinnerToolStripMenuItem.Text = "Diner";
            this.dinnerToolStripMenuItem.Click += new System.EventHandler(this.dinnerToolStripMenuItem_Click);
            // 
            // bewerken_btn
            // 
            this.bewerken_btn.BackColor = System.Drawing.Color.Silver;
            this.bewerken_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bewerken_btn.Image = global::UI.Properties.Resources.Modify;
            this.bewerken_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bewerken_btn.Location = new System.Drawing.Point(12, 409);
            this.bewerken_btn.Name = "bewerken_btn";
            this.bewerken_btn.Size = new System.Drawing.Size(83, 29);
            this.bewerken_btn.TabIndex = 2;
            this.bewerken_btn.Text = "Bewerken";
            this.bewerken_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bewerken_btn.UseVisualStyleBackColor = false;
            // 
            // bestellen_btn
            // 
            this.bestellen_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.bestellen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestellen_btn.Image = global::UI.Properties.Resources.Save;
            this.bestellen_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bestellen_btn.Location = new System.Drawing.Point(196, 409);
            this.bestellen_btn.Name = "bestellen_btn";
            this.bestellen_btn.Size = new System.Drawing.Size(96, 29);
            this.bestellen_btn.TabIndex = 1;
            this.bestellen_btn.Text = "Bestellen";
            this.bestellen_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bestellen_btn.UseVisualStyleBackColor = false;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.menuToolStripMenuItem1.Text = "Menu";
            // 
            // menuToolStripMenuItem2
            // 
            this.menuToolStripMenuItem2.Name = "menuToolStripMenuItem2";
            this.menuToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.menuToolStripMenuItem2.Text = "Menu";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 199);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(279, 204);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // BestellingMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 444);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bewerken_btn);
            this.Controls.Add(this.bestellen_btn);
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
        private System.Windows.Forms.Button bestellen_btn;
        private System.Windows.Forms.Button bewerken_btn;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem2;
        private System.Windows.Forms.ListView listView1;
    }
}
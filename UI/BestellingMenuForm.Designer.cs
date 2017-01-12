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
            this.listView1 = new System.Windows.Forms.ListView();
            this.menu_tab = new System.Windows.Forms.TabControl();
            this.drinken_tab = new System.Windows.Forms.TabPage();
            this.lunch_tab = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bewerken_btn = new System.Windows.Forms.Button();
            this.bestellen_btn = new System.Windows.Forms.Button();
            this.menu_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(9, 253);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(286, 150);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // menu_tab
            // 
            this.menu_tab.Controls.Add(this.drinken_tab);
            this.menu_tab.Controls.Add(this.lunch_tab);
            this.menu_tab.Controls.Add(this.tabPage1);
            this.menu_tab.Location = new System.Drawing.Point(9, 9);
            this.menu_tab.Margin = new System.Windows.Forms.Padding(0);
            this.menu_tab.Name = "menu_tab";
            this.menu_tab.SelectedIndex = 0;
            this.menu_tab.Size = new System.Drawing.Size(286, 223);
            this.menu_tab.TabIndex = 4;
            // 
            // drinken_tab
            // 
            this.drinken_tab.Location = new System.Drawing.Point(4, 22);
            this.drinken_tab.Name = "drinken_tab";
            this.drinken_tab.Padding = new System.Windows.Forms.Padding(3);
            this.drinken_tab.Size = new System.Drawing.Size(278, 197);
            this.drinken_tab.TabIndex = 0;
            this.drinken_tab.Text = "Drinken";
            this.drinken_tab.UseVisualStyleBackColor = true;
            this.drinken_tab.Click += new System.EventHandler(this.drinken_tab_Click);
            // 
            // lunch_tab
            // 
            this.lunch_tab.Location = new System.Drawing.Point(4, 22);
            this.lunch_tab.Name = "lunch_tab";
            this.lunch_tab.Padding = new System.Windows.Forms.Padding(3);
            this.lunch_tab.Size = new System.Drawing.Size(278, 197);
            this.lunch_tab.TabIndex = 1;
            this.lunch_tab.Text = "Lunch";
            this.lunch_tab.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(278, 197);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Diner";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // BestellingMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 444);
            this.Controls.Add(this.menu_tab);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bewerken_btn);
            this.Controls.Add(this.bestellen_btn);
            this.Name = "BestellingMenuForm";
            this.Text = "Bestelling";
            this.menu_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bestellen_btn;
        private System.Windows.Forms.Button bewerken_btn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabControl menu_tab;
        private System.Windows.Forms.TabPage drinken_tab;
        private System.Windows.Forms.TabPage lunch_tab;
        private System.Windows.Forms.TabPage tabPage1;
    }
}
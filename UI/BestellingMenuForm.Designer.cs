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
            this.menu_tab = new System.Windows.Forms.TabControl();
            this.drinken_tab = new System.Windows.Forms.TabPage();
            this.listView_dranken = new System.Windows.Forms.ListView();
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lunch_tab = new System.Windows.Forms.TabPage();
            this.listView_lunch = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView_diner = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.bewerken_btn = new System.Windows.Forms.Button();
            this.bestellen_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.Aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menu_tab.SuspendLayout();
            this.drinken_tab.SuspendLayout();
            this.lunch_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
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
            this.menu_tab.Size = new System.Drawing.Size(350, 260);
            this.menu_tab.TabIndex = 8;
            // 
            // drinken_tab
            // 
            this.drinken_tab.Controls.Add(this.listView_dranken);
            this.drinken_tab.Location = new System.Drawing.Point(4, 22);
            this.drinken_tab.Name = "drinken_tab";
            this.drinken_tab.Padding = new System.Windows.Forms.Padding(3);
            this.drinken_tab.Size = new System.Drawing.Size(342, 234);
            this.drinken_tab.TabIndex = 0;
            this.drinken_tab.Text = "Drinken";
            this.drinken_tab.UseVisualStyleBackColor = true;
            // 
            // listView_dranken
            // 
            this.listView_dranken.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam,
            this.Prijs,
            this.Aantal});
            this.listView_dranken.GridLines = true;
            this.listView_dranken.Location = new System.Drawing.Point(-4, -3);
            this.listView_dranken.Name = "listView_dranken";
            this.listView_dranken.Size = new System.Drawing.Size(310, 241);
            this.listView_dranken.TabIndex = 0;
            this.listView_dranken.UseCompatibleStateImageBehavior = false;
            this.listView_dranken.View = System.Windows.Forms.View.Details;
            this.listView_dranken.SelectedIndexChanged += new System.EventHandler(this.listView_dranken_SelectedIndexChanged);
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 200;
            // 
            // Prijs
            // 
            this.Prijs.Text = "Prijs";
            // 
            // lunch_tab
            // 
            this.lunch_tab.Controls.Add(this.listView_lunch);
            this.lunch_tab.Location = new System.Drawing.Point(4, 22);
            this.lunch_tab.Name = "lunch_tab";
            this.lunch_tab.Padding = new System.Windows.Forms.Padding(3);
            this.lunch_tab.Size = new System.Drawing.Size(342, 234);
            this.lunch_tab.TabIndex = 1;
            this.lunch_tab.Text = "Lunch";
            this.lunch_tab.UseVisualStyleBackColor = true;
            // 
            // listView_lunch
            // 
            this.listView_lunch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_lunch.GridLines = true;
            this.listView_lunch.Location = new System.Drawing.Point(-4, -3);
            this.listView_lunch.Name = "listView_lunch";
            this.listView_lunch.Size = new System.Drawing.Size(350, 241);
            this.listView_lunch.TabIndex = 1;
            this.listView_lunch.UseCompatibleStateImageBehavior = false;
            this.listView_lunch.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naam";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prijs";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView_diner);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(342, 234);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Diner";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView_diner
            // 
            this.listView_diner.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView_diner.GridLines = true;
            this.listView_diner.Location = new System.Drawing.Point(-4, -3);
            this.listView_diner.Name = "listView_diner";
            this.listView_diner.Size = new System.Drawing.Size(350, 241);
            this.listView_diner.TabIndex = 1;
            this.listView_diner.UseCompatibleStateImageBehavior = false;
            this.listView_diner.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Naam";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prijs";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(9, 274);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(350, 150);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // bewerken_btn
            // 
            this.bewerken_btn.BackColor = System.Drawing.Color.Silver;
            this.bewerken_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bewerken_btn.Image = global::UI.Properties.Resources.Modify;
            this.bewerken_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bewerken_btn.Location = new System.Drawing.Point(131, 430);
            this.bewerken_btn.Name = "bewerken_btn";
            this.bewerken_btn.Size = new System.Drawing.Size(83, 36);
            this.bewerken_btn.TabIndex = 6;
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
            this.bestellen_btn.Location = new System.Drawing.Point(247, 430);
            this.bestellen_btn.Name = "bestellen_btn";
            this.bestellen_btn.Size = new System.Drawing.Size(112, 36);
            this.bestellen_btn.TabIndex = 5;
            this.bestellen_btn.Text = "Bestellen";
            this.bestellen_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bestellen_btn.UseVisualStyleBackColor = false;
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.Pink;
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.Image = global::UI.Properties.Resources.Refresh;
            this.refresh_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh_btn.Location = new System.Drawing.Point(9, 430);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(90, 36);
            this.refresh_btn.TabIndex = 16;
            this.refresh_btn.Text = "Verversen";
            this.refresh_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // Aantal
            // 
            this.Aantal.Text = "Aantal";
            this.Aantal.Width = 45;
            // 
            // BestellingMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(368, 473);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.menu_tab);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bewerken_btn);
            this.Controls.Add(this.bestellen_btn);
            this.Name = "BestellingMenuForm";
            this.Load += new System.EventHandler(this.BestellingMenuForm_Load);
            this.menu_tab.ResumeLayout(false);
            this.drinken_tab.ResumeLayout(false);
            this.lunch_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menu_tab;
        private System.Windows.Forms.TabPage drinken_tab;
        private System.Windows.Forms.ListView listView_dranken;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Prijs;
        private System.Windows.Forms.TabPage lunch_tab;
        private System.Windows.Forms.ListView listView_lunch;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView_diner;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button bewerken_btn;
        private System.Windows.Forms.Button bestellen_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.ColumnHeader Aantal;
    }
}

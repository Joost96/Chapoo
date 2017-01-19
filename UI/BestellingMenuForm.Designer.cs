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
            this.btnDrankRemove = new System.Windows.Forms.Button();
            this.btnDrankAdd = new System.Windows.Forms.Button();
            this.listViewDrank = new System.Windows.Forms.ListView();
            this.drankNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drankPrijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drankVoorraad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lunch_tab = new System.Windows.Forms.TabPage();
            this.btnLunchRemove = new System.Windows.Forms.Button();
            this.btnLunchAdd = new System.Windows.Forms.Button();
            this.listViewLunch = new System.Windows.Forms.ListView();
            this.lunchNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lunchPrijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lunchVoorraad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDinerRemove = new System.Windows.Forms.Button();
            this.btnDinerAdd = new System.Windows.Forms.Button();
            this.listViewDiner = new System.Windows.Forms.ListView();
            this.dinerNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dinerPrijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dinerVoorraad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewBestelling = new System.Windows.Forms.ListView();
            this.BestellingNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BestellingPrijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BestellingAantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BestellingComentaar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bewerken_btn = new System.Windows.Forms.Button();
            this.bestellen_btn = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxComment = new System.Windows.Forms.RichTextBox();
            this.menu_tab.SuspendLayout();
            this.drinken_tab.SuspendLayout();
            this.lunch_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelEdit.SuspendLayout();
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
            this.menu_tab.Size = new System.Drawing.Size(350, 285);
            this.menu_tab.TabIndex = 8;
            // 
            // drinken_tab
            // 
            this.drinken_tab.Controls.Add(this.btnDrankRemove);
            this.drinken_tab.Controls.Add(this.btnDrankAdd);
            this.drinken_tab.Controls.Add(this.listViewDrank);
            this.drinken_tab.Location = new System.Drawing.Point(4, 22);
            this.drinken_tab.Name = "drinken_tab";
            this.drinken_tab.Padding = new System.Windows.Forms.Padding(3);
            this.drinken_tab.Size = new System.Drawing.Size(342, 259);
            this.drinken_tab.TabIndex = 0;
            this.drinken_tab.Text = "Drinken";
            this.drinken_tab.UseVisualStyleBackColor = true;
            // 
            // btnDrankRemove
            // 
            this.btnDrankRemove.BackColor = System.Drawing.Color.Silver;
            this.btnDrankRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrankRemove.Image = global::UI.Properties.Resources.Remove;
            this.btnDrankRemove.Location = new System.Drawing.Point(234, 227);
            this.btnDrankRemove.Name = "btnDrankRemove";
            this.btnDrankRemove.Size = new System.Drawing.Size(29, 29);
            this.btnDrankRemove.TabIndex = 18;
            this.btnDrankRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDrankRemove.UseVisualStyleBackColor = false;
            this.btnDrankRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDrankAdd
            // 
            this.btnDrankAdd.BackColor = System.Drawing.Color.Silver;
            this.btnDrankAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrankAdd.Image = global::UI.Properties.Resources.Create;
            this.btnDrankAdd.Location = new System.Drawing.Point(70, 227);
            this.btnDrankAdd.Name = "btnDrankAdd";
            this.btnDrankAdd.Size = new System.Drawing.Size(29, 29);
            this.btnDrankAdd.TabIndex = 17;
            this.btnDrankAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDrankAdd.UseVisualStyleBackColor = false;
            this.btnDrankAdd.Click += new System.EventHandler(this.btnDrankAdd_Click);
            // 
            // listViewDrank
            // 
            this.listViewDrank.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.drankNaam,
            this.drankPrijs,
            this.drankVoorraad});
            this.listViewDrank.FullRowSelect = true;
            this.listViewDrank.GridLines = true;
            this.listViewDrank.HideSelection = false;
            this.listViewDrank.Location = new System.Drawing.Point(-4, -3);
            this.listViewDrank.Name = "listViewDrank";
            this.listViewDrank.Size = new System.Drawing.Size(350, 227);
            this.listViewDrank.TabIndex = 0;
            this.listViewDrank.UseCompatibleStateImageBehavior = false;
            this.listViewDrank.View = System.Windows.Forms.View.Details;
            this.listViewDrank.SelectedIndexChanged += new System.EventHandler(this.listView_dranken_SelectedIndexChanged);
            // 
            // drankNaam
            // 
            this.drankNaam.Text = "Naam";
            this.drankNaam.Width = 200;
            // 
            // drankPrijs
            // 
            this.drankPrijs.Text = "Prijs";
            // 
            // drankVoorraad
            // 
            this.drankVoorraad.Text = "Voorraad";
            // 
            // lunch_tab
            // 
            this.lunch_tab.Controls.Add(this.btnLunchRemove);
            this.lunch_tab.Controls.Add(this.btnLunchAdd);
            this.lunch_tab.Controls.Add(this.listViewLunch);
            this.lunch_tab.Location = new System.Drawing.Point(4, 22);
            this.lunch_tab.Name = "lunch_tab";
            this.lunch_tab.Padding = new System.Windows.Forms.Padding(3);
            this.lunch_tab.Size = new System.Drawing.Size(342, 259);
            this.lunch_tab.TabIndex = 1;
            this.lunch_tab.Text = "Lunch";
            this.lunch_tab.UseVisualStyleBackColor = true;
            // 
            // btnLunchRemove
            // 
            this.btnLunchRemove.BackColor = System.Drawing.Color.Silver;
            this.btnLunchRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLunchRemove.Image = global::UI.Properties.Resources.Remove;
            this.btnLunchRemove.Location = new System.Drawing.Point(233, 227);
            this.btnLunchRemove.Name = "btnLunchRemove";
            this.btnLunchRemove.Size = new System.Drawing.Size(29, 29);
            this.btnLunchRemove.TabIndex = 20;
            this.btnLunchRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLunchRemove.UseVisualStyleBackColor = false;
            this.btnLunchRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnLunchAdd
            // 
            this.btnLunchAdd.BackColor = System.Drawing.Color.Silver;
            this.btnLunchAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLunchAdd.Image = global::UI.Properties.Resources.Create;
            this.btnLunchAdd.Location = new System.Drawing.Point(69, 227);
            this.btnLunchAdd.Name = "btnLunchAdd";
            this.btnLunchAdd.Size = new System.Drawing.Size(29, 29);
            this.btnLunchAdd.TabIndex = 19;
            this.btnLunchAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLunchAdd.UseVisualStyleBackColor = false;
            this.btnLunchAdd.Click += new System.EventHandler(this.btnLunchAdd_Click);
            // 
            // listViewLunch
            // 
            this.listViewLunch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lunchNaam,
            this.lunchPrijs,
            this.lunchVoorraad});
            this.listViewLunch.FullRowSelect = true;
            this.listViewLunch.GridLines = true;
            this.listViewLunch.Location = new System.Drawing.Point(-4, -3);
            this.listViewLunch.Name = "listViewLunch";
            this.listViewLunch.Size = new System.Drawing.Size(350, 227);
            this.listViewLunch.TabIndex = 1;
            this.listViewLunch.UseCompatibleStateImageBehavior = false;
            this.listViewLunch.View = System.Windows.Forms.View.Details;
            // 
            // lunchNaam
            // 
            this.lunchNaam.Text = "Naam";
            this.lunchNaam.Width = 200;
            // 
            // lunchPrijs
            // 
            this.lunchPrijs.Text = "Prijs";
            // 
            // lunchVoorraad
            // 
            this.lunchVoorraad.Text = "voorraad";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDinerRemove);
            this.tabPage1.Controls.Add(this.btnDinerAdd);
            this.tabPage1.Controls.Add(this.listViewDiner);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(342, 259);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Diner";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDinerRemove
            // 
            this.btnDinerRemove.BackColor = System.Drawing.Color.Silver;
            this.btnDinerRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinerRemove.Image = global::UI.Properties.Resources.Remove;
            this.btnDinerRemove.Location = new System.Drawing.Point(234, 227);
            this.btnDinerRemove.Name = "btnDinerRemove";
            this.btnDinerRemove.Size = new System.Drawing.Size(29, 29);
            this.btnDinerRemove.TabIndex = 20;
            this.btnDinerRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDinerRemove.UseVisualStyleBackColor = false;
            this.btnDinerRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDinerAdd
            // 
            this.btnDinerAdd.BackColor = System.Drawing.Color.Silver;
            this.btnDinerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinerAdd.Image = global::UI.Properties.Resources.Create;
            this.btnDinerAdd.Location = new System.Drawing.Point(70, 227);
            this.btnDinerAdd.Name = "btnDinerAdd";
            this.btnDinerAdd.Size = new System.Drawing.Size(29, 29);
            this.btnDinerAdd.TabIndex = 19;
            this.btnDinerAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDinerAdd.UseVisualStyleBackColor = false;
            this.btnDinerAdd.Click += new System.EventHandler(this.btnDinerAdd_Click);
            // 
            // listViewDiner
            // 
            this.listViewDiner.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dinerNaam,
            this.dinerPrijs,
            this.dinerVoorraad});
            this.listViewDiner.FullRowSelect = true;
            this.listViewDiner.GridLines = true;
            this.listViewDiner.Location = new System.Drawing.Point(-4, -3);
            this.listViewDiner.Name = "listViewDiner";
            this.listViewDiner.Size = new System.Drawing.Size(350, 227);
            this.listViewDiner.TabIndex = 1;
            this.listViewDiner.UseCompatibleStateImageBehavior = false;
            this.listViewDiner.View = System.Windows.Forms.View.Details;
            // 
            // dinerNaam
            // 
            this.dinerNaam.Text = "Naam";
            this.dinerNaam.Width = 200;
            // 
            // dinerPrijs
            // 
            this.dinerPrijs.Text = "Prijs";
            // 
            // dinerVoorraad
            // 
            this.dinerVoorraad.Text = "Voorraad";
            // 
            // listviewBestelling
            // 
            this.listviewBestelling.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BestellingNaam,
            this.BestellingPrijs,
            this.BestellingAantal,
            this.BestellingComentaar});
            this.listviewBestelling.FullRowSelect = true;
            this.listviewBestelling.GridLines = true;
            this.listviewBestelling.HideSelection = false;
            this.listviewBestelling.Location = new System.Drawing.Point(9, 297);
            this.listviewBestelling.MultiSelect = false;
            this.listviewBestelling.Name = "listviewBestelling";
            this.listviewBestelling.Size = new System.Drawing.Size(350, 127);
            this.listviewBestelling.TabIndex = 7;
            this.listviewBestelling.UseCompatibleStateImageBehavior = false;
            this.listviewBestelling.View = System.Windows.Forms.View.Details;
            // 
            // BestellingNaam
            // 
            this.BestellingNaam.Text = "Naam";
            this.BestellingNaam.Width = 150;
            // 
            // BestellingPrijs
            // 
            this.BestellingPrijs.Text = "Prijs";
            this.BestellingPrijs.Width = 58;
            // 
            // BestellingAantal
            // 
            this.BestellingAantal.Text = "Aantal";
            this.BestellingAantal.Width = 50;
            // 
            // BestellingComentaar
            // 
            this.BestellingComentaar.Text = "Comentaar";
            this.BestellingComentaar.Width = 105;
            // 
            // bewerken_btn
            // 
            this.bewerken_btn.BackColor = System.Drawing.Color.Silver;
            this.bewerken_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bewerken_btn.Image = global::UI.Properties.Resources.Modify;
            this.bewerken_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bewerken_btn.Location = new System.Drawing.Point(130, 430);
            this.bewerken_btn.Name = "bewerken_btn";
            this.bewerken_btn.Size = new System.Drawing.Size(83, 36);
            this.bewerken_btn.TabIndex = 6;
            this.bewerken_btn.Text = "Comentaar";
            this.bewerken_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bewerken_btn.UseVisualStyleBackColor = false;
            this.bewerken_btn.Click += new System.EventHandler(this.bewerken_btn_Click);
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
            this.bestellen_btn.Click += new System.EventHandler(this.bestellen_btn_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.btnSave);
            this.panelEdit.Controls.Add(this.label1);
            this.panelEdit.Controls.Add(this.txtBoxComment);
            this.panelEdit.Location = new System.Drawing.Point(9, 9);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(350, 285);
            this.panelEdit.TabIndex = 19;
            this.panelEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::UI.Properties.Resources.Modify;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(282, 239);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(58, 36);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comment :";
            // 
            // txtBoxComment
            // 
            this.txtBoxComment.Location = new System.Drawing.Point(4, 41);
            this.txtBoxComment.MaxLength = 200;
            this.txtBoxComment.Name = "txtBoxComment";
            this.txtBoxComment.Size = new System.Drawing.Size(342, 192);
            this.txtBoxComment.TabIndex = 0;
            this.txtBoxComment.Text = "";
            // 
            // BestellingMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(368, 473);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.menu_tab);
            this.Controls.Add(this.listviewBestelling);
            this.Controls.Add(this.bewerken_btn);
            this.Controls.Add(this.bestellen_btn);
            this.Name = "BestellingMenuForm";
            this.Text = "Chapoo 15:06";
            this.Load += new System.EventHandler(this.BestellingMenuForm_Load);
            this.menu_tab.ResumeLayout(false);
            this.drinken_tab.ResumeLayout(false);
            this.lunch_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menu_tab;
        private System.Windows.Forms.TabPage drinken_tab;
        private System.Windows.Forms.ListView listViewDrank;
        private System.Windows.Forms.ColumnHeader drankNaam;
        private System.Windows.Forms.ColumnHeader drankPrijs;
        private System.Windows.Forms.TabPage lunch_tab;
        private System.Windows.Forms.ListView listViewLunch;
        private System.Windows.Forms.ColumnHeader lunchNaam;
        private System.Windows.Forms.ColumnHeader lunchPrijs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listViewDiner;
        private System.Windows.Forms.ColumnHeader dinerNaam;
        private System.Windows.Forms.ColumnHeader dinerPrijs;
        private System.Windows.Forms.ListView listviewBestelling;
        private System.Windows.Forms.Button bewerken_btn;
        private System.Windows.Forms.Button bestellen_btn;
        private System.Windows.Forms.Button btnDrankRemove;
        private System.Windows.Forms.Button btnDrankAdd;
        private System.Windows.Forms.ColumnHeader BestellingNaam;
        private System.Windows.Forms.ColumnHeader BestellingPrijs;
        private System.Windows.Forms.ColumnHeader BestellingAantal;
        private System.Windows.Forms.ColumnHeader drankVoorraad;
        private System.Windows.Forms.ColumnHeader lunchVoorraad;
        private System.Windows.Forms.ColumnHeader dinerVoorraad;
        private System.Windows.Forms.Button btnLunchRemove;
        private System.Windows.Forms.Button btnLunchAdd;
        private System.Windows.Forms.Button btnDinerRemove;
        private System.Windows.Forms.Button btnDinerAdd;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.RichTextBox txtBoxComment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader BestellingComentaar;
    }
}

namespace UI
{
    partial class BetalenForm
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
            this.listViewRekOverzicht = new System.Windows.Forms.ListView();
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxFooi = new System.Windows.Forms.TextBox();
            this.lblFooi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.betalen_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewRekOverzicht
            // 
            this.listViewRekOverzicht.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam,
            this.Aantal,
            this.Prijs});
            this.listViewRekOverzicht.GridLines = true;
            this.listViewRekOverzicht.Location = new System.Drawing.Point(13, 13);
            this.listViewRekOverzicht.Name = "listViewRekOverzicht";
            this.listViewRekOverzicht.Size = new System.Drawing.Size(343, 307);
            this.listViewRekOverzicht.TabIndex = 0;
            this.listViewRekOverzicht.UseCompatibleStateImageBehavior = false;
            this.listViewRekOverzicht.View = System.Windows.Forms.View.Details;
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 195;
            // 
            // Aantal
            // 
            this.Aantal.Text = "Aantal";
            this.Aantal.Width = 70;
            // 
            // Prijs
            // 
            this.Prijs.Text = "Prijs";
            this.Prijs.Width = 70;
            // 
            // textBoxFooi
            // 
            this.textBoxFooi.Location = new System.Drawing.Point(241, 327);
            this.textBoxFooi.Name = "textBoxFooi";
            this.textBoxFooi.Size = new System.Drawing.Size(114, 20);
            this.textBoxFooi.TabIndex = 1;
            // 
            // lblFooi
            // 
            this.lblFooi.AutoSize = true;
            this.lblFooi.Location = new System.Drawing.Point(10, 330);
            this.lblFooi.Name = "lblFooi";
            this.lblFooi.Size = new System.Drawing.Size(36, 13);
            this.lblFooi.TabIndex = 2;
            this.lblFooi.Text = "Fooi +";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Totaal";
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaal.Location = new System.Drawing.Point(318, 365);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(32, 13);
            this.lblTotaal.TabIndex = 4;
            this.lblTotaal.Text = "0,00";
            // 
            // betalen_btn
            // 
            this.betalen_btn.BackColor = System.Drawing.Color.Salmon;
            this.betalen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betalen_btn.Image = global::UI.Properties.Resources.Shopping_cart;
            this.betalen_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.betalen_btn.Location = new System.Drawing.Point(241, 425);
            this.betalen_btn.Name = "betalen_btn";
            this.betalen_btn.Size = new System.Drawing.Size(114, 36);
            this.betalen_btn.TabIndex = 10;
            this.betalen_btn.Text = "Betalen";
            this.betalen_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.betalen_btn.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cash",
            "Pin",
            "MC"});
            this.comboBox1.Location = new System.Drawing.Point(241, 390);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Create;
            this.pictureBox1.Location = new System.Drawing.Point(215, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 24);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // BetalenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(368, 473);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.betalen_btn);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFooi);
            this.Controls.Add(this.textBoxFooi);
            this.Controls.Add(this.listViewRekOverzicht);
            this.Name = "BetalenForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewRekOverzicht;
        private System.Windows.Forms.TextBox textBoxFooi;
        private System.Windows.Forms.Label lblFooi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.Button betalen_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Aantal;
        private System.Windows.Forms.ColumnHeader Prijs;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

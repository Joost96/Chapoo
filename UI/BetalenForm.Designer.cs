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
            this.label1 = new System.Windows.Forms.Label();
            this.CommentaarBox_txt = new System.Windows.Forms.TextBox();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BetaalDrop_btn = new System.Windows.Forms.ComboBox();
            this.betalen_btn = new System.Windows.Forms.Button();
            this.lblSubtotaal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFooi = new System.Windows.Forms.Label();
            this.txtBoxFooi = new System.Windows.Forms.TextBox();
            this.listViewRekOverzicht = new System.Windows.Forms.ListView();
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Commentaar";
            // 
            // CommentaarBox_txt
            // 
            this.CommentaarBox_txt.Location = new System.Drawing.Point(13, 397);
            this.CommentaarBox_txt.Name = "CommentaarBox_txt";
            this.CommentaarBox_txt.Size = new System.Drawing.Size(171, 20);
            this.CommentaarBox_txt.TabIndex = 16;
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaal.Location = new System.Drawing.Point(318, 353);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(32, 13);
            this.lblTotaal.TabIndex = 14;
            this.lblTotaal.Text = "0,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Totaal";
            // 
            // BetaalDrop_btn
            // 
            this.BetaalDrop_btn.FormattingEnabled = true;
            this.BetaalDrop_btn.Items.AddRange(new object[] {
            "Cash",
            "Pin",
            "MC"});
            this.BetaalDrop_btn.Location = new System.Drawing.Point(241, 396);
            this.BetaalDrop_btn.Name = "BetaalDrop_btn";
            this.BetaalDrop_btn.Size = new System.Drawing.Size(114, 21);
            this.BetaalDrop_btn.TabIndex = 11;
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
            this.betalen_btn.Click += new System.EventHandler(this.betalen_btn_Click);
            // 
            // lblSubtotaal
            // 
            this.lblSubtotaal.AutoSize = true;
            this.lblSubtotaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotaal.Location = new System.Drawing.Point(318, 308);
            this.lblSubtotaal.Name = "lblSubtotaal";
            this.lblSubtotaal.Size = new System.Drawing.Size(28, 13);
            this.lblSubtotaal.TabIndex = 4;
            this.lblSubtotaal.Text = "0,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subtotaal";
            // 
            // lblFooi
            // 
            this.lblFooi.AutoSize = true;
            this.lblFooi.Location = new System.Drawing.Point(10, 331);
            this.lblFooi.Name = "lblFooi";
            this.lblFooi.Size = new System.Drawing.Size(27, 13);
            this.lblFooi.TabIndex = 2;
            this.lblFooi.Text = "Fooi";
            // 
            // txtBoxFooi
            // 
            this.txtBoxFooi.Location = new System.Drawing.Point(241, 328);
            this.txtBoxFooi.Name = "txtBoxFooi";
            this.txtBoxFooi.Size = new System.Drawing.Size(114, 20);
            this.txtBoxFooi.TabIndex = 1;
            this.txtBoxFooi.Text = "0,00";
            this.txtBoxFooi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxFooi.TextChanged += new System.EventHandler(this.txtBoxFooi_TextChanged);
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
            this.listViewRekOverzicht.Size = new System.Drawing.Size(343, 283);
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
            // BetalenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(368, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CommentaarBox_txt);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BetaalDrop_btn);
            this.Controls.Add(this.betalen_btn);
            this.Controls.Add(this.lblSubtotaal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFooi);
            this.Controls.Add(this.txtBoxFooi);
            this.Controls.Add(this.listViewRekOverzicht);
            this.Name = "BetalenForm";
            this.Text = "Chapoo 12:28 PM";
            this.Load += new System.EventHandler(this.BetalenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewRekOverzicht;
        private System.Windows.Forms.TextBox txtBoxFooi;
        private System.Windows.Forms.Label lblFooi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSubtotaal;
        private System.Windows.Forms.Button betalen_btn;
        private System.Windows.Forms.ComboBox BetaalDrop_btn;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Aantal;
        private System.Windows.Forms.ColumnHeader Prijs;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CommentaarBox_txt;
    }
}

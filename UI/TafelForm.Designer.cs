namespace UI
{
    partial class TafelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TafelForm));
            this.listview_bestelling = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.betalen_btn = new System.Windows.Forms.Button();
            this.bestellen_btn = new System.Windows.Forms.Button();
            this.serveer_btn = new System.Windows.Forms.Button();
            this.warning_lbl = new System.Windows.Forms.Label();
            this.warning2_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listview_bestelling
            // 
            this.listview_bestelling.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listview_bestelling.FullRowSelect = true;
            this.listview_bestelling.GridLines = true;
            this.listview_bestelling.Location = new System.Drawing.Point(15, 12);
            this.listview_bestelling.Name = "listview_bestelling";
            this.listview_bestelling.Size = new System.Drawing.Size(341, 387);
            this.listview_bestelling.TabIndex = 10;
            this.listview_bestelling.UseCompatibleStateImageBehavior = false;
            this.listview_bestelling.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Aantal";
            this.columnHeader2.Width = 42;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Commentaar";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prijs";
            this.columnHeader4.Width = 42;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.Width = 55;
            // 
            // betalen_btn
            // 
            this.betalen_btn.BackColor = System.Drawing.Color.SandyBrown;
            this.betalen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betalen_btn.Image = global::UI.Properties.Resources.Shopping_cart;
            this.betalen_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.betalen_btn.Location = new System.Drawing.Point(269, 405);
            this.betalen_btn.Name = "betalen_btn";
            this.betalen_btn.Size = new System.Drawing.Size(87, 36);
            this.betalen_btn.TabIndex = 9;
            this.betalen_btn.Text = "Betalen";
            this.betalen_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.betalen_btn.UseVisualStyleBackColor = false;
            this.betalen_btn.Click += new System.EventHandler(this.betalen_btn_Click);
            // 
            // bestellen_btn
            // 
            this.bestellen_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.bestellen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestellen_btn.Image = global::UI.Properties.Resources.Save;
            this.bestellen_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bestellen_btn.Location = new System.Drawing.Point(15, 405);
            this.bestellen_btn.Name = "bestellen_btn";
            this.bestellen_btn.Size = new System.Drawing.Size(87, 36);
            this.bestellen_btn.TabIndex = 8;
            this.bestellen_btn.Text = "Bestellen";
            this.bestellen_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bestellen_btn.UseVisualStyleBackColor = false;
            this.bestellen_btn.Click += new System.EventHandler(this.bestellen_btn_Click);
            // 
            // serveer_btn
            // 
            this.serveer_btn.BackColor = System.Drawing.Color.Yellow;
            this.serveer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serveer_btn.Image = ((System.Drawing.Image)(resources.GetObject("serveer_btn.Image")));
            this.serveer_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serveer_btn.Location = new System.Drawing.Point(138, 405);
            this.serveer_btn.Name = "serveer_btn";
            this.serveer_btn.Size = new System.Drawing.Size(87, 36);
            this.serveer_btn.TabIndex = 11;
            this.serveer_btn.Text = "Serveren";
            this.serveer_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.serveer_btn.UseVisualStyleBackColor = false;
            this.serveer_btn.Click += new System.EventHandler(this.serveer_btn_Click);
            // 
            // warning_lbl
            // 
            this.warning_lbl.AutoSize = true;
            this.warning_lbl.ForeColor = System.Drawing.Color.Red;
            this.warning_lbl.Location = new System.Drawing.Point(108, 451);
            this.warning_lbl.Name = "warning_lbl";
            this.warning_lbl.Size = new System.Drawing.Size(224, 13);
            this.warning_lbl.TabIndex = 12;
            this.warning_lbl.Text = "Een product kan nog niet geserveerd worden!";
            this.warning_lbl.Visible = false;
            // 
            // warning2_lbl
            // 
            this.warning2_lbl.AutoSize = true;
            this.warning2_lbl.ForeColor = System.Drawing.Color.Red;
            this.warning2_lbl.Location = new System.Drawing.Point(108, 451);
            this.warning2_lbl.Name = "warning2_lbl";
            this.warning2_lbl.Size = new System.Drawing.Size(147, 13);
            this.warning2_lbl.TabIndex = 13;
            this.warning2_lbl.Text = "Voeg eerst een bestelling toe!";
            this.warning2_lbl.Visible = false;
            // 
            // TafelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(368, 473);
            this.Controls.Add(this.warning2_lbl);
            this.Controls.Add(this.warning_lbl);
            this.Controls.Add(this.serveer_btn);
            this.Controls.Add(this.listview_bestelling);
            this.Controls.Add(this.betalen_btn);
            this.Controls.Add(this.bestellen_btn);
            this.Name = "TafelForm";
            this.Text = "Chapoo 15:43";
            this.Load += new System.EventHandler(this.TafelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bestellen_btn;
        private System.Windows.Forms.Button betalen_btn;
        private System.Windows.Forms.ListView listview_bestelling;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button serveer_btn;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label warning_lbl;
        private System.Windows.Forms.Label warning2_lbl;

    }
}

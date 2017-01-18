namespace UI
{
    partial class KeukenBarForm
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
            this.logout_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.bereiden_btn = new System.Windows.Forms.Button();
            this.klaar_btn = new System.Windows.Forms.Button();
            this.listView_keukenBar = new System.Windows.Forms.ListView();
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tafel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tijd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // logout_btn
            // 
            this.logout_btn.Image = global::UI.Properties.Resources.Exit;
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(705, 12);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(67, 28);
            this.logout_btn.TabIndex = 16;
            this.logout_btn.Text = "Logout";
            this.logout_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.Pink;
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.Image = global::UI.Properties.Resources.Refresh;
            this.refresh_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh_btn.Location = new System.Drawing.Point(12, 502);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(110, 51);
            this.refresh_btn.TabIndex = 15;
            this.refresh_btn.Text = "Verversen";
            this.refresh_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refresh_btn.UseVisualStyleBackColor = false;
            // 
            // bereiden_btn
            // 
            this.bereiden_btn.BackColor = System.Drawing.Color.Yellow;
            this.bereiden_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bereiden_btn.Image = global::UI.Properties.Resources.History;
            this.bereiden_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bereiden_btn.Location = new System.Drawing.Point(543, 502);
            this.bereiden_btn.Name = "bereiden_btn";
            this.bereiden_btn.Size = new System.Drawing.Size(108, 51);
            this.bereiden_btn.TabIndex = 14;
            this.bereiden_btn.Text = "Bereiden";
            this.bereiden_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bereiden_btn.UseVisualStyleBackColor = false;
            // 
            // klaar_btn
            // 
            this.klaar_btn.BackColor = System.Drawing.Color.Lime;
            this.klaar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klaar_btn.Image = global::UI.Properties.Resources.OK;
            this.klaar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.klaar_btn.Location = new System.Drawing.Point(657, 502);
            this.klaar_btn.Name = "klaar_btn";
            this.klaar_btn.Size = new System.Drawing.Size(115, 51);
            this.klaar_btn.TabIndex = 13;
            this.klaar_btn.Text = "Klaar";
            this.klaar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.klaar_btn.UseVisualStyleBackColor = false;
            // 
            // listView_keukenBar
            // 
            this.listView_keukenBar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam,
            this.Aantal,
            this.Status,
            this.Tafel,
            this.cm,
            this.tijd});
            this.listView_keukenBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_keukenBar.GridLines = true;
            this.listView_keukenBar.Location = new System.Drawing.Point(12, 49);
            this.listView_keukenBar.Name = "listView_keukenBar";
            this.listView_keukenBar.Size = new System.Drawing.Size(760, 445);
            this.listView_keukenBar.TabIndex = 12;
            this.listView_keukenBar.UseCompatibleStateImageBehavior = false;
            this.listView_keukenBar.View = System.Windows.Forms.View.Details;
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 260;
            // 
            // Aantal
            // 
            this.Aantal.Text = "Aantal";
            this.Aantal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Aantal.Width = 70;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Status.Width = 70;
            // 
            // Tafel
            // 
            this.Tafel.Text = "Tafel";
            this.Tafel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tafel.Width = 70;
            // 
            // cm
            // 
            this.cm.Text = "Commentaar";
            this.cm.Width = 218;
            // 
            // tijd
            // 
            this.tijd.Text = "Tijd";
            this.tijd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tijd.Width = 70;
            // 
            // KeukenBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.bereiden_btn);
            this.Controls.Add(this.klaar_btn);
            this.Controls.Add(this.listView_keukenBar);
            this.Name = "KeukenBarForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button bereiden_btn;
        private System.Windows.Forms.Button klaar_btn;
        private System.Windows.Forms.ListView listView_keukenBar;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Aantal;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Tafel;
        private System.Windows.Forms.ColumnHeader cm;
        private System.Windows.Forms.ColumnHeader tijd;
    }
}

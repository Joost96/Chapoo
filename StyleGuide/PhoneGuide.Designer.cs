namespace StyleGuide
{
    partial class PhoneGuide
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
            this.DateTime_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateTime_lbl
            // 
            this.DateTime_lbl.AutoSize = true;
            this.DateTime_lbl.Location = new System.Drawing.Point(263, 9);
            this.DateTime_lbl.Name = "DateTime_lbl";
            this.DateTime_lbl.Size = new System.Drawing.Size(73, 13);
            this.DateTime_lbl.TabIndex = 0;
            this.DateTime_lbl.Text = "Tijd en Datum";
            this.DateTime_lbl.Click += new System.EventHandler(this.DateTime_lbl_Click);
            // 
            // PhoneGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(368, 473);
            this.Controls.Add(this.DateTime_lbl);
            this.Name = "PhoneGuide";
            this.Load += new System.EventHandler(this.PhoneGuide_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateTime_lbl;

    }
}

namespace UI
{
    partial class EigenaarForm
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
            this.UC_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UC_image)).BeginInit();
            this.SuspendLayout();
            // 
            // logout_btn
            // 
            this.logout_btn.Image = global::UI.Properties.Resources.Exit;
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(705, 12);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(67, 28);
            this.logout_btn.TabIndex = 13;
            this.logout_btn.Text = "Logout";
            this.logout_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // UC_image
            // 
            this.UC_image.Image = global::UI.Properties.Resources.under_construction;
            this.UC_image.Location = new System.Drawing.Point(213, 164);
            this.UC_image.Name = "UC_image";
            this.UC_image.Size = new System.Drawing.Size(344, 263);
            this.UC_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UC_image.TabIndex = 12;
            this.UC_image.TabStop = false;
            // 
            // EigenaarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.UC_image);
            this.Name = "EigenaarForm";
            ((System.ComponentModel.ISupportInitialize)(this.UC_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.PictureBox UC_image;
    }
}

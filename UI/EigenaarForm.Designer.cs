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
            this.UC_image = new System.Windows.Forms.PictureBox();
            this.logout_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UC_image)).BeginInit();
            this.SuspendLayout();
            // 
            // UC_image
            // 
            this.UC_image.Image = global::UI.Properties.Resources.under_construction;
            this.UC_image.Location = new System.Drawing.Point(12, 106);
            this.UC_image.Name = "UC_image";
            this.UC_image.Size = new System.Drawing.Size(344, 263);
            this.UC_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UC_image.TabIndex = 0;
            this.UC_image.TabStop = false;
            this.UC_image.Click += new System.EventHandler(this.UC_image_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Image = global::UI.Properties.Resources.Exit;
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(289, 12);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(67, 28);
            this.logout_btn.TabIndex = 11;
            this.logout_btn.Text = "Logout";
            this.logout_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logout_btn.UseVisualStyleBackColor = true;
            // 
            // EigenaarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 473);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.UC_image);
            this.Name = "EigenaarForm";
            this.Text = "Chapoo";
            this.Load += new System.EventHandler(this.EigenaarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UC_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox UC_image;
        private System.Windows.Forms.Button logout_btn;
    }
}
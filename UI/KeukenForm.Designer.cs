namespace UI
{
    partial class KeukenForm
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
            this.refresh_btn = new System.Windows.Forms.Button();
            this.bereiden_btn = new System.Windows.Forms.Button();
            this.klaar_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(279, 361);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.Pink;
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.Image = global::UI.Properties.Resources.Refresh;
            this.refresh_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh_btn.Location = new System.Drawing.Point(13, 409);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(90, 27);
            this.refresh_btn.TabIndex = 4;
            this.refresh_btn.Text = "Verversen";
            this.refresh_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refresh_btn.UseVisualStyleBackColor = false;
            // 
            // bereiden_btn
            // 
            this.bereiden_btn.BackColor = System.Drawing.Color.Yellow;
            this.bereiden_btn.Image = global::UI.Properties.Resources.History;
            this.bereiden_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bereiden_btn.Location = new System.Drawing.Point(155, 409);
            this.bereiden_btn.Name = "bereiden_btn";
            this.bereiden_btn.Size = new System.Drawing.Size(73, 27);
            this.bereiden_btn.TabIndex = 3;
            this.bereiden_btn.Text = "Bereiden";
            this.bereiden_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bereiden_btn.UseVisualStyleBackColor = false;
            // 
            // klaar_btn
            // 
            this.klaar_btn.BackColor = System.Drawing.Color.Lime;
            this.klaar_btn.Image = global::UI.Properties.Resources.OK;
            this.klaar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.klaar_btn.Location = new System.Drawing.Point(232, 409);
            this.klaar_btn.Name = "klaar_btn";
            this.klaar_btn.Size = new System.Drawing.Size(59, 27);
            this.klaar_btn.TabIndex = 2;
            this.klaar_btn.Text = "Klaar";
            this.klaar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.klaar_btn.UseVisualStyleBackColor = false;
            // 
            // logout_btn
            // 
            this.logout_btn.Image = global::UI.Properties.Resources.Exit;
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(224, 9);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(67, 23);
            this.logout_btn.TabIndex = 1;
            this.logout_btn.Text = "Logout";
            this.logout_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // KeukenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 444);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.bereiden_btn);
            this.Controls.Add(this.klaar_btn);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.listView1);
            this.Name = "KeukenForm";
            this.Text = "Keuken";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button klaar_btn;
        private System.Windows.Forms.Button bereiden_btn;
        private System.Windows.Forms.Button refresh_btn;
    }
}
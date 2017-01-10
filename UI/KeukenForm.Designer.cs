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
            this.logout_btn = new System.Windows.Forms.Button();
            this.klaar_btn = new System.Windows.Forms.Button();
            this.bereiden_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(279, 361);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(216, 9);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(75, 23);
            this.logout_btn.TabIndex = 1;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // klaar_btn
            // 
            this.klaar_btn.BackColor = System.Drawing.Color.Lime;
            this.klaar_btn.Location = new System.Drawing.Point(216, 409);
            this.klaar_btn.Name = "klaar_btn";
            this.klaar_btn.Size = new System.Drawing.Size(75, 23);
            this.klaar_btn.TabIndex = 2;
            this.klaar_btn.Text = "Klaar";
            this.klaar_btn.UseVisualStyleBackColor = false;
            // 
            // bereiden_btn
            // 
            this.bereiden_btn.BackColor = System.Drawing.Color.Yellow;
            this.bereiden_btn.Location = new System.Drawing.Point(135, 409);
            this.bereiden_btn.Name = "bereiden_btn";
            this.bereiden_btn.Size = new System.Drawing.Size(75, 23);
            this.bereiden_btn.TabIndex = 3;
            this.bereiden_btn.Text = "Bereiden";
            this.bereiden_btn.UseVisualStyleBackColor = false;
            // 
            // KeukenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 444);
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
    }
}
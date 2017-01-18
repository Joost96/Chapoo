namespace UI
{
    partial class OverzichtForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bezet_lbl = new System.Windows.Forms.Label();
            this.gereserveerd_lbl = new System.Windows.Forms.Label();
            this.beschikbaar_lbl = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 67);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(340, 309);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // bezet_lbl
            // 
            this.bezet_lbl.AutoSize = true;
            this.bezet_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bezet_lbl.Image = global::UI.Properties.Resources.bezet;
            this.bezet_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bezet_lbl.Location = new System.Drawing.Point(12, 423);
            this.bezet_lbl.Name = "bezet_lbl";
            this.bezet_lbl.Size = new System.Drawing.Size(68, 17);
            this.bezet_lbl.TabIndex = 18;
            this.bezet_lbl.Text = "      Bezet";
            this.bezet_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gereserveerd_lbl
            // 
            this.gereserveerd_lbl.AutoSize = true;
            this.gereserveerd_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gereserveerd_lbl.Image = global::UI.Properties.Resources.gereserveerd;
            this.gereserveerd_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gereserveerd_lbl.Location = new System.Drawing.Point(12, 406);
            this.gereserveerd_lbl.Name = "gereserveerd_lbl";
            this.gereserveerd_lbl.Size = new System.Drawing.Size(120, 17);
            this.gereserveerd_lbl.TabIndex = 17;
            this.gereserveerd_lbl.Text = "      Gereserveerd";
            this.gereserveerd_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // beschikbaar_lbl
            // 
            this.beschikbaar_lbl.AutoSize = true;
            this.beschikbaar_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beschikbaar_lbl.Image = global::UI.Properties.Resources.beschikbaar;
            this.beschikbaar_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.beschikbaar_lbl.Location = new System.Drawing.Point(12, 389);
            this.beschikbaar_lbl.Name = "beschikbaar_lbl";
            this.beschikbaar_lbl.Size = new System.Drawing.Size(110, 17);
            this.beschikbaar_lbl.TabIndex = 16;
            this.beschikbaar_lbl.Text = "      Beschikbaar";
            this.beschikbaar_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logout_btn
            // 
            this.logout_btn.Image = global::UI.Properties.Resources.Exit;
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(289, 26);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(67, 28);
            this.logout_btn.TabIndex = 15;
            this.logout_btn.Text = "Logout";
            this.logout_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // OverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(368, 473);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.bezet_lbl);
            this.Controls.Add(this.gereserveerd_lbl);
            this.Controls.Add(this.beschikbaar_lbl);
            this.Controls.Add(this.logout_btn);
            this.Name = "OverzichtForm";
            this.Controls.SetChildIndex(this.logout_btn, 0);
            this.Controls.SetChildIndex(this.beschikbaar_lbl, 0);
            this.Controls.SetChildIndex(this.gereserveerd_lbl, 0);
            this.Controls.SetChildIndex(this.bezet_lbl, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label bezet_lbl;
        private System.Windows.Forms.Label gereserveerd_lbl;
        private System.Windows.Forms.Label beschikbaar_lbl;
        private System.Windows.Forms.Button logout_btn;
    }
}

namespace UI
{
    partial class Bar
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
            this.listView_Bar = new System.Windows.Forms.ListView();
            this.logout_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_Bar
            // 
            this.listView_Bar.Location = new System.Drawing.Point(12, 58);
            this.listView_Bar.Name = "listView_Bar";
            this.listView_Bar.Size = new System.Drawing.Size(760, 436);
            this.listView_Bar.TabIndex = 0;
            this.listView_Bar.UseCompatibleStateImageBehavior = false;
            // 
            // logout_btn
            // 
            this.logout_btn.Image = global::UI.Properties.Resources.Exit;
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(705, 12);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(67, 28);
            this.logout_btn.TabIndex = 14;
            this.logout_btn.Text = "Logout";
            this.logout_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logout_btn.UseVisualStyleBackColor = true;
            // 
            // Bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.listView_Bar);
            this.Name = "Bar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Bar;
        private System.Windows.Forms.Button logout_btn;
    }
}

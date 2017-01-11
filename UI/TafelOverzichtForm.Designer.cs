namespace UI
{
    partial class TafelOverzichtForm
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bewerken_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(279, 348);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::UI.Properties.Resources.Create;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(202, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "Bestellen";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::UI.Properties.Resources.Euro;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(106, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Betalen";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // bewerken_btn
            // 
            this.bewerken_btn.BackColor = System.Drawing.Color.Silver;
            this.bewerken_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bewerken_btn.Image = global::UI.Properties.Resources.Modify;
            this.bewerken_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bewerken_btn.Location = new System.Drawing.Point(13, 367);
            this.bewerken_btn.Name = "bewerken_btn";
            this.bewerken_btn.Size = new System.Drawing.Size(88, 36);
            this.bewerken_btn.TabIndex = 3;
            this.bewerken_btn.Text = "Bewerken";
            this.bewerken_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bewerken_btn.UseVisualStyleBackColor = false;
            // 
            // home_btn
            // 
            this.home_btn.Image = global::UI.Properties.Resources.Home;
            this.home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_btn.Location = new System.Drawing.Point(230, 409);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(62, 23);
            this.home_btn.TabIndex = 0;
            this.home_btn.Text = "Home";
            this.home_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // TafelOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 444);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bewerken_btn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.home_btn);
            this.Name = "TafelOverzichtForm";
            this.Text = "Tafel Overzicht";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button bewerken_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
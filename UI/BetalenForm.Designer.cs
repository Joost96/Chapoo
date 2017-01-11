namespace UI
{
    partial class BetalenForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totaal_lbl = new System.Windows.Forms.Label();
            this.payment_box = new System.Windows.Forms.ComboBox();
            this.betalmethode_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.betalen_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(279, 276);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fooi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Totaal";
            // 
            // totaal_lbl
            // 
            this.totaal_lbl.AutoSize = true;
            this.totaal_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaal_lbl.Location = new System.Drawing.Point(216, 329);
            this.totaal_lbl.Name = "totaal_lbl";
            this.totaal_lbl.Size = new System.Drawing.Size(44, 20);
            this.totaal_lbl.TabIndex = 4;
            this.totaal_lbl.Text = "0,00";
            // 
            // payment_box
            // 
            this.payment_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_box.FormattingEnabled = true;
            this.payment_box.Items.AddRange(new object[] {
            "Cash",
            "Pin",
            "CC"});
            this.payment_box.Location = new System.Drawing.Point(158, 358);
            this.payment_box.Name = "payment_box";
            this.payment_box.Size = new System.Drawing.Size(134, 28);
            this.payment_box.TabIndex = 5;
            this.payment_box.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // betalmethode_lbl
            // 
            this.betalmethode_lbl.AutoSize = true;
            this.betalmethode_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betalmethode_lbl.Location = new System.Drawing.Point(10, 369);
            this.betalmethode_lbl.Name = "betalmethode_lbl";
            this.betalmethode_lbl.Size = new System.Drawing.Size(107, 17);
            this.betalmethode_lbl.TabIndex = 7;
            this.betalmethode_lbl.Text = "Betalmethode";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.Create1;
            this.pictureBox1.Location = new System.Drawing.Point(185, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 19);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // betalen_btn
            // 
            this.betalen_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.betalen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betalen_btn.Image = global::UI.Properties.Resources.Euro;
            this.betalen_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.betalen_btn.Location = new System.Drawing.Point(196, 392);
            this.betalen_btn.Name = "betalen_btn";
            this.betalen_btn.Size = new System.Drawing.Size(95, 40);
            this.betalen_btn.TabIndex = 6;
            this.betalen_btn.Text = "Betalen";
            this.betalen_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.betalen_btn.UseVisualStyleBackColor = false;
            // 
            // BetalenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 444);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.betalmethode_lbl);
            this.Controls.Add(this.betalen_btn);
            this.Controls.Add(this.payment_box);
            this.Controls.Add(this.totaal_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "BetalenForm";
            this.Text = "Betalen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totaal_lbl;
        private System.Windows.Forms.ComboBox payment_box;
        private System.Windows.Forms.Button betalen_btn;
        private System.Windows.Forms.Label betalmethode_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
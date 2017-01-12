namespace UI
{
    partial class LoginForm
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
            this.userName_tb = new System.Windows.Forms.TextBox();
            this.passWord_tb = new System.Windows.Forms.TextBox();
            this.userName_lbl = new System.Windows.Forms.Label();
            this.passWord_lbl = new System.Windows.Forms.Label();
            this.password_icon = new System.Windows.Forms.PictureBox();
            this.people_icon = new System.Windows.Forms.PictureBox();
            this.logoChapoo = new System.Windows.Forms.PictureBox();
            this.login_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.password_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.people_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoChapoo)).BeginInit();
            this.SuspendLayout();
            // 
            // userName_tb
            // 
            this.userName_tb.Location = new System.Drawing.Point(102, 226);
            this.userName_tb.Name = "userName_tb";
            this.userName_tb.Size = new System.Drawing.Size(166, 20);
            this.userName_tb.TabIndex = 0;
            this.userName_tb.TextChanged += new System.EventHandler(this.userName_tb_TextChanged);
            // 
            // passWord_tb
            // 
            this.passWord_tb.Location = new System.Drawing.Point(102, 282);
            this.passWord_tb.Name = "passWord_tb";
            this.passWord_tb.PasswordChar = '*';
            this.passWord_tb.Size = new System.Drawing.Size(166, 20);
            this.passWord_tb.TabIndex = 1;
            this.passWord_tb.TextChanged += new System.EventHandler(this.passWord_tb_TextChanged);
            // 
            // userName_lbl
            // 
            this.userName_lbl.AutoSize = true;
            this.userName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_lbl.Location = new System.Drawing.Point(102, 206);
            this.userName_lbl.Name = "userName_lbl";
            this.userName_lbl.Size = new System.Drawing.Size(113, 17);
            this.userName_lbl.TabIndex = 2;
            this.userName_lbl.Text = "Gebruikersnaam";
            this.userName_lbl.Click += new System.EventHandler(this.userName_lbl_Click);
            // 
            // passWord_lbl
            // 
            this.passWord_lbl.AutoSize = true;
            this.passWord_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWord_lbl.Location = new System.Drawing.Point(102, 262);
            this.passWord_lbl.Name = "passWord_lbl";
            this.passWord_lbl.Size = new System.Drawing.Size(86, 17);
            this.passWord_lbl.TabIndex = 3;
            this.passWord_lbl.Text = "Wachtwoord";
            this.passWord_lbl.Click += new System.EventHandler(this.passWord_lbl_Click);
            // 
            // password_icon
            // 
            this.password_icon.Image = global::UI.Properties.Resources.Lock;
            this.password_icon.Location = new System.Drawing.Point(71, 283);
            this.password_icon.Name = "password_icon";
            this.password_icon.Size = new System.Drawing.Size(25, 19);
            this.password_icon.TabIndex = 7;
            this.password_icon.TabStop = false;
            // 
            // people_icon
            // 
            this.people_icon.Image = global::UI.Properties.Resources.People;
            this.people_icon.Location = new System.Drawing.Point(71, 226);
            this.people_icon.Name = "people_icon";
            this.people_icon.Size = new System.Drawing.Size(25, 19);
            this.people_icon.TabIndex = 6;
            this.people_icon.TabStop = false;
            // 
            // logoChapoo
            // 
            this.logoChapoo.Image = global::UI.Properties.Resources.chapoo1;
            this.logoChapoo.Location = new System.Drawing.Point(12, 44);
            this.logoChapoo.Name = "logoChapoo";
            this.logoChapoo.Size = new System.Drawing.Size(344, 156);
            this.logoChapoo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoChapoo.TabIndex = 5;
            this.logoChapoo.TabStop = false;
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Image = global::UI.Properties.Resources.Next;
            this.login_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login_btn.Location = new System.Drawing.Point(102, 318);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(166, 38);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 473);
            this.Controls.Add(this.password_icon);
            this.Controls.Add(this.people_icon);
            this.Controls.Add(this.logoChapoo);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.passWord_lbl);
            this.Controls.Add(this.userName_lbl);
            this.Controls.Add(this.passWord_tb);
            this.Controls.Add(this.userName_tb);
            this.Name = "LoginForm";
            this.Text = "Chapoo";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.password_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.people_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoChapoo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName_tb;
        private System.Windows.Forms.TextBox passWord_tb;
        private System.Windows.Forms.Label userName_lbl;
        private System.Windows.Forms.Label passWord_lbl;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.PictureBox logoChapoo;
        private System.Windows.Forms.PictureBox people_icon;
        private System.Windows.Forms.PictureBox password_icon;
    }
}


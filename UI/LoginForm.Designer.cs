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
            this.login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userName_tb
            // 
            this.userName_tb.Location = new System.Drawing.Point(72, 173);
            this.userName_tb.Name = "userName_tb";
            this.userName_tb.Size = new System.Drawing.Size(140, 20);
            this.userName_tb.TabIndex = 0;
            // 
            // passWord_tb
            // 
            this.passWord_tb.Location = new System.Drawing.Point(72, 229);
            this.passWord_tb.Name = "passWord_tb";
            this.passWord_tb.Size = new System.Drawing.Size(140, 20);
            this.passWord_tb.TabIndex = 1;
            // 
            // userName_lbl
            // 
            this.userName_lbl.AutoSize = true;
            this.userName_lbl.Location = new System.Drawing.Point(72, 154);
            this.userName_lbl.Name = "userName_lbl";
            this.userName_lbl.Size = new System.Drawing.Size(84, 13);
            this.userName_lbl.TabIndex = 2;
            this.userName_lbl.Text = "Gebruikersnaam";
            // 
            // passWord_lbl
            // 
            this.passWord_lbl.AutoSize = true;
            this.passWord_lbl.Location = new System.Drawing.Point(72, 213);
            this.passWord_lbl.Name = "passWord_lbl";
            this.passWord_lbl.Size = new System.Drawing.Size(68, 13);
            this.passWord_lbl.TabIndex = 3;
            this.passWord_lbl.Text = "Wachtwoord";
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(72, 274);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(140, 23);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 444);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.passWord_lbl);
            this.Controls.Add(this.userName_lbl);
            this.Controls.Add(this.passWord_tb);
            this.Controls.Add(this.userName_tb);
            this.Name = "LoginForm";
            this.Text = "Chapoo";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName_tb;
        private System.Windows.Forms.TextBox passWord_tb;
        private System.Windows.Forms.Label userName_lbl;
        private System.Windows.Forms.Label passWord_lbl;
        private System.Windows.Forms.Button login_btn;
    }
}


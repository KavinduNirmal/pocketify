namespace pocketify
{
    partial class LandingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingForm));
            this.login_signup_btn = new System.Windows.Forms.Button();
            this.login_login_btn = new System.Windows.Forms.Button();
            this.login_pw_label = new System.Windows.Forms.Label();
            this.Login_pw_inp = new System.Windows.Forms.TextBox();
            this.login_username_label = new System.Windows.Forms.Label();
            this.Login_un_inp = new System.Windows.Forms.TextBox();
            this.login_logo_1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.login_logo_1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_signup_btn
            // 
            this.login_signup_btn.BackColor = System.Drawing.Color.Transparent;
            this.login_signup_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.login_signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_signup_btn.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_signup_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.login_signup_btn.Location = new System.Drawing.Point(650, 355);
            this.login_signup_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_signup_btn.Name = "login_signup_btn";
            this.login_signup_btn.Size = new System.Drawing.Size(140, 40);
            this.login_signup_btn.TabIndex = 13;
            this.login_signup_btn.Text = "Sign Up";
            this.login_signup_btn.UseVisualStyleBackColor = false;
            this.login_signup_btn.Click += new System.EventHandler(this.login_signup_btn_Click);
            // 
            // login_login_btn
            // 
            this.login_login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(133)))), ((int)(((byte)(231)))));
            this.login_login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_login_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.login_login_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.login_login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.login_login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.login_login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_login_btn.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_login_btn.ForeColor = System.Drawing.Color.White;
            this.login_login_btn.Location = new System.Drawing.Point(490, 355);
            this.login_login_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_login_btn.Name = "login_login_btn";
            this.login_login_btn.Size = new System.Drawing.Size(140, 40);
            this.login_login_btn.TabIndex = 12;
            this.login_login_btn.Text = "Login";
            this.login_login_btn.UseVisualStyleBackColor = false;
            this.login_login_btn.Click += new System.EventHandler(this.login_login_btn_Click);
            // 
            // login_pw_label
            // 
            this.login_pw_label.AutoSize = true;
            this.login_pw_label.BackColor = System.Drawing.Color.Transparent;
            this.login_pw_label.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_pw_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.login_pw_label.Location = new System.Drawing.Point(391, 302);
            this.login_pw_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login_pw_label.Name = "login_pw_label";
            this.login_pw_label.Size = new System.Drawing.Size(90, 20);
            this.login_pw_label.TabIndex = 11;
            this.login_pw_label.Text = "Password";
            this.login_pw_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Login_pw_inp
            // 
            this.Login_pw_inp.Font = new System.Drawing.Font("Inter", 10F);
            this.Login_pw_inp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Login_pw_inp.Location = new System.Drawing.Point(490, 296);
            this.Login_pw_inp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login_pw_inp.MaxLength = 16;
            this.Login_pw_inp.Name = "Login_pw_inp";
            this.Login_pw_inp.PasswordChar = '•';
            this.Login_pw_inp.Size = new System.Drawing.Size(300, 28);
            this.Login_pw_inp.TabIndex = 10;
            // 
            // login_username_label
            // 
            this.login_username_label.AutoSize = true;
            this.login_username_label.BackColor = System.Drawing.Color.Transparent;
            this.login_username_label.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.login_username_label.Location = new System.Drawing.Point(391, 243);
            this.login_username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login_username_label.Name = "login_username_label";
            this.login_username_label.Size = new System.Drawing.Size(93, 20);
            this.login_username_label.TabIndex = 9;
            this.login_username_label.Text = "Username";
            this.login_username_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Login_un_inp
            // 
            this.Login_un_inp.Font = new System.Drawing.Font("Inter", 10F);
            this.Login_un_inp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Login_un_inp.Location = new System.Drawing.Point(490, 237);
            this.Login_un_inp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login_un_inp.MaxLength = 20;
            this.Login_un_inp.Name = "Login_un_inp";
            this.Login_un_inp.Size = new System.Drawing.Size(300, 28);
            this.Login_un_inp.TabIndex = 8;
            // 
            // login_logo_1
            // 
            this.login_logo_1.Image = global::pocketify.Properties.Resources.pocketify_logo;
            this.login_logo_1.Location = new System.Drawing.Point(585, 169);
            this.login_logo_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_logo_1.Name = "login_logo_1";
            this.login_logo_1.Size = new System.Drawing.Size(111, 24);
            this.login_logo_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.login_logo_1.TabIndex = 7;
            this.login_logo_1.TabStop = false;
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::pocketify.Properties.Resources.loginBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.login_signup_btn);
            this.Controls.Add(this.login_login_btn);
            this.Controls.Add(this.login_pw_label);
            this.Controls.Add(this.Login_pw_inp);
            this.Controls.Add(this.login_username_label);
            this.Controls.Add(this.Login_un_inp);
            this.Controls.Add(this.login_logo_1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Inter", 10F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "LandingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pocketify – Login";
            ((System.ComponentModel.ISupportInitialize)(this.login_logo_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_signup_btn;
        private System.Windows.Forms.Button login_login_btn;
        private System.Windows.Forms.Label login_pw_label;
        private System.Windows.Forms.TextBox Login_pw_inp;
        private System.Windows.Forms.Label login_username_label;
        private System.Windows.Forms.TextBox Login_un_inp;
        private System.Windows.Forms.PictureBox login_logo_1;
    }
}


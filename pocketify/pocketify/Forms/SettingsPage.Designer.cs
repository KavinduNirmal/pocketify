namespace pocketify.Forms
{
    partial class SettingsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Settings_username_input = new System.Windows.Forms.TextBox();
            this.Settings_email_edit_Input = new System.Windows.Forms.TextBox();
            this.Setting_pw_edit_input = new System.Windows.Forms.TextBox();
            this.Settings_save_btn = new System.Windows.Forms.Button();
            this.Settings_un_edit_btn = new System.Windows.Forms.Button();
            this.Settings_email_edit_btn = new System.Windows.Forms.Button();
            this.Settings_change_pw_btn = new System.Windows.Forms.Button();
            this.Settings_pw_conf_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // Settings_username_input
            // 
            this.Settings_username_input.Location = new System.Drawing.Point(468, 76);
            this.Settings_username_input.Name = "Settings_username_input";
            this.Settings_username_input.Size = new System.Drawing.Size(290, 22);
            this.Settings_username_input.TabIndex = 3;
            // 
            // Settings_email_edit_Input
            // 
            this.Settings_email_edit_Input.Location = new System.Drawing.Point(468, 132);
            this.Settings_email_edit_Input.Name = "Settings_email_edit_Input";
            this.Settings_email_edit_Input.Size = new System.Drawing.Size(290, 22);
            this.Settings_email_edit_Input.TabIndex = 4;
            // 
            // Setting_pw_edit_input
            // 
            this.Setting_pw_edit_input.Location = new System.Drawing.Point(468, 181);
            this.Setting_pw_edit_input.Name = "Setting_pw_edit_input";
            this.Setting_pw_edit_input.Size = new System.Drawing.Size(290, 22);
            this.Setting_pw_edit_input.TabIndex = 5;
            // 
            // Settings_save_btn
            // 
            this.Settings_save_btn.Location = new System.Drawing.Point(587, 26);
            this.Settings_save_btn.Name = "Settings_save_btn";
            this.Settings_save_btn.Size = new System.Drawing.Size(171, 33);
            this.Settings_save_btn.TabIndex = 8;
            this.Settings_save_btn.Text = "Save Settings";
            this.Settings_save_btn.UseVisualStyleBackColor = true;
            this.Settings_save_btn.Click += new System.EventHandler(this.Settings_save_btn_Click);
            // 
            // Settings_un_edit_btn
            // 
            this.Settings_un_edit_btn.FlatAppearance.BorderSize = 0;
            this.Settings_un_edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_un_edit_btn.Image = global::pocketify.Properties.Resources.Edit_Icon;
            this.Settings_un_edit_btn.Location = new System.Drawing.Point(764, 76);
            this.Settings_un_edit_btn.Name = "Settings_un_edit_btn";
            this.Settings_un_edit_btn.Size = new System.Drawing.Size(25, 23);
            this.Settings_un_edit_btn.TabIndex = 7;
            this.Settings_un_edit_btn.UseVisualStyleBackColor = true;
            this.Settings_un_edit_btn.Click += new System.EventHandler(this.Settings_un_edit_btn_Click);
            // 
            // Settings_email_edit_btn
            // 
            this.Settings_email_edit_btn.FlatAppearance.BorderSize = 0;
            this.Settings_email_edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_email_edit_btn.Image = global::pocketify.Properties.Resources.Edit_Icon;
            this.Settings_email_edit_btn.Location = new System.Drawing.Point(764, 131);
            this.Settings_email_edit_btn.Name = "Settings_email_edit_btn";
            this.Settings_email_edit_btn.Size = new System.Drawing.Size(25, 23);
            this.Settings_email_edit_btn.TabIndex = 9;
            this.Settings_email_edit_btn.UseVisualStyleBackColor = true;
            this.Settings_email_edit_btn.Click += new System.EventHandler(this.Settings_email_edit_btn_Click);
            // 
            // Settings_change_pw_btn
            // 
            this.Settings_change_pw_btn.FlatAppearance.BorderSize = 0;
            this.Settings_change_pw_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_change_pw_btn.Image = global::pocketify.Properties.Resources.Edit_Icon;
            this.Settings_change_pw_btn.Location = new System.Drawing.Point(764, 180);
            this.Settings_change_pw_btn.Name = "Settings_change_pw_btn";
            this.Settings_change_pw_btn.Size = new System.Drawing.Size(25, 23);
            this.Settings_change_pw_btn.TabIndex = 10;
            this.Settings_change_pw_btn.UseVisualStyleBackColor = true;
            this.Settings_change_pw_btn.Click += new System.EventHandler(this.Settings_change_pw_btn_Click);
            // 
            // Settings_pw_conf_input
            // 
            this.Settings_pw_conf_input.Location = new System.Drawing.Point(468, 231);
            this.Settings_pw_conf_input.Name = "Settings_pw_conf_input";
            this.Settings_pw_conf_input.Size = new System.Drawing.Size(290, 22);
            this.Settings_pw_conf_input.TabIndex = 11;
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 646);
            this.Controls.Add(this.Settings_pw_conf_input);
            this.Controls.Add(this.Settings_change_pw_btn);
            this.Controls.Add(this.Settings_email_edit_btn);
            this.Controls.Add(this.Settings_save_btn);
            this.Controls.Add(this.Settings_un_edit_btn);
            this.Controls.Add(this.Setting_pw_edit_input);
            this.Controls.Add(this.Settings_email_edit_Input);
            this.Controls.Add(this.Settings_username_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsPage";
            this.ShowInTaskbar = false;
            this.Text = "Pocketify – Settings Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Settings_username_input;
        private System.Windows.Forms.TextBox Settings_email_edit_Input;
        private System.Windows.Forms.TextBox Setting_pw_edit_input;
        private System.Windows.Forms.Button Settings_un_edit_btn;
        private System.Windows.Forms.Button Settings_save_btn;
        private System.Windows.Forms.Button Settings_email_edit_btn;
        private System.Windows.Forms.Button Settings_change_pw_btn;
        private System.Windows.Forms.TextBox Settings_pw_conf_input;
    }
}
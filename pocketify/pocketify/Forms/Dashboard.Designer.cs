namespace pocketify.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.NavbarSidebar = new System.Windows.Forms.Panel();
            this.DetailsTopBar = new System.Windows.Forms.Panel();
            this.FormContainer = new System.Windows.Forms.Panel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.NavButtons = new System.Windows.Forms.Panel();
            this.dash_nav_budget_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dash_nav_trans_btn = new System.Windows.Forms.Button();
            this.dash_nav_dash_btn = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.dash_nav_settings_btn = new System.Windows.Forms.Button();
            this.NavbarSidebar.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.NavButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NavbarSidebar
            // 
            this.NavbarSidebar.Controls.Add(this.NavButtons);
            this.NavbarSidebar.Controls.Add(this.LogoPanel);
            this.NavbarSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavbarSidebar.Location = new System.Drawing.Point(0, 0);
            this.NavbarSidebar.Name = "NavbarSidebar";
            this.NavbarSidebar.Size = new System.Drawing.Size(230, 753);
            this.NavbarSidebar.TabIndex = 0;
            // 
            // DetailsTopBar
            // 
            this.DetailsTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.DetailsTopBar.Location = new System.Drawing.Point(230, 0);
            this.DetailsTopBar.Name = "DetailsTopBar";
            this.DetailsTopBar.Size = new System.Drawing.Size(1032, 50);
            this.DetailsTopBar.TabIndex = 1;
            // 
            // FormContainer
            // 
            this.FormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormContainer.Location = new System.Drawing.Point(230, 50);
            this.FormContainer.Name = "FormContainer";
            this.FormContainer.Size = new System.Drawing.Size(1032, 703);
            this.FormContainer.TabIndex = 2;
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.LogoPictureBox);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(230, 50);
            this.LogoPanel.TabIndex = 0;
            // 
            // NavButtons
            // 
            this.NavButtons.Controls.Add(this.dash_nav_settings_btn);
            this.NavButtons.Controls.Add(this.dash_nav_budget_btn);
            this.NavButtons.Controls.Add(this.button1);
            this.NavButtons.Controls.Add(this.dash_nav_trans_btn);
            this.NavButtons.Controls.Add(this.dash_nav_dash_btn);
            this.NavButtons.Location = new System.Drawing.Point(13, 50);
            this.NavButtons.Name = "NavButtons";
            this.NavButtons.Size = new System.Drawing.Size(200, 653);
            this.NavButtons.TabIndex = 1;
            // 
            // dash_nav_budget_btn
            // 
            this.dash_nav_budget_btn.BackColor = System.Drawing.Color.White;
            this.dash_nav_budget_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dash_nav_budget_btn.FlatAppearance.BorderSize = 0;
            this.dash_nav_budget_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dash_nav_budget_btn.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_nav_budget_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.dash_nav_budget_btn.Image = global::pocketify.Properties.Resources.budget_icon;
            this.dash_nav_budget_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dash_nav_budget_btn.Location = new System.Drawing.Point(0, 135);
            this.dash_nav_budget_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.dash_nav_budget_btn.Name = "dash_nav_budget_btn";
            this.dash_nav_budget_btn.Size = new System.Drawing.Size(200, 45);
            this.dash_nav_budget_btn.TabIndex = 3;
            this.dash_nav_budget_btn.Text = "   Budget";
            this.dash_nav_budget_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dash_nav_budget_btn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button1.Image = global::pocketify.Properties.Resources.categories_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "   Categories";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dash_nav_trans_btn
            // 
            this.dash_nav_trans_btn.BackColor = System.Drawing.Color.White;
            this.dash_nav_trans_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dash_nav_trans_btn.FlatAppearance.BorderSize = 0;
            this.dash_nav_trans_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dash_nav_trans_btn.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_nav_trans_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.dash_nav_trans_btn.Image = global::pocketify.Properties.Resources.transaction_icon;
            this.dash_nav_trans_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dash_nav_trans_btn.Location = new System.Drawing.Point(0, 45);
            this.dash_nav_trans_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.dash_nav_trans_btn.Name = "dash_nav_trans_btn";
            this.dash_nav_trans_btn.Size = new System.Drawing.Size(200, 45);
            this.dash_nav_trans_btn.TabIndex = 1;
            this.dash_nav_trans_btn.Text = "   Transactions";
            this.dash_nav_trans_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dash_nav_trans_btn.UseVisualStyleBackColor = false;
            // 
            // dash_nav_dash_btn
            // 
            this.dash_nav_dash_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(231)))));
            this.dash_nav_dash_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dash_nav_dash_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dash_nav_dash_btn.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_nav_dash_btn.ForeColor = System.Drawing.Color.White;
            this.dash_nav_dash_btn.Image = global::pocketify.Properties.Resources.dashboard_icon_white;
            this.dash_nav_dash_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dash_nav_dash_btn.Location = new System.Drawing.Point(0, 0);
            this.dash_nav_dash_btn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dash_nav_dash_btn.Name = "dash_nav_dash_btn";
            this.dash_nav_dash_btn.Size = new System.Drawing.Size(200, 45);
            this.dash_nav_dash_btn.TabIndex = 0;
            this.dash_nav_dash_btn.Text = "   Dashboard";
            this.dash_nav_dash_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dash_nav_dash_btn.UseVisualStyleBackColor = false;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::pocketify.Properties.Resources.pocketify_logo;
            this.LogoPictureBox.Location = new System.Drawing.Point(45, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(117, 24);
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            this.LogoPictureBox.Click += new System.EventHandler(this.LogoPictureBox_Click);
            // 
            // dash_nav_settings_btn
            // 
            this.dash_nav_settings_btn.BackColor = System.Drawing.Color.White;
            this.dash_nav_settings_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dash_nav_settings_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(182)))), ((int)(((byte)(241)))));
            this.dash_nav_settings_btn.FlatAppearance.BorderSize = 2;
            this.dash_nav_settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dash_nav_settings_btn.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_nav_settings_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(231)))));
            this.dash_nav_settings_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dash_nav_settings_btn.Location = new System.Drawing.Point(0, 573);
            this.dash_nav_settings_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.dash_nav_settings_btn.Name = "dash_nav_settings_btn";
            this.dash_nav_settings_btn.Size = new System.Drawing.Size(200, 80);
            this.dash_nav_settings_btn.TabIndex = 4;
            this.dash_nav_settings_btn.Text = "+ Add Transaction";
            this.dash_nav_settings_btn.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.FormContainer);
            this.Controls.Add(this.DetailsTopBar);
            this.Controls.Add(this.NavbarSidebar);
            this.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.NavbarSidebar.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.NavButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavbarSidebar;
        private System.Windows.Forms.Panel DetailsTopBar;
        private System.Windows.Forms.Panel FormContainer;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Panel NavButtons;
        private System.Windows.Forms.Button dash_nav_dash_btn;
        private System.Windows.Forms.Button dash_nav_trans_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button dash_nav_budget_btn;
        private System.Windows.Forms.Button dash_nav_settings_btn;
    }
}
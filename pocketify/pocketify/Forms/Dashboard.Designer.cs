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
            this.NavButtons = new System.Windows.Forms.Panel();
            this.dash_primarybtnbtn = new System.Windows.Forms.Button();
            this.dash_nav_budget_btn = new System.Windows.Forms.Button();
            this.dash_nav_category_btn = new System.Windows.Forms.Button();
            this.dash_nav_trans_btn = new System.Windows.Forms.Button();
            this.dash_nav_dash_btn = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.DetailsTopBar = new System.Windows.Forms.Panel();
            this.Dash_acc_btn = new System.Windows.Forms.Button();
            this.Page_label = new System.Windows.Forms.Label();
            this.FormContainer = new System.Windows.Forms.Panel();
            this.NavbarSidebar.SuspendLayout();
            this.NavButtons.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.DetailsTopBar.SuspendLayout();
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
            // NavButtons
            // 
            this.NavButtons.Controls.Add(this.dash_primarybtnbtn);
            this.NavButtons.Controls.Add(this.dash_nav_budget_btn);
            this.NavButtons.Controls.Add(this.dash_nav_category_btn);
            this.NavButtons.Controls.Add(this.dash_nav_trans_btn);
            this.NavButtons.Controls.Add(this.dash_nav_dash_btn);
            this.NavButtons.Location = new System.Drawing.Point(13, 60);
            this.NavButtons.Name = "NavButtons";
            this.NavButtons.Size = new System.Drawing.Size(200, 643);
            this.NavButtons.TabIndex = 1;
            // 
            // dash_primarybtnbtn
            // 
            this.dash_primarybtnbtn.BackColor = System.Drawing.Color.White;
            this.dash_primarybtnbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dash_primarybtnbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(182)))), ((int)(((byte)(241)))));
            this.dash_primarybtnbtn.FlatAppearance.BorderSize = 2;
            this.dash_primarybtnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dash_primarybtnbtn.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_primarybtnbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(231)))));
            this.dash_primarybtnbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dash_primarybtnbtn.Location = new System.Drawing.Point(0, 563);
            this.dash_primarybtnbtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.dash_primarybtnbtn.Name = "dash_primarybtnbtn";
            this.dash_primarybtnbtn.Size = new System.Drawing.Size(200, 80);
            this.dash_primarybtnbtn.TabIndex = 4;
            this.dash_primarybtnbtn.Text = "+ Add Transaction";
            this.dash_primarybtnbtn.UseVisualStyleBackColor = false;
            this.dash_primarybtnbtn.Click += new System.EventHandler(this.dash_primarybtnbtn_Click);
            // 
            // dash_nav_budget_btn
            // 
            this.dash_nav_budget_btn.BackColor = System.Drawing.Color.White;
            this.dash_nav_budget_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dash_nav_budget_btn.FlatAppearance.BorderSize = 0;
            this.dash_nav_budget_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dash_nav_budget_btn.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_nav_budget_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.dash_nav_budget_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dash_nav_budget_btn.Location = new System.Drawing.Point(0, 135);
            this.dash_nav_budget_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.dash_nav_budget_btn.Name = "dash_nav_budget_btn";
            this.dash_nav_budget_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dash_nav_budget_btn.Size = new System.Drawing.Size(200, 45);
            this.dash_nav_budget_btn.TabIndex = 3;
            this.dash_nav_budget_btn.Text = "Budget";
            this.dash_nav_budget_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dash_nav_budget_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dash_nav_budget_btn.UseVisualStyleBackColor = false;
            // 
            // dash_nav_category_btn
            // 
            this.dash_nav_category_btn.BackColor = System.Drawing.Color.White;
            this.dash_nav_category_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dash_nav_category_btn.FlatAppearance.BorderSize = 0;
            this.dash_nav_category_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dash_nav_category_btn.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_nav_category_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.dash_nav_category_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dash_nav_category_btn.Location = new System.Drawing.Point(0, 90);
            this.dash_nav_category_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.dash_nav_category_btn.Name = "dash_nav_category_btn";
            this.dash_nav_category_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dash_nav_category_btn.Size = new System.Drawing.Size(200, 45);
            this.dash_nav_category_btn.TabIndex = 2;
            this.dash_nav_category_btn.Text = "Categories";
            this.dash_nav_category_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dash_nav_category_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dash_nav_category_btn.UseVisualStyleBackColor = false;
            this.dash_nav_category_btn.Click += new System.EventHandler(this.dash_nav_category_btn_Click);
            // 
            // dash_nav_trans_btn
            // 
            this.dash_nav_trans_btn.BackColor = System.Drawing.Color.White;
            this.dash_nav_trans_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dash_nav_trans_btn.FlatAppearance.BorderSize = 0;
            this.dash_nav_trans_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dash_nav_trans_btn.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_nav_trans_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.dash_nav_trans_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dash_nav_trans_btn.Location = new System.Drawing.Point(0, 45);
            this.dash_nav_trans_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.dash_nav_trans_btn.Name = "dash_nav_trans_btn";
            this.dash_nav_trans_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dash_nav_trans_btn.Size = new System.Drawing.Size(200, 45);
            this.dash_nav_trans_btn.TabIndex = 1;
            this.dash_nav_trans_btn.Text = "Transactions";
            this.dash_nav_trans_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dash_nav_trans_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dash_nav_trans_btn.UseVisualStyleBackColor = false;
            this.dash_nav_trans_btn.Click += new System.EventHandler(this.dash_nav_trans_btn_Click);
            // 
            // dash_nav_dash_btn
            // 
            this.dash_nav_dash_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(231)))));
            this.dash_nav_dash_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dash_nav_dash_btn.FlatAppearance.BorderSize = 0;
            this.dash_nav_dash_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dash_nav_dash_btn.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_nav_dash_btn.ForeColor = System.Drawing.Color.White;
            this.dash_nav_dash_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dash_nav_dash_btn.Location = new System.Drawing.Point(0, 0);
            this.dash_nav_dash_btn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dash_nav_dash_btn.Name = "dash_nav_dash_btn";
            this.dash_nav_dash_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dash_nav_dash_btn.Size = new System.Drawing.Size(200, 45);
            this.dash_nav_dash_btn.TabIndex = 0;
            this.dash_nav_dash_btn.Text = "Dashboard";
            this.dash_nav_dash_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dash_nav_dash_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dash_nav_dash_btn.UseVisualStyleBackColor = false;
            this.dash_nav_dash_btn.Click += new System.EventHandler(this.dash_nav_dash_btn_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.LogoPictureBox);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(230, 60);
            this.LogoPanel.TabIndex = 0;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::pocketify.Properties.Resources.pocketify_logo;
            this.LogoPictureBox.Location = new System.Drawing.Point(45, 17);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(117, 24);
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            this.LogoPictureBox.Click += new System.EventHandler(this.LogoPictureBox_Click);
            // 
            // DetailsTopBar
            // 
            this.DetailsTopBar.Controls.Add(this.Dash_acc_btn);
            this.DetailsTopBar.Controls.Add(this.Page_label);
            this.DetailsTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.DetailsTopBar.Location = new System.Drawing.Point(230, 0);
            this.DetailsTopBar.Name = "DetailsTopBar";
            this.DetailsTopBar.Size = new System.Drawing.Size(1032, 60);
            this.DetailsTopBar.TabIndex = 1;
            // 
            // Dash_acc_btn
            // 
            this.Dash_acc_btn.BackgroundImage = global::pocketify.Properties.Resources.avatar_male;
            this.Dash_acc_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Dash_acc_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Dash_acc_btn.FlatAppearance.BorderSize = 0;
            this.Dash_acc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dash_acc_btn.Location = new System.Drawing.Point(942, 0);
            this.Dash_acc_btn.Name = "Dash_acc_btn";
            this.Dash_acc_btn.Size = new System.Drawing.Size(90, 60);
            this.Dash_acc_btn.TabIndex = 1;
            this.Dash_acc_btn.UseVisualStyleBackColor = true;
            this.Dash_acc_btn.Click += new System.EventHandler(this.Dash_acc_btn_Click);
            // 
            // Page_label
            // 
            this.Page_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Page_label.AutoSize = true;
            this.Page_label.Font = new System.Drawing.Font("Inter", 14F, System.Drawing.FontStyle.Bold);
            this.Page_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Page_label.Location = new System.Drawing.Point(33, 17);
            this.Page_label.Name = "Page_label";
            this.Page_label.Size = new System.Drawing.Size(141, 29);
            this.Page_label.TabIndex = 0;
            this.Page_label.Text = "Dashboard";
            this.Page_label.Click += new System.EventHandler(this.Page_label_Click);
            // 
            // FormContainer
            // 
            this.FormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormContainer.Location = new System.Drawing.Point(230, 60);
            this.FormContainer.Name = "FormContainer";
            this.FormContainer.Size = new System.Drawing.Size(1032, 693);
            this.FormContainer.TabIndex = 2;
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
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.NavbarSidebar.ResumeLayout(false);
            this.NavButtons.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.DetailsTopBar.ResumeLayout(false);
            this.DetailsTopBar.PerformLayout();
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
        private System.Windows.Forms.Button dash_nav_category_btn;
        private System.Windows.Forms.Button dash_nav_budget_btn;
        private System.Windows.Forms.Button dash_primarybtnbtn;
        private System.Windows.Forms.Label Page_label;
        private System.Windows.Forms.Button Dash_acc_btn;
    }
}
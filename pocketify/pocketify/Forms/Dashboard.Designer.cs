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
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.NavButtons = new System.Windows.Forms.Panel();
            this.NavbarSidebar.SuspendLayout();
            this.LogoPanel.SuspendLayout();
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
            // NavButtons
            // 
            this.NavButtons.Location = new System.Drawing.Point(13, 50);
            this.NavButtons.Name = "NavButtons";
            this.NavButtons.Size = new System.Drawing.Size(200, 703);
            this.NavButtons.TabIndex = 1;
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
    }
}
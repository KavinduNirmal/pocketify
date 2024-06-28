namespace pocketify.Forms
{
    partial class Categories
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
            this.CategoriesDataset = new System.Windows.Forms.DataGridView();
            this.Cat_main_lbl = new System.Windows.Forms.Label();
            this.Cat_action_btn = new System.Windows.Forms.Button();
            this.Cat_new_cat_pnl = new System.Windows.Forms.Panel();
            this.Cat_cat_name = new System.Windows.Forms.Label();
            this.Cat_cat_name_inp = new System.Windows.Forms.TextBox();
            this.Cat_cat_budget_inp = new System.Windows.Forms.TextBox();
            this.Cat_cat_budget_lbl = new System.Windows.Forms.Label();
            this.Cat_cat_save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDataset)).BeginInit();
            this.Cat_new_cat_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoriesDataset
            // 
            this.CategoriesDataset.AllowUserToAddRows = false;
            this.CategoriesDataset.AllowUserToDeleteRows = false;
            this.CategoriesDataset.AllowUserToOrderColumns = true;
            this.CategoriesDataset.BackgroundColor = System.Drawing.Color.White;
            this.CategoriesDataset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoriesDataset.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.CategoriesDataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesDataset.GridColor = System.Drawing.Color.Black;
            this.CategoriesDataset.Location = new System.Drawing.Point(57, 102);
            this.CategoriesDataset.Name = "CategoriesDataset";
            this.CategoriesDataset.RowHeadersWidth = 51;
            this.CategoriesDataset.RowTemplate.Height = 24;
            this.CategoriesDataset.Size = new System.Drawing.Size(585, 445);
            this.CategoriesDataset.TabIndex = 0;
            // 
            // Cat_main_lbl
            // 
            this.Cat_main_lbl.AutoSize = true;
            this.Cat_main_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Cat_main_lbl.Font = new System.Drawing.Font("Inter SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cat_main_lbl.Location = new System.Drawing.Point(53, 32);
            this.Cat_main_lbl.Name = "Cat_main_lbl";
            this.Cat_main_lbl.Size = new System.Drawing.Size(99, 20);
            this.Cat_main_lbl.TabIndex = 2;
            this.Cat_main_lbl.Text = "Categories";
            // 
            // Cat_action_btn
            // 
            this.Cat_action_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(231)))));
            this.Cat_action_btn.FlatAppearance.BorderSize = 0;
            this.Cat_action_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cat_action_btn.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cat_action_btn.ForeColor = System.Drawing.Color.White;
            this.Cat_action_btn.Location = new System.Drawing.Point(698, 102);
            this.Cat_action_btn.Name = "Cat_action_btn";
            this.Cat_action_btn.Size = new System.Drawing.Size(230, 42);
            this.Cat_action_btn.TabIndex = 9;
            this.Cat_action_btn.Text = "Add A  New Category";
            this.Cat_action_btn.UseVisualStyleBackColor = false;
            this.Cat_action_btn.Click += new System.EventHandler(this.Cat_action_btn_Click);
            // 
            // Cat_new_cat_pnl
            // 
            this.Cat_new_cat_pnl.BackColor = System.Drawing.Color.Transparent;
            this.Cat_new_cat_pnl.Controls.Add(this.Cat_cat_save_btn);
            this.Cat_new_cat_pnl.Controls.Add(this.Cat_cat_budget_inp);
            this.Cat_new_cat_pnl.Controls.Add(this.Cat_cat_budget_lbl);
            this.Cat_new_cat_pnl.Controls.Add(this.Cat_cat_name_inp);
            this.Cat_new_cat_pnl.Controls.Add(this.Cat_cat_name);
            this.Cat_new_cat_pnl.Location = new System.Drawing.Point(698, 178);
            this.Cat_new_cat_pnl.Name = "Cat_new_cat_pnl";
            this.Cat_new_cat_pnl.Size = new System.Drawing.Size(230, 229);
            this.Cat_new_cat_pnl.TabIndex = 10;
            // 
            // Cat_cat_name
            // 
            this.Cat_cat_name.AutoSize = true;
            this.Cat_cat_name.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cat_cat_name.Location = new System.Drawing.Point(3, 3);
            this.Cat_cat_name.Name = "Cat_cat_name";
            this.Cat_cat_name.Size = new System.Drawing.Size(135, 20);
            this.Cat_cat_name.TabIndex = 1;
            this.Cat_cat_name.Text = "Category Name";
            // 
            // Cat_cat_name_inp
            // 
            this.Cat_cat_name_inp.Font = new System.Drawing.Font("Inter", 10F);
            this.Cat_cat_name_inp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Cat_cat_name_inp.Location = new System.Drawing.Point(0, 27);
            this.Cat_cat_name_inp.Margin = new System.Windows.Forms.Padding(4);
            this.Cat_cat_name_inp.MaxLength = 20;
            this.Cat_cat_name_inp.Name = "Cat_cat_name_inp";
            this.Cat_cat_name_inp.Size = new System.Drawing.Size(230, 28);
            this.Cat_cat_name_inp.TabIndex = 10;
            // 
            // Cat_cat_budget_inp
            // 
            this.Cat_cat_budget_inp.Font = new System.Drawing.Font("Inter", 10F);
            this.Cat_cat_budget_inp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Cat_cat_budget_inp.Location = new System.Drawing.Point(0, 110);
            this.Cat_cat_budget_inp.Margin = new System.Windows.Forms.Padding(4);
            this.Cat_cat_budget_inp.MaxLength = 20;
            this.Cat_cat_budget_inp.Name = "Cat_cat_budget_inp";
            this.Cat_cat_budget_inp.Size = new System.Drawing.Size(230, 28);
            this.Cat_cat_budget_inp.TabIndex = 12;
            // 
            // Cat_cat_budget_lbl
            // 
            this.Cat_cat_budget_lbl.AutoSize = true;
            this.Cat_cat_budget_lbl.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cat_cat_budget_lbl.Location = new System.Drawing.Point(3, 86);
            this.Cat_cat_budget_lbl.Name = "Cat_cat_budget_lbl";
            this.Cat_cat_budget_lbl.Size = new System.Drawing.Size(67, 20);
            this.Cat_cat_budget_lbl.TabIndex = 11;
            this.Cat_cat_budget_lbl.Text = "Budget";
            // 
            // Cat_cat_save_btn
            // 
            this.Cat_cat_save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(231)))));
            this.Cat_cat_save_btn.FlatAppearance.BorderSize = 0;
            this.Cat_cat_save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cat_cat_save_btn.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cat_cat_save_btn.ForeColor = System.Drawing.Color.White;
            this.Cat_cat_save_btn.Location = new System.Drawing.Point(0, 179);
            this.Cat_cat_save_btn.Name = "Cat_cat_save_btn";
            this.Cat_cat_save_btn.Size = new System.Drawing.Size(230, 42);
            this.Cat_cat_save_btn.TabIndex = 15;
            this.Cat_cat_save_btn.Text = "Save Category";
            this.Cat_cat_save_btn.UseVisualStyleBackColor = false;
            this.Cat_cat_save_btn.Click += new System.EventHandler(this.Cat_cat_save_btn_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::pocketify.Properties.Resources.Settings_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 646);
            this.Controls.Add(this.Cat_new_cat_pnl);
            this.Controls.Add(this.Cat_action_btn);
            this.Controls.Add(this.Cat_main_lbl);
            this.Controls.Add(this.CategoriesDataset);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categories";
            this.Text = "Categories";
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDataset)).EndInit();
            this.Cat_new_cat_pnl.ResumeLayout(false);
            this.Cat_new_cat_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CategoriesDataset;
        private System.Windows.Forms.Label Cat_main_lbl;
        private System.Windows.Forms.Button Cat_action_btn;
        private System.Windows.Forms.Panel Cat_new_cat_pnl;
        private System.Windows.Forms.Label Cat_cat_name;
        private System.Windows.Forms.TextBox Cat_cat_budget_inp;
        private System.Windows.Forms.Label Cat_cat_budget_lbl;
        private System.Windows.Forms.TextBox Cat_cat_name_inp;
        private System.Windows.Forms.Button Cat_cat_save_btn;
    }
}
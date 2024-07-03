namespace pocketify.Forms
{
    partial class AddTransactionForm
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
            this.Trans_amount_inp = new System.Windows.Forms.TextBox();
            this.Trans_desc_inp = new System.Windows.Forms.TextBox();
            this.Trans_title_inp = new System.Windows.Forms.TextBox();
            this.Trans_amount_txt = new System.Windows.Forms.Label();
            this.Trans_desc_txt = new System.Windows.Forms.Label();
            this.Trans_title_txt = new System.Windows.Forms.Label();
            this.Trans_type_select = new System.Windows.Forms.Label();
            this.Trans_type_income = new System.Windows.Forms.RadioButton();
            this.Trans_type_expense = new System.Windows.Forms.RadioButton();
            this.Transe_category_select = new System.Windows.Forms.Label();
            this.Trans_cetegories = new System.Windows.Forms.ComboBox();
            this.Trans_save_tranc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Trans_amount_inp
            // 
            this.Trans_amount_inp.Font = new System.Drawing.Font("Inter", 10F);
            this.Trans_amount_inp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Trans_amount_inp.Location = new System.Drawing.Point(215, 263);
            this.Trans_amount_inp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Trans_amount_inp.Name = "Trans_amount_inp";
            this.Trans_amount_inp.Size = new System.Drawing.Size(300, 28);
            this.Trans_amount_inp.TabIndex = 28;
            // 
            // Trans_desc_inp
            // 
            this.Trans_desc_inp.Font = new System.Drawing.Font("Inter", 10F);
            this.Trans_desc_inp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Trans_desc_inp.Location = new System.Drawing.Point(215, 141);
            this.Trans_desc_inp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Trans_desc_inp.MaxLength = 255;
            this.Trans_desc_inp.Multiline = true;
            this.Trans_desc_inp.Name = "Trans_desc_inp";
            this.Trans_desc_inp.Size = new System.Drawing.Size(300, 98);
            this.Trans_desc_inp.TabIndex = 26;
            // 
            // Trans_title_inp
            // 
            this.Trans_title_inp.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trans_title_inp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Trans_title_inp.Location = new System.Drawing.Point(215, 82);
            this.Trans_title_inp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Trans_title_inp.MaxLength = 50;
            this.Trans_title_inp.Name = "Trans_title_inp";
            this.Trans_title_inp.Size = new System.Drawing.Size(300, 28);
            this.Trans_title_inp.TabIndex = 25;
            this.Trans_title_inp.TextChanged += new System.EventHandler(this.Trans_title_inp_TextChanged);
            // 
            // Trans_amount_txt
            // 
            this.Trans_amount_txt.AutoSize = true;
            this.Trans_amount_txt.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trans_amount_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Trans_amount_txt.Location = new System.Drawing.Point(135, 267);
            this.Trans_amount_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Trans_amount_txt.Name = "Trans_amount_txt";
            this.Trans_amount_txt.Size = new System.Drawing.Size(72, 20);
            this.Trans_amount_txt.TabIndex = 24;
            this.Trans_amount_txt.Text = "Amount";
            // 
            // Trans_desc_txt
            // 
            this.Trans_desc_txt.AutoSize = true;
            this.Trans_desc_txt.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trans_desc_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Trans_desc_txt.Location = new System.Drawing.Point(108, 145);
            this.Trans_desc_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Trans_desc_txt.Name = "Trans_desc_txt";
            this.Trans_desc_txt.Size = new System.Drawing.Size(99, 20);
            this.Trans_desc_txt.TabIndex = 22;
            this.Trans_desc_txt.Text = "Description";
            // 
            // Trans_title_txt
            // 
            this.Trans_title_txt.AutoSize = true;
            this.Trans_title_txt.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trans_title_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Trans_title_txt.Location = new System.Drawing.Point(163, 86);
            this.Trans_title_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Trans_title_txt.Name = "Trans_title_txt";
            this.Trans_title_txt.Size = new System.Drawing.Size(44, 20);
            this.Trans_title_txt.TabIndex = 21;
            this.Trans_title_txt.Text = "Title";
            // 
            // Trans_type_select
            // 
            this.Trans_type_select.AutoSize = true;
            this.Trans_type_select.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trans_type_select.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Trans_type_select.Location = new System.Drawing.Point(159, 321);
            this.Trans_type_select.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Trans_type_select.Name = "Trans_type_select";
            this.Trans_type_select.Size = new System.Drawing.Size(48, 20);
            this.Trans_type_select.TabIndex = 29;
            this.Trans_type_select.Text = "Type";
            // 
            // Trans_type_income
            // 
            this.Trans_type_income.AutoSize = true;
            this.Trans_type_income.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trans_type_income.Location = new System.Drawing.Point(214, 321);
            this.Trans_type_income.Name = "Trans_type_income";
            this.Trans_type_income.Size = new System.Drawing.Size(88, 24);
            this.Trans_type_income.TabIndex = 30;
            this.Trans_type_income.TabStop = true;
            this.Trans_type_income.Text = "Income";
            this.Trans_type_income.UseVisualStyleBackColor = true;
            // 
            // Trans_type_expense
            // 
            this.Trans_type_expense.AutoSize = true;
            this.Trans_type_expense.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trans_type_expense.Location = new System.Drawing.Point(326, 321);
            this.Trans_type_expense.Name = "Trans_type_expense";
            this.Trans_type_expense.Size = new System.Drawing.Size(98, 24);
            this.Trans_type_expense.TabIndex = 31;
            this.Trans_type_expense.TabStop = true;
            this.Trans_type_expense.Text = "Expense";
            this.Trans_type_expense.UseVisualStyleBackColor = true;
            // 
            // Transe_category_select
            // 
            this.Transe_category_select.AutoSize = true;
            this.Transe_category_select.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transe_category_select.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Transe_category_select.Location = new System.Drawing.Point(125, 376);
            this.Transe_category_select.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Transe_category_select.Name = "Transe_category_select";
            this.Transe_category_select.Size = new System.Drawing.Size(82, 20);
            this.Transe_category_select.TabIndex = 32;
            this.Transe_category_select.Text = "Category";
            // 
            // Trans_cetegories
            // 
            this.Trans_cetegories.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trans_cetegories.FormattingEnabled = true;
            this.Trans_cetegories.Location = new System.Drawing.Point(214, 372);
            this.Trans_cetegories.Name = "Trans_cetegories";
            this.Trans_cetegories.Size = new System.Drawing.Size(301, 28);
            this.Trans_cetegories.TabIndex = 33;
            // 
            // Trans_save_tranc
            // 
            this.Trans_save_tranc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(133)))), ((int)(((byte)(231)))));
            this.Trans_save_tranc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.Trans_save_tranc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.Trans_save_tranc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.Trans_save_tranc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trans_save_tranc.Font = new System.Drawing.Font("Inter Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trans_save_tranc.ForeColor = System.Drawing.Color.White;
            this.Trans_save_tranc.Location = new System.Drawing.Point(215, 435);
            this.Trans_save_tranc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Trans_save_tranc.Name = "Trans_save_tranc";
            this.Trans_save_tranc.Size = new System.Drawing.Size(301, 40);
            this.Trans_save_tranc.TabIndex = 35;
            this.Trans_save_tranc.Text = "Save Transaction";
            this.Trans_save_tranc.UseVisualStyleBackColor = false;
            this.Trans_save_tranc.Click += new System.EventHandler(this.Trans_save_tranc_Click);
            // 
            // AddTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::pocketify.Properties.Resources.Settings_bg;
            this.ClientSize = new System.Drawing.Size(996, 599);
            this.Controls.Add(this.Trans_save_tranc);
            this.Controls.Add(this.Trans_cetegories);
            this.Controls.Add(this.Transe_category_select);
            this.Controls.Add(this.Trans_type_expense);
            this.Controls.Add(this.Trans_type_income);
            this.Controls.Add(this.Trans_type_select);
            this.Controls.Add(this.Trans_amount_inp);
            this.Controls.Add(this.Trans_desc_inp);
            this.Controls.Add(this.Trans_title_inp);
            this.Controls.Add(this.Trans_amount_txt);
            this.Controls.Add(this.Trans_desc_txt);
            this.Controls.Add(this.Trans_title_txt);
            this.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTransactionForm";
            this.Text = "AddTransactionForm";
            this.Load += new System.EventHandler(this.AddTransactionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Trans_amount_inp;
        private System.Windows.Forms.TextBox Trans_desc_inp;
        private System.Windows.Forms.TextBox Trans_title_inp;
        private System.Windows.Forms.Label Trans_amount_txt;
        private System.Windows.Forms.Label Trans_desc_txt;
        private System.Windows.Forms.Label Trans_title_txt;
        private System.Windows.Forms.Label Trans_type_select;
        private System.Windows.Forms.RadioButton Trans_type_income;
        private System.Windows.Forms.RadioButton Trans_type_expense;
        private System.Windows.Forms.ComboBox Trans_cetegories;
        private System.Windows.Forms.Button Trans_save_tranc;
        private System.Windows.Forms.Label Transe_category_select;
    }
}
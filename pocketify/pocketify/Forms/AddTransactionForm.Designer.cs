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
            this.components = new System.ComponentModel.Container();
            this.signup_pwdc_inp = new System.Windows.Forms.TextBox();
            this.signup_email_input = new System.Windows.Forms.TextBox();
            this.signup_username_inp = new System.Windows.Forms.TextBox();
            this.su_cpwd_txt = new System.Windows.Forms.Label();
            this.su_email_txt = new System.Windows.Forms.Label();
            this.su_username_txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pocketifyDataSet = new pocketify.PocketifyDataSet();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new pocketify.PocketifyDataSetTableAdapters.CategoriesTableAdapter();
            this.signup_signin_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pocketifyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // signup_pwdc_inp
            // 
            this.signup_pwdc_inp.Font = new System.Drawing.Font("Inter", 10F);
            this.signup_pwdc_inp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.signup_pwdc_inp.Location = new System.Drawing.Point(215, 263);
            this.signup_pwdc_inp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signup_pwdc_inp.Name = "signup_pwdc_inp";
            this.signup_pwdc_inp.Size = new System.Drawing.Size(300, 28);
            this.signup_pwdc_inp.TabIndex = 28;
            // 
            // signup_email_input
            // 
            this.signup_email_input.Font = new System.Drawing.Font("Inter", 10F);
            this.signup_email_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.signup_email_input.Location = new System.Drawing.Point(215, 141);
            this.signup_email_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signup_email_input.MaxLength = 255;
            this.signup_email_input.Multiline = true;
            this.signup_email_input.Name = "signup_email_input";
            this.signup_email_input.Size = new System.Drawing.Size(300, 98);
            this.signup_email_input.TabIndex = 26;
            // 
            // signup_username_inp
            // 
            this.signup_username_inp.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_username_inp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.signup_username_inp.Location = new System.Drawing.Point(215, 82);
            this.signup_username_inp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signup_username_inp.MaxLength = 50;
            this.signup_username_inp.Name = "signup_username_inp";
            this.signup_username_inp.Size = new System.Drawing.Size(300, 28);
            this.signup_username_inp.TabIndex = 25;
            // 
            // su_cpwd_txt
            // 
            this.su_cpwd_txt.AutoSize = true;
            this.su_cpwd_txt.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.su_cpwd_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.su_cpwd_txt.Location = new System.Drawing.Point(135, 267);
            this.su_cpwd_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.su_cpwd_txt.Name = "su_cpwd_txt";
            this.su_cpwd_txt.Size = new System.Drawing.Size(72, 20);
            this.su_cpwd_txt.TabIndex = 24;
            this.su_cpwd_txt.Text = "Amount";
            // 
            // su_email_txt
            // 
            this.su_email_txt.AutoSize = true;
            this.su_email_txt.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.su_email_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.su_email_txt.Location = new System.Drawing.Point(108, 145);
            this.su_email_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.su_email_txt.Name = "su_email_txt";
            this.su_email_txt.Size = new System.Drawing.Size(99, 20);
            this.su_email_txt.TabIndex = 22;
            this.su_email_txt.Text = "Description";
            // 
            // su_username_txt
            // 
            this.su_username_txt.AutoSize = true;
            this.su_username_txt.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.su_username_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.su_username_txt.Location = new System.Drawing.Point(163, 86);
            this.su_username_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.su_username_txt.Name = "su_username_txt";
            this.su_username_txt.Size = new System.Drawing.Size(44, 20);
            this.su_username_txt.TabIndex = 21;
            this.su_username_txt.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.label1.Location = new System.Drawing.Point(159, 321);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Type";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(214, 321);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 24);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Income";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(326, 321);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 24);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Expense";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.label2.Location = new System.Drawing.Point(125, 376);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Category";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.categoriesBindingSource;
            this.comboBox1.DisplayMember = "CategoryName";
            this.comboBox1.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(214, 372);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(301, 28);
            this.comboBox1.TabIndex = 33;
            // 
            // pocketifyDataSet
            // 
            this.pocketifyDataSet.DataSetName = "PocketifyDataSet";
            this.pocketifyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.pocketifyDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // signup_signin_btn
            // 
            this.signup_signin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(133)))), ((int)(((byte)(231)))));
            this.signup_signin_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.signup_signin_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.signup_signin_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.signup_signin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_signin_btn.Font = new System.Drawing.Font("Inter Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_signin_btn.ForeColor = System.Drawing.Color.White;
            this.signup_signin_btn.Location = new System.Drawing.Point(214, 428);
            this.signup_signin_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signup_signin_btn.Name = "signup_signin_btn";
            this.signup_signin_btn.Size = new System.Drawing.Size(301, 40);
            this.signup_signin_btn.TabIndex = 34;
            this.signup_signin_btn.Text = "Save Transaction";
            this.signup_signin_btn.UseVisualStyleBackColor = false;
            // 
            // AddTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::pocketify.Properties.Resources.Settings_bg;
            this.ClientSize = new System.Drawing.Size(996, 599);
            this.Controls.Add(this.signup_signin_btn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signup_pwdc_inp);
            this.Controls.Add(this.signup_email_input);
            this.Controls.Add(this.signup_username_inp);
            this.Controls.Add(this.su_cpwd_txt);
            this.Controls.Add(this.su_email_txt);
            this.Controls.Add(this.su_username_txt);
            this.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTransactionForm";
            this.Text = "AddTransactionForm";
            this.Load += new System.EventHandler(this.AddTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pocketifyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox signup_pwdc_inp;
        private System.Windows.Forms.TextBox signup_email_input;
        private System.Windows.Forms.TextBox signup_username_inp;
        private System.Windows.Forms.Label su_cpwd_txt;
        private System.Windows.Forms.Label su_email_txt;
        private System.Windows.Forms.Label su_username_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private PocketifyDataSet pocketifyDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private PocketifyDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.Button signup_signin_btn;
    }
}
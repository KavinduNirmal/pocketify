namespace pocketify.Forms
{
    partial class Transactions
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
            this.Cat_action_btn = new System.Windows.Forms.Button();
            this.TransactionDataset = new System.Windows.Forms.DataGridView();
            this.Transaction_end_date = new System.Windows.Forms.DateTimePicker();
            this.Transaction_first_date = new System.Windows.Forms.DateTimePicker();
            this.Transaction_lbl_1 = new System.Windows.Forms.Label();
            this.Transaction_lbl_2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // Cat_action_btn
            // 
            this.Cat_action_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(231)))));
            this.Cat_action_btn.FlatAppearance.BorderSize = 0;
            this.Cat_action_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cat_action_btn.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cat_action_btn.ForeColor = System.Drawing.Color.White;
            this.Cat_action_btn.Location = new System.Drawing.Point(743, 42);
            this.Cat_action_btn.Name = "Cat_action_btn";
            this.Cat_action_btn.Size = new System.Drawing.Size(202, 42);
            this.Cat_action_btn.TabIndex = 11;
            this.Cat_action_btn.Text = "Sort Data";
            this.Cat_action_btn.UseVisualStyleBackColor = false;
            this.Cat_action_btn.Click += new System.EventHandler(this.Cat_action_btn_Click);
            // 
            // TransactionDataset
            // 
            this.TransactionDataset.AllowUserToAddRows = false;
            this.TransactionDataset.AllowUserToDeleteRows = false;
            this.TransactionDataset.AllowUserToOrderColumns = true;
            this.TransactionDataset.BackgroundColor = System.Drawing.Color.White;
            this.TransactionDataset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransactionDataset.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.TransactionDataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionDataset.GridColor = System.Drawing.Color.Black;
            this.TransactionDataset.Location = new System.Drawing.Point(68, 107);
            this.TransactionDataset.Name = "TransactionDataset";
            this.TransactionDataset.RowHeadersWidth = 51;
            this.TransactionDataset.RowTemplate.Height = 24;
            this.TransactionDataset.Size = new System.Drawing.Size(877, 470);
            this.TransactionDataset.TabIndex = 10;
            // 
            // Transaction_end_date
            // 
            this.Transaction_end_date.CalendarFont = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction_end_date.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Transaction_end_date.Location = new System.Drawing.Point(554, 42);
            this.Transaction_end_date.Name = "Transaction_end_date";
            this.Transaction_end_date.Size = new System.Drawing.Size(167, 28);
            this.Transaction_end_date.TabIndex = 12;
            this.Transaction_end_date.ValueChanged += new System.EventHandler(this.Transaction_end_date_ValueChanged);
            // 
            // Transaction_first_date
            // 
            this.Transaction_first_date.CalendarFont = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction_first_date.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction_first_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Transaction_first_date.Location = new System.Drawing.Point(344, 42);
            this.Transaction_first_date.Name = "Transaction_first_date";
            this.Transaction_first_date.Size = new System.Drawing.Size(167, 28);
            this.Transaction_first_date.TabIndex = 13;
            this.Transaction_first_date.Value = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.Transaction_first_date.ValueChanged += new System.EventHandler(this.Transaction_first_date_ValueChanged);
            // 
            // Transaction_lbl_1
            // 
            this.Transaction_lbl_1.AutoSize = true;
            this.Transaction_lbl_1.BackColor = System.Drawing.Color.Transparent;
            this.Transaction_lbl_1.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction_lbl_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Transaction_lbl_1.Location = new System.Drawing.Point(121, 46);
            this.Transaction_lbl_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Transaction_lbl_1.Name = "Transaction_lbl_1";
            this.Transaction_lbl_1.Size = new System.Drawing.Size(217, 20);
            this.Transaction_lbl_1.TabIndex = 14;
            this.Transaction_lbl_1.Text = "Select Transactions From";
            this.Transaction_lbl_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Transaction_lbl_2
            // 
            this.Transaction_lbl_2.AutoSize = true;
            this.Transaction_lbl_2.BackColor = System.Drawing.Color.Transparent;
            this.Transaction_lbl_2.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction_lbl_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Transaction_lbl_2.Location = new System.Drawing.Point(519, 46);
            this.Transaction_lbl_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Transaction_lbl_2.Name = "Transaction_lbl_2";
            this.Transaction_lbl_2.Size = new System.Drawing.Size(29, 20);
            this.Transaction_lbl_2.TabIndex = 15;
            this.Transaction_lbl_2.Text = "To";
            this.Transaction_lbl_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::pocketify.Properties.Resources.Settings_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 646);
            this.Controls.Add(this.Transaction_lbl_2);
            this.Controls.Add(this.Transaction_lbl_1);
            this.Controls.Add(this.Transaction_first_date);
            this.Controls.Add(this.Transaction_end_date);
            this.Controls.Add(this.Cat_action_btn);
            this.Controls.Add(this.TransactionDataset);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cat_action_btn;
        private System.Windows.Forms.DataGridView TransactionDataset;
        private System.Windows.Forms.DateTimePicker Transaction_end_date;
        private System.Windows.Forms.DateTimePicker Transaction_first_date;
        private System.Windows.Forms.Label Transaction_lbl_1;
        private System.Windows.Forms.Label Transaction_lbl_2;
    }
}
namespace ASTAX_5
{
    partial class Doc_c_form
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
            this.period_label = new System.Windows.Forms.Label();
            this.exit_but = new System.Windows.Forms.Button();
            this.print_but = new System.Windows.Forms.Button();
            this.date_textbox = new System.Windows.Forms.TextBox();
            this.save_but = new System.Windows.Forms.Button();
            this.doc_table = new System.Windows.Forms.DataGridView();
            this.org_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min_price_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max_price_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sr_price_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.doc_table)).BeginInit();
            this.SuspendLayout();
            // 
            // period_label
            // 
            this.period_label.AutoSize = true;
            this.period_label.Location = new System.Drawing.Point(31, 21);
            this.period_label.Name = "period_label";
            this.period_label.Size = new System.Drawing.Size(88, 13);
            this.period_label.TabIndex = 64;
            this.period_label.Text = "Введите период";
            // 
            // exit_but
            // 
            this.exit_but.Location = new System.Drawing.Point(347, 250);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(125, 40);
            this.exit_but.TabIndex = 62;
            this.exit_but.Text = "Выход";
            this.exit_but.UseVisualStyleBackColor = true;
            // 
            // print_but
            // 
            this.print_but.Location = new System.Drawing.Point(188, 250);
            this.print_but.Name = "print_but";
            this.print_but.Size = new System.Drawing.Size(125, 40);
            this.print_but.TabIndex = 61;
            this.print_but.Text = "Печать";
            this.print_but.UseVisualStyleBackColor = true;
            // 
            // date_textbox
            // 
            this.date_textbox.Location = new System.Drawing.Point(125, 18);
            this.date_textbox.Name = "date_textbox";
            this.date_textbox.Size = new System.Drawing.Size(138, 20);
            this.date_textbox.TabIndex = 60;
            // 
            // save_but
            // 
            this.save_but.Location = new System.Drawing.Point(29, 250);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(125, 40);
            this.save_but.TabIndex = 55;
            this.save_but.Text = "Сохранить документ";
            this.save_but.UseVisualStyleBackColor = true;
            // 
            // doc_table
            // 
            this.doc_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doc_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.org_column,
            this.min_price_column,
            this.max_price_column,
            this.sr_price_column});
            this.doc_table.Location = new System.Drawing.Point(29, 54);
            this.doc_table.Name = "doc_table";
            this.doc_table.Size = new System.Drawing.Size(443, 168);
            this.doc_table.TabIndex = 52;
            // 
            // org_column
            // 
            this.org_column.HeaderText = "Организации";
            this.org_column.Name = "org_column";
            // 
            // min_price_column
            // 
            this.min_price_column.HeaderText = "Минимальная цена";
            this.min_price_column.Name = "min_price_column";
            // 
            // max_price_column
            // 
            this.max_price_column.HeaderText = "Максимальная цена";
            this.max_price_column.Name = "max_price_column";
            // 
            // sr_price_column
            // 
            this.sr_price_column.HeaderText = "Средняя цена";
            this.sr_price_column.Name = "sr_price_column";
            // 
            // Doc_c_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 315);
            this.Controls.Add(this.period_label);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.print_but);
            this.Controls.Add(this.date_textbox);
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.doc_table);
            this.Name = "Doc_c_form";
            this.Text = "Просмотр";
            ((System.ComponentModel.ISupportInitialize)(this.doc_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label period_label;
        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.Button print_but;
        private System.Windows.Forms.TextBox date_textbox;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.DataGridView doc_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn org_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn min_price_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn max_price_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn sr_price_column;
    }
}
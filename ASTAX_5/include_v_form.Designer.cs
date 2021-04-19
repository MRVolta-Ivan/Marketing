namespace ASTAX_5
{
    partial class Include_v_form
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
            this.num_doc_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.tovar_shifr_label = new System.Windows.Forms.Label();
            this.exit_but = new System.Windows.Forms.Button();
            this.num_doc_textbox = new System.Windows.Forms.TextBox();
            this.plus_exit_but = new System.Windows.Forms.Button();
            this.org_combox = new System.Windows.Forms.ComboBox();
            this.incude_table = new System.Windows.Forms.DataGridView();
            this.plus_but = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tovar_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovar_shifr_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ed_izmer_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.incude_table)).BeginInit();
            this.SuspendLayout();
            // 
            // num_doc_label
            // 
            this.num_doc_label.AutoSize = true;
            this.num_doc_label.Location = new System.Drawing.Point(27, 19);
            this.num_doc_label.Name = "num_doc_label";
            this.num_doc_label.Size = new System.Drawing.Size(94, 13);
            this.num_doc_label.TabIndex = 63;
            this.num_doc_label.Text = "Номер договора:";
            this.num_doc_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(27, 55);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(36, 13);
            this.date_label.TabIndex = 62;
            this.date_label.Text = "Дата:";
            // 
            // tovar_shifr_label
            // 
            this.tovar_shifr_label.AutoSize = true;
            this.tovar_shifr_label.Location = new System.Drawing.Point(27, 89);
            this.tovar_shifr_label.Name = "tovar_shifr_label";
            this.tovar_shifr_label.Size = new System.Drawing.Size(138, 13);
            this.tovar_shifr_label.TabIndex = 61;
            this.tovar_shifr_label.Text = "Организация покупатель:";
            // 
            // exit_but
            // 
            this.exit_but.Location = new System.Drawing.Point(843, 290);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(122, 48);
            this.exit_but.TabIndex = 58;
            this.exit_but.Text = "Выйти";
            this.exit_but.UseVisualStyleBackColor = true;
            // 
            // num_doc_textbox
            // 
            this.num_doc_textbox.Location = new System.Drawing.Point(171, 16);
            this.num_doc_textbox.Name = "num_doc_textbox";
            this.num_doc_textbox.Size = new System.Drawing.Size(191, 20);
            this.num_doc_textbox.TabIndex = 57;
            // 
            // plus_exit_but
            // 
            this.plus_exit_but.Location = new System.Drawing.Point(843, 213);
            this.plus_exit_but.Name = "plus_exit_but";
            this.plus_exit_but.Size = new System.Drawing.Size(122, 49);
            this.plus_exit_but.TabIndex = 52;
            this.plus_exit_but.Text = "Добавить и выйти";
            this.plus_exit_but.UseVisualStyleBackColor = true;
            // 
            // org_combox
            // 
            this.org_combox.FormattingEnabled = true;
            this.org_combox.Location = new System.Drawing.Point(171, 86);
            this.org_combox.Name = "org_combox";
            this.org_combox.Size = new System.Drawing.Size(191, 21);
            this.org_combox.TabIndex = 50;
            // 
            // incude_table
            // 
            this.incude_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.incude_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incude_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tovar_column,
            this.tovar_shifr_column,
            this.count_column,
            this.price_column,
            this.ed_izmer_column});
            this.incude_table.Location = new System.Drawing.Point(26, 120);
            this.incude_table.Name = "incude_table";
            this.incude_table.Size = new System.Drawing.Size(797, 390);
            this.incude_table.TabIndex = 49;
            // 
            // plus_but
            // 
            this.plus_but.Location = new System.Drawing.Point(843, 139);
            this.plus_but.Name = "plus_but";
            this.plus_but.Size = new System.Drawing.Size(122, 48);
            this.plus_but.TabIndex = 64;
            this.plus_but.Text = "Добавить";
            this.plus_but.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(171, 51);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker.TabIndex = 65;
            this.dateTimePicker.Value = new System.DateTime(2021, 4, 19, 12, 50, 8, 0);
            // 
            // tovar_column
            // 
            this.tovar_column.HeaderText = "Товар";
            this.tovar_column.Name = "tovar_column";
            // 
            // tovar_shifr_column
            // 
            this.tovar_shifr_column.HeaderText = "Шифр товара";
            this.tovar_shifr_column.Name = "tovar_shifr_column";
            // 
            // count_column
            // 
            this.count_column.HeaderText = "Количество";
            this.count_column.Name = "count_column";
            // 
            // price_column
            // 
            this.price_column.HeaderText = "Цена включая НДС";
            this.price_column.Name = "price_column";
            // 
            // ed_izmer_column
            // 
            this.ed_izmer_column.HeaderText = "Ед-цы измерения";
            this.ed_izmer_column.Name = "ed_izmer_column";
            // 
            // Include_v_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 531);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.plus_but);
            this.Controls.Add(this.num_doc_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.tovar_shifr_label);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.num_doc_textbox);
            this.Controls.Add(this.plus_exit_but);
            this.Controls.Add(this.org_combox);
            this.Controls.Add(this.incude_table);
            this.Name = "Include_v_form";
            this.Text = "Ввод данных";
            ((System.ComponentModel.ISupportInitialize)(this.incude_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num_doc_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label tovar_shifr_label;
        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.TextBox num_doc_textbox;
        private System.Windows.Forms.Button plus_exit_but;
        private System.Windows.Forms.ComboBox org_combox;
        private System.Windows.Forms.DataGridView incude_table;
        private System.Windows.Forms.Button plus_but;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovar_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovar_shifr_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ed_izmer_column;
    }
}
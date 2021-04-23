namespace ASTAX_5
{
    partial class Include_c_form
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
            this.incude_table = new System.Windows.Forms.DataGridView();
            this.tovar_column = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tovar_shifr_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ed_izmer_column = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.exit_but = new System.Windows.Forms.Button();
            this.plus_exit_but = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.org_combox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.incude_table)).BeginInit();
            this.SuspendLayout();
            // 
            // incude_table
            // 
            this.incude_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.incude_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incude_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tovar_column,
            this.tovar_shifr_column,
            this.price_column,
            this.ed_izmer_column});
            this.incude_table.Location = new System.Drawing.Point(29, 107);
            this.incude_table.Name = "incude_table";
            this.incude_table.Size = new System.Drawing.Size(781, 398);
            this.incude_table.TabIndex = 30;
            this.incude_table.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.incude_table_CellValueChanged);
            // 
            // tovar_column
            // 
            this.tovar_column.HeaderText = "Товар";
            this.tovar_column.Name = "tovar_column";
            this.tovar_column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tovar_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tovar_shifr_column
            // 
            this.tovar_shifr_column.HeaderText = "Шифр товара";
            this.tovar_shifr_column.Name = "tovar_shifr_column";
            // 
            // price_column
            // 
            this.price_column.HeaderText = "Цена";
            this.price_column.Name = "price_column";
            // 
            // ed_izmer_column
            // 
            this.ed_izmer_column.HeaderText = "Ед-цы измерения";
            this.ed_izmer_column.Name = "ed_izmer_column";
            this.ed_izmer_column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ed_izmer_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(837, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 48);
            this.button1.TabIndex = 69;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit_but
            // 
            this.exit_but.Location = new System.Drawing.Point(837, 277);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(122, 48);
            this.exit_but.TabIndex = 68;
            this.exit_but.Text = "Выйти";
            this.exit_but.UseVisualStyleBackColor = true;
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click);
            // 
            // plus_exit_but
            // 
            this.plus_exit_but.Location = new System.Drawing.Point(837, 202);
            this.plus_exit_but.Name = "plus_exit_but";
            this.plus_exit_but.Size = new System.Drawing.Size(122, 49);
            this.plus_exit_but.TabIndex = 67;
            this.plus_exit_but.Text = "Добавить и выйти";
            this.plus_exit_but.UseVisualStyleBackColor = true;
            this.plus_exit_but.Click += new System.EventHandler(this.plus_exit_but_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(170, 17);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker.TabIndex = 73;
            this.dateTimePicker.Value = new System.DateTime(2021, 4, 19, 12, 50, 8, 0);
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(26, 21);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(36, 13);
            this.date_label.TabIndex = 72;
            this.date_label.Text = "Дата:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Организация конкурент:";
            // 
            // org_combox
            // 
            this.org_combox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.org_combox.FormattingEnabled = true;
            this.org_combox.Location = new System.Drawing.Point(170, 52);
            this.org_combox.Name = "org_combox";
            this.org_combox.Size = new System.Drawing.Size(191, 21);
            this.org_combox.TabIndex = 70;
            // 
            // Include_c_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 531);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.org_combox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.plus_exit_but);
            this.Controls.Add(this.incude_table);
            this.Name = "Include_c_form";
            this.Text = "Ввод данных";
            this.Load += new System.EventHandler(this.Include_c_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incude_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView incude_table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.Button plus_exit_but;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox org_combox;
        private System.Windows.Forms.DataGridViewComboBoxColumn tovar_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovar_shifr_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_column;
        private System.Windows.Forms.DataGridViewComboBoxColumn ed_izmer_column;
    }
}
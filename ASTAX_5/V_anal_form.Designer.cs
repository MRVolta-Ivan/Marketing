namespace ASTAX_5
{
    partial class V_anal_form
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
            this.v_anal_table = new System.Windows.Forms.DataGridView();
            this.tovar_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovar_shifr_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.org_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fasovka_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ed_izm_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.org_label = new System.Windows.Forms.Label();
            this.tovar_label = new System.Windows.Forms.Label();
            this.fasovka_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.tovar_shifr_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.exit_but = new System.Windows.Forms.Button();
            this.back_but = new System.Windows.Forms.Button();
            this.v_anal_but = new System.Windows.Forms.Button();
            this.data_textbox = new System.Windows.Forms.TextBox();
            this.tovar_shifr_textbox = new System.Windows.Forms.TextBox();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.clear_but = new System.Windows.Forms.Button();
            this.minus_but = new System.Windows.Forms.Button();
            this.plus_but = new System.Windows.Forms.Button();
            this.filtr_but = new System.Windows.Forms.Button();
            this.fasovka_combox = new System.Windows.Forms.ComboBox();
            this.tovar_combox = new System.Windows.Forms.ComboBox();
            this.org_combox = new System.Windows.Forms.ComboBox();
            this.new_org_label = new System.Windows.Forms.Label();
            this.new_date_label = new System.Windows.Forms.Label();
            this.new_pricelist_but = new System.Windows.Forms.Button();
            this.new_date_combox = new System.Windows.Forms.ComboBox();
            this.new_org_combox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.v_anal_table)).BeginInit();
            this.SuspendLayout();
            // 
            // v_anal_table
            // 
            this.v_anal_table.AllowUserToOrderColumns = true;
            this.v_anal_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.v_anal_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tovar_column,
            this.date_column,
            this.tovar_shifr_col,
            this.org_column,
            this.price_column,
            this.fasovka_column,
            this.ed_izm_column,
            this.count_column});
            this.v_anal_table.Location = new System.Drawing.Point(12, 34);
            this.v_anal_table.Name = "v_anal_table";
            this.v_anal_table.Size = new System.Drawing.Size(960, 362);
            this.v_anal_table.TabIndex = 0;
            // 
            // tovar_column
            // 
            this.tovar_column.HeaderText = "Товар";
            this.tovar_column.Name = "tovar_column";
            // 
            // date_column
            // 
            this.date_column.HeaderText = "Дата";
            this.date_column.Name = "date_column";
            // 
            // tovar_shifr_col
            // 
            this.tovar_shifr_col.HeaderText = "Шифр товара";
            this.tovar_shifr_col.Name = "tovar_shifr_col";
            // 
            // org_column
            // 
            this.org_column.HeaderText = "Организация";
            this.org_column.Name = "org_column";
            // 
            // price_column
            // 
            this.price_column.HeaderText = "Цена";
            this.price_column.Name = "price_column";
            // 
            // fasovka_column
            // 
            this.fasovka_column.HeaderText = "Фасовка";
            this.fasovka_column.Name = "fasovka_column";
            // 
            // ed_izm_column
            // 
            this.ed_izm_column.HeaderText = "Единицы измерения";
            this.ed_izm_column.Name = "ed_izm_column";
            // 
            // count_column
            // 
            this.count_column.HeaderText = "Количество";
            this.count_column.Name = "count_column";
            // 
            // org_label
            // 
            this.org_label.AutoSize = true;
            this.org_label.Location = new System.Drawing.Point(16, 405);
            this.org_label.Name = "org_label";
            this.org_label.Size = new System.Drawing.Size(77, 13);
            this.org_label.TabIndex = 43;
            this.org_label.Text = "Организация:";
            // 
            // tovar_label
            // 
            this.tovar_label.AutoSize = true;
            this.tovar_label.Location = new System.Drawing.Point(16, 445);
            this.tovar_label.Name = "tovar_label";
            this.tovar_label.Size = new System.Drawing.Size(41, 13);
            this.tovar_label.TabIndex = 42;
            this.tovar_label.Text = "Товар:";
            // 
            // fasovka_label
            // 
            this.fasovka_label.AutoSize = true;
            this.fasovka_label.Location = new System.Drawing.Point(16, 485);
            this.fasovka_label.Name = "fasovka_label";
            this.fasovka_label.Size = new System.Drawing.Size(57, 13);
            this.fasovka_label.TabIndex = 41;
            this.fasovka_label.Text = "Фасовка:";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(274, 405);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(36, 13);
            this.date_label.TabIndex = 40;
            this.date_label.Text = "Дата:";
            // 
            // tovar_shifr_label
            // 
            this.tovar_shifr_label.AutoSize = true;
            this.tovar_shifr_label.Location = new System.Drawing.Point(274, 445);
            this.tovar_shifr_label.Name = "tovar_shifr_label";
            this.tovar_shifr_label.Size = new System.Drawing.Size(77, 13);
            this.tovar_shifr_label.TabIndex = 39;
            this.tovar_shifr_label.Text = "Шифр товара:";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(274, 485);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(128, 13);
            this.price_label.TabIndex = 38;
            this.price_label.Text = "Цена за ед. измерения:";
            // 
            // exit_but
            // 
            this.exit_but.Location = new System.Drawing.Point(904, 522);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(68, 22);
            this.exit_but.TabIndex = 37;
            this.exit_but.Text = "Выход";
            this.exit_but.UseVisualStyleBackColor = true;
            // 
            // back_but
            // 
            this.back_but.Location = new System.Drawing.Point(803, 522);
            this.back_but.Name = "back_but";
            this.back_but.Size = new System.Drawing.Size(70, 22);
            this.back_but.TabIndex = 36;
            this.back_but.Text = "Вернуться";
            this.back_but.UseVisualStyleBackColor = true;
            // 
            // v_anal_but
            // 
            this.v_anal_but.Location = new System.Drawing.Point(803, 472);
            this.v_anal_but.Name = "v_anal_but";
            this.v_anal_but.Size = new System.Drawing.Size(169, 38);
            this.v_anal_but.TabIndex = 35;
            this.v_anal_but.Text = "Анализ объема продаж по территориальным сегментам";
            this.v_anal_but.UseVisualStyleBackColor = true;
            // 
            // data_textbox
            // 
            this.data_textbox.Location = new System.Drawing.Point(408, 403);
            this.data_textbox.Name = "data_textbox";
            this.data_textbox.Size = new System.Drawing.Size(138, 20);
            this.data_textbox.TabIndex = 34;
            // 
            // tovar_shifr_textbox
            // 
            this.tovar_shifr_textbox.Location = new System.Drawing.Point(408, 445);
            this.tovar_shifr_textbox.Name = "tovar_shifr_textbox";
            this.tovar_shifr_textbox.Size = new System.Drawing.Size(138, 20);
            this.tovar_shifr_textbox.TabIndex = 33;
            // 
            // price_textbox
            // 
            this.price_textbox.Location = new System.Drawing.Point(408, 483);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(138, 20);
            this.price_textbox.TabIndex = 32;
            // 
            // clear_but
            // 
            this.clear_but.Location = new System.Drawing.Point(207, 522);
            this.clear_but.Name = "clear_but";
            this.clear_but.Size = new System.Drawing.Size(120, 22);
            this.clear_but.TabIndex = 31;
            this.clear_but.Text = "Сброс";
            this.clear_but.UseVisualStyleBackColor = true;
            // 
            // minus_but
            // 
            this.minus_but.Location = new System.Drawing.Point(177, 522);
            this.minus_but.Name = "minus_but";
            this.minus_but.Size = new System.Drawing.Size(24, 22);
            this.minus_but.TabIndex = 30;
            this.minus_but.Text = "-";
            this.minus_but.UseVisualStyleBackColor = true;
            // 
            // plus_but
            // 
            this.plus_but.Location = new System.Drawing.Point(147, 522);
            this.plus_but.Name = "plus_but";
            this.plus_but.Size = new System.Drawing.Size(24, 22);
            this.plus_but.TabIndex = 29;
            this.plus_but.Text = "+";
            this.plus_but.UseVisualStyleBackColor = true;
            // 
            // filtr_but
            // 
            this.filtr_but.Location = new System.Drawing.Point(19, 522);
            this.filtr_but.Name = "filtr_but";
            this.filtr_but.Size = new System.Drawing.Size(122, 22);
            this.filtr_but.TabIndex = 28;
            this.filtr_but.Text = "Фильтр";
            this.filtr_but.UseVisualStyleBackColor = true;
            // 
            // fasovka_combox
            // 
            this.fasovka_combox.FormattingEnabled = true;
            this.fasovka_combox.Location = new System.Drawing.Point(99, 483);
            this.fasovka_combox.Name = "fasovka_combox";
            this.fasovka_combox.Size = new System.Drawing.Size(139, 21);
            this.fasovka_combox.TabIndex = 27;
            // 
            // tovar_combox
            // 
            this.tovar_combox.FormattingEnabled = true;
            this.tovar_combox.Location = new System.Drawing.Point(99, 442);
            this.tovar_combox.Name = "tovar_combox";
            this.tovar_combox.Size = new System.Drawing.Size(139, 21);
            this.tovar_combox.TabIndex = 26;
            // 
            // org_combox
            // 
            this.org_combox.FormattingEnabled = true;
            this.org_combox.Location = new System.Drawing.Point(99, 402);
            this.org_combox.Name = "org_combox";
            this.org_combox.Size = new System.Drawing.Size(139, 21);
            this.org_combox.TabIndex = 25;
            // 
            // new_org_label
            // 
            this.new_org_label.AutoSize = true;
            this.new_org_label.Location = new System.Drawing.Point(9, 9);
            this.new_org_label.Name = "new_org_label";
            this.new_org_label.Size = new System.Drawing.Size(77, 13);
            this.new_org_label.TabIndex = 48;
            this.new_org_label.Text = "Организация:";
            // 
            // new_date_label
            // 
            this.new_date_label.AutoSize = true;
            this.new_date_label.Location = new System.Drawing.Point(257, 9);
            this.new_date_label.Name = "new_date_label";
            this.new_date_label.Size = new System.Drawing.Size(36, 13);
            this.new_date_label.TabIndex = 47;
            this.new_date_label.Text = "Дата:";
            // 
            // new_pricelist_but
            // 
            this.new_pricelist_but.Location = new System.Drawing.Point(442, 5);
            this.new_pricelist_but.Name = "new_pricelist_but";
            this.new_pricelist_but.Size = new System.Drawing.Size(81, 23);
            this.new_pricelist_but.TabIndex = 46;
            this.new_pricelist_but.Text = "Добавление";
            this.new_pricelist_but.UseVisualStyleBackColor = true;
            // 
            // new_date_combox
            // 
            this.new_date_combox.FormattingEnabled = true;
            this.new_date_combox.Location = new System.Drawing.Point(299, 6);
            this.new_date_combox.Name = "new_date_combox";
            this.new_date_combox.Size = new System.Drawing.Size(121, 21);
            this.new_date_combox.TabIndex = 45;
            // 
            // new_org_combox
            // 
            this.new_org_combox.FormattingEnabled = true;
            this.new_org_combox.Location = new System.Drawing.Point(86, 6);
            this.new_org_combox.Name = "new_org_combox";
            this.new_org_combox.Size = new System.Drawing.Size(165, 21);
            this.new_org_combox.TabIndex = 44;
            // 
            // V_anal_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.new_org_label);
            this.Controls.Add(this.new_date_label);
            this.Controls.Add(this.new_pricelist_but);
            this.Controls.Add(this.new_date_combox);
            this.Controls.Add(this.new_org_combox);
            this.Controls.Add(this.org_label);
            this.Controls.Add(this.tovar_label);
            this.Controls.Add(this.fasovka_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.tovar_shifr_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.back_but);
            this.Controls.Add(this.v_anal_but);
            this.Controls.Add(this.data_textbox);
            this.Controls.Add(this.tovar_shifr_textbox);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.clear_but);
            this.Controls.Add(this.minus_but);
            this.Controls.Add(this.plus_but);
            this.Controls.Add(this.filtr_but);
            this.Controls.Add(this.fasovka_combox);
            this.Controls.Add(this.tovar_combox);
            this.Controls.Add(this.org_combox);
            this.Controls.Add(this.v_anal_table);
            this.Name = "V_anal_form";
            this.Text = "Анализ объема продаж по территориальным сегментам";
            ((System.ComponentModel.ISupportInitialize)(this.v_anal_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView v_anal_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovar_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovar_shifr_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn org_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn fasovka_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ed_izm_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_column;
        private System.Windows.Forms.Label org_label;
        private System.Windows.Forms.Label tovar_label;
        private System.Windows.Forms.Label fasovka_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label tovar_shifr_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.Button back_but;
        private System.Windows.Forms.Button v_anal_but;
        private System.Windows.Forms.TextBox data_textbox;
        private System.Windows.Forms.TextBox tovar_shifr_textbox;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.Button clear_but;
        private System.Windows.Forms.Button minus_but;
        private System.Windows.Forms.Button plus_but;
        private System.Windows.Forms.Button filtr_but;
        private System.Windows.Forms.ComboBox fasovka_combox;
        private System.Windows.Forms.ComboBox tovar_combox;
        private System.Windows.Forms.ComboBox org_combox;
        private System.Windows.Forms.Label new_org_label;
        private System.Windows.Forms.Label new_date_label;
        private System.Windows.Forms.Button new_pricelist_but;
        private System.Windows.Forms.ComboBox new_date_combox;
        private System.Windows.Forms.ComboBox new_org_combox;
    }
}
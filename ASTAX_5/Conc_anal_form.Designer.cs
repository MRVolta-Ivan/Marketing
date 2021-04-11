namespace ASTAX_5
{
    partial class Conc_anal_form
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
            this.new_org_combox = new System.Windows.Forms.ComboBox();
            this.new_date_combox = new System.Windows.Forms.ComboBox();
            this.new_pricelist_but = new System.Windows.Forms.Button();
            this.new_date_label = new System.Windows.Forms.Label();
            this.new_org_label = new System.Windows.Forms.Label();
            this.conc_anal_table = new System.Windows.Forms.DataGridView();
            this.date_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.org_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovar_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovar_shifr_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fasovka_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ed_izmer_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.org_combox = new System.Windows.Forms.ComboBox();
            this.tovar_combox = new System.Windows.Forms.ComboBox();
            this.fasovka_combox = new System.Windows.Forms.ComboBox();
            this.filtr_but = new System.Windows.Forms.Button();
            this.plus_but = new System.Windows.Forms.Button();
            this.minus_but = new System.Windows.Forms.Button();
            this.clear_but = new System.Windows.Forms.Button();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.tovar_shifr_textbox = new System.Windows.Forms.TextBox();
            this.data_textbox = new System.Windows.Forms.TextBox();
            this.conc_anal_but = new System.Windows.Forms.Button();
            this.back_but = new System.Windows.Forms.Button();
            this.exit_but = new System.Windows.Forms.Button();
            this.price_label = new System.Windows.Forms.Label();
            this.tovar_shifr_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.fasovka_label = new System.Windows.Forms.Label();
            this.tovar_label = new System.Windows.Forms.Label();
            this.org_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.conc_anal_table)).BeginInit();
            this.SuspendLayout();
            // 
            // new_org_combox
            // 
            this.new_org_combox.FormattingEnabled = true;
            this.new_org_combox.Location = new System.Drawing.Point(95, 11);
            this.new_org_combox.Name = "new_org_combox";
            this.new_org_combox.Size = new System.Drawing.Size(165, 21);
            this.new_org_combox.TabIndex = 0;
            // 
            // new_date_combox
            // 
            this.new_date_combox.FormattingEnabled = true;
            this.new_date_combox.Location = new System.Drawing.Point(309, 11);
            this.new_date_combox.Name = "new_date_combox";
            this.new_date_combox.Size = new System.Drawing.Size(121, 21);
            this.new_date_combox.TabIndex = 1;
            // 
            // new_pricelist_but
            // 
            this.new_pricelist_but.Location = new System.Drawing.Point(452, 10);
            this.new_pricelist_but.Name = "new_pricelist_but";
            this.new_pricelist_but.Size = new System.Drawing.Size(81, 23);
            this.new_pricelist_but.TabIndex = 2;
            this.new_pricelist_but.Text = "Добавление";
            this.new_pricelist_but.UseVisualStyleBackColor = true;
            // 
            // new_date_label
            // 
            this.new_date_label.AutoSize = true;
            this.new_date_label.Location = new System.Drawing.Point(267, 14);
            this.new_date_label.Name = "new_date_label";
            this.new_date_label.Size = new System.Drawing.Size(36, 13);
            this.new_date_label.TabIndex = 3;
            this.new_date_label.Text = "Дата:";
            // 
            // new_org_label
            // 
            this.new_org_label.AutoSize = true;
            this.new_org_label.Location = new System.Drawing.Point(12, 14);
            this.new_org_label.Name = "new_org_label";
            this.new_org_label.Size = new System.Drawing.Size(77, 13);
            this.new_org_label.TabIndex = 4;
            this.new_org_label.Text = "Организация:";
            // 
            // conc_anal_table
            // 
            this.conc_anal_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conc_anal_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date_column,
            this.org_column,
            this.tovar_column,
            this.tovar_shifr_column,
            this.price_column,
            this.fasovka_column,
            this.ed_izmer_column});
            this.conc_anal_table.Location = new System.Drawing.Point(15, 39);
            this.conc_anal_table.Name = "conc_anal_table";
            this.conc_anal_table.Size = new System.Drawing.Size(743, 189);
            this.conc_anal_table.TabIndex = 5;
           // 
            // date_column
            // 
            this.date_column.HeaderText = "Дата";
            this.date_column.Name = "date_column";
            // 
            // org_column
            // 
            this.org_column.HeaderText = "Организация";
            this.org_column.Name = "org_column";
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
            // ed_izmer_column
            // 
            this.ed_izmer_column.HeaderText = "Ед-цы измерения";
            this.ed_izmer_column.Name = "ed_izmer_column";
            // 
            // org_combox
            // 
            this.org_combox.FormattingEnabled = true;
            this.org_combox.Location = new System.Drawing.Point(106, 240);
            this.org_combox.Name = "org_combox";
            this.org_combox.Size = new System.Drawing.Size(139, 21);
            this.org_combox.TabIndex = 6;
            // 
            // tovar_combox
            // 
            this.tovar_combox.FormattingEnabled = true;
            this.tovar_combox.Location = new System.Drawing.Point(106, 280);
            this.tovar_combox.Name = "tovar_combox";
            this.tovar_combox.Size = new System.Drawing.Size(139, 21);
            this.tovar_combox.TabIndex = 7;
            // 
            // fasovka_combox
            // 
            this.fasovka_combox.FormattingEnabled = true;
            this.fasovka_combox.Location = new System.Drawing.Point(106, 321);
            this.fasovka_combox.Name = "fasovka_combox";
            this.fasovka_combox.Size = new System.Drawing.Size(139, 21);
            this.fasovka_combox.TabIndex = 8;
            // 
            // filtr_but
            // 
            this.filtr_but.Location = new System.Drawing.Point(26, 360);
            this.filtr_but.Name = "filtr_but";
            this.filtr_but.Size = new System.Drawing.Size(122, 22);
            this.filtr_but.TabIndex = 9;
            this.filtr_but.Text = "Фильтр";
            this.filtr_but.UseVisualStyleBackColor = true;
            // 
            // plus_but
            // 
            this.plus_but.Location = new System.Drawing.Point(154, 360);
            this.plus_but.Name = "plus_but";
            this.plus_but.Size = new System.Drawing.Size(24, 22);
            this.plus_but.TabIndex = 10;
            this.plus_but.Text = "+";
            this.plus_but.UseVisualStyleBackColor = true;
            // 
            // minus_but
            // 
            this.minus_but.Location = new System.Drawing.Point(184, 360);
            this.minus_but.Name = "minus_but";
            this.minus_but.Size = new System.Drawing.Size(24, 22);
            this.minus_but.TabIndex = 11;
            this.minus_but.Text = "-";
            this.minus_but.UseVisualStyleBackColor = true;
            // 
            // clear_but
            // 
            this.clear_but.Location = new System.Drawing.Point(214, 360);
            this.clear_but.Name = "clear_but";
            this.clear_but.Size = new System.Drawing.Size(120, 22);
            this.clear_but.TabIndex = 12;
            this.clear_but.Text = "Сброс";
            this.clear_but.UseVisualStyleBackColor = true;
            // 
            // price_textbox
            // 
            this.price_textbox.Location = new System.Drawing.Point(415, 321);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(138, 20);
            this.price_textbox.TabIndex = 13;
            // 
            // tovar_shifr_textbox
            // 
            this.tovar_shifr_textbox.Location = new System.Drawing.Point(415, 283);
            this.tovar_shifr_textbox.Name = "tovar_shifr_textbox";
            this.tovar_shifr_textbox.Size = new System.Drawing.Size(138, 20);
            this.tovar_shifr_textbox.TabIndex = 14;
            // 
            // data_textbox
            // 
            this.data_textbox.Location = new System.Drawing.Point(415, 241);
            this.data_textbox.Name = "data_textbox";
            this.data_textbox.Size = new System.Drawing.Size(138, 20);
            this.data_textbox.TabIndex = 15;
            // 
            // conc_anal_but
            // 
            this.conc_anal_but.Location = new System.Drawing.Point(589, 276);
            this.conc_anal_but.Name = "conc_anal_but";
            this.conc_anal_but.Size = new System.Drawing.Size(169, 33);
            this.conc_anal_but.TabIndex = 16;
            this.conc_anal_but.Text = "Конкурентный анализ";
            this.conc_anal_but.UseVisualStyleBackColor = true;
            // 
            // back_but
            // 
            this.back_but.Location = new System.Drawing.Point(589, 360);
            this.back_but.Name = "back_but";
            this.back_but.Size = new System.Drawing.Size(70, 22);
            this.back_but.TabIndex = 17;
            this.back_but.Text = "Вернуться";
            this.back_but.UseVisualStyleBackColor = true;
            // 
            // exit_but
            // 
            this.exit_but.Location = new System.Drawing.Point(690, 360);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(68, 22);
            this.exit_but.TabIndex = 18;
            this.exit_but.Text = "Выход";
            this.exit_but.UseVisualStyleBackColor = true;
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(281, 323);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(128, 13);
            this.price_label.TabIndex = 19;
            this.price_label.Text = "Цена за ед. измерения:";
            // 
            // tovar_shifr_label
            // 
            this.tovar_shifr_label.AutoSize = true;
            this.tovar_shifr_label.Location = new System.Drawing.Point(281, 283);
            this.tovar_shifr_label.Name = "tovar_shifr_label";
            this.tovar_shifr_label.Size = new System.Drawing.Size(77, 13);
            this.tovar_shifr_label.TabIndex = 20;
            this.tovar_shifr_label.Text = "Шифр товара:";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(281, 243);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(36, 13);
            this.date_label.TabIndex = 21;
            this.date_label.Text = "Дата:";
            // 
            // fasovka_label
            // 
            this.fasovka_label.AutoSize = true;
            this.fasovka_label.Location = new System.Drawing.Point(23, 323);
            this.fasovka_label.Name = "fasovka_label";
            this.fasovka_label.Size = new System.Drawing.Size(57, 13);
            this.fasovka_label.TabIndex = 22;
            this.fasovka_label.Text = "Фасовка:";
            // 
            // tovar_label
            // 
            this.tovar_label.AutoSize = true;
            this.tovar_label.Location = new System.Drawing.Point(23, 283);
            this.tovar_label.Name = "tovar_label";
            this.tovar_label.Size = new System.Drawing.Size(41, 13);
            this.tovar_label.TabIndex = 23;
            this.tovar_label.Text = "Товар:";
            // 
            // org_label
            // 
            this.org_label.AutoSize = true;
            this.org_label.Location = new System.Drawing.Point(23, 243);
            this.org_label.Name = "org_label";
            this.org_label.Size = new System.Drawing.Size(77, 13);
            this.org_label.TabIndex = 24;
            this.org_label.Text = "Организация:";
            // 
            // Conc_anal_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 400);
            this.Controls.Add(this.org_label);
            this.Controls.Add(this.tovar_label);
            this.Controls.Add(this.fasovka_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.tovar_shifr_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.back_but);
            this.Controls.Add(this.conc_anal_but);
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
            this.Controls.Add(this.conc_anal_table);
            this.Controls.Add(this.new_org_label);
            this.Controls.Add(this.new_date_label);
            this.Controls.Add(this.new_pricelist_but);
            this.Controls.Add(this.new_date_combox);
            this.Controls.Add(this.new_org_combox);
            this.Name = "Conc_anal_form";
            this.Text = "Конкурентный анализ";
            ((System.ComponentModel.ISupportInitialize)(this.conc_anal_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox new_org_combox;
        private System.Windows.Forms.ComboBox new_date_combox;
        private System.Windows.Forms.Button new_pricelist_but;
        private System.Windows.Forms.Label new_date_label;
        private System.Windows.Forms.Label new_org_label;
        private System.Windows.Forms.DataGridView conc_anal_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn org_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovar_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovar_shifr_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn fasovka_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ed_izmer_column;
        private System.Windows.Forms.ComboBox org_combox;
        private System.Windows.Forms.ComboBox tovar_combox;
        private System.Windows.Forms.ComboBox fasovka_combox;
        private System.Windows.Forms.Button filtr_but;
        private System.Windows.Forms.Button plus_but;
        private System.Windows.Forms.Button minus_but;
        private System.Windows.Forms.Button clear_but;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.TextBox tovar_shifr_textbox;
        private System.Windows.Forms.TextBox data_textbox;
        private System.Windows.Forms.Button conc_anal_but;
        private System.Windows.Forms.Button back_but;
        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label tovar_shifr_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label fasovka_label;
        private System.Windows.Forms.Label tovar_label;
        private System.Windows.Forms.Label org_label;
    }
}
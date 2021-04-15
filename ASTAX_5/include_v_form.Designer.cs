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
            this.tovar_label = new System.Windows.Forms.Label();
            this.fasovka_label = new System.Windows.Forms.Label();
            this.tovar_shifr_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.back_exit_but = new System.Windows.Forms.Button();
            this.tovar_shifr_textbox = new System.Windows.Forms.TextBox();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.clear_but = new System.Windows.Forms.Button();
            this.minus_but = new System.Windows.Forms.Button();
            this.plus_but = new System.Windows.Forms.Button();
            this.filtr_but = new System.Windows.Forms.Button();
            this.fasovka_combox = new System.Windows.Forms.ComboBox();
            this.tovar_combox = new System.Windows.Forms.ComboBox();
            this.incude_table = new System.Windows.Forms.DataGridView();
            this.date_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.org_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovar_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovar_shifr_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fasovka_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ed_izmer_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.save_exit_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.incude_table)).BeginInit();
            this.SuspendLayout();
            // 
            // tovar_label
            // 
            this.tovar_label.AutoSize = true;
            this.tovar_label.Location = new System.Drawing.Point(18, 352);
            this.tovar_label.Name = "tovar_label";
            this.tovar_label.Size = new System.Drawing.Size(41, 13);
            this.tovar_label.TabIndex = 63;
            this.tovar_label.Text = "Товар:";
            // 
            // fasovka_label
            // 
            this.fasovka_label.AutoSize = true;
            this.fasovka_label.Location = new System.Drawing.Point(18, 392);
            this.fasovka_label.Name = "fasovka_label";
            this.fasovka_label.Size = new System.Drawing.Size(57, 13);
            this.fasovka_label.TabIndex = 62;
            this.fasovka_label.Text = "Фасовка:";
            // 
            // tovar_shifr_label
            // 
            this.tovar_shifr_label.AutoSize = true;
            this.tovar_shifr_label.Location = new System.Drawing.Point(276, 352);
            this.tovar_shifr_label.Name = "tovar_shifr_label";
            this.tovar_shifr_label.Size = new System.Drawing.Size(77, 13);
            this.tovar_shifr_label.TabIndex = 61;
            this.tovar_shifr_label.Text = "Шифр товара:";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(276, 392);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(128, 13);
            this.price_label.TabIndex = 60;
            this.price_label.Text = "Цена за ед. измерения:";
            // 
            // back_exit_but
            // 
            this.back_exit_but.Location = new System.Drawing.Point(685, 429);
            this.back_exit_but.Name = "back_exit_but";
            this.back_exit_but.Size = new System.Drawing.Size(70, 22);
            this.back_exit_but.TabIndex = 58;
            this.back_exit_but.Text = "Отменить";
            this.back_exit_but.UseVisualStyleBackColor = true;
            // 
            // tovar_shifr_textbox
            // 
            this.tovar_shifr_textbox.Location = new System.Drawing.Point(410, 352);
            this.tovar_shifr_textbox.Name = "tovar_shifr_textbox";
            this.tovar_shifr_textbox.Size = new System.Drawing.Size(138, 20);
            this.tovar_shifr_textbox.TabIndex = 57;
            // 
            // price_textbox
            // 
            this.price_textbox.Location = new System.Drawing.Point(410, 390);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(138, 20);
            this.price_textbox.TabIndex = 56;
            // 
            // clear_but
            // 
            this.clear_but.Location = new System.Drawing.Point(209, 429);
            this.clear_but.Name = "clear_but";
            this.clear_but.Size = new System.Drawing.Size(120, 22);
            this.clear_but.TabIndex = 55;
            this.clear_but.Text = "Сброс";
            this.clear_but.UseVisualStyleBackColor = true;
            // 
            // minus_but
            // 
            this.minus_but.Location = new System.Drawing.Point(179, 429);
            this.minus_but.Name = "minus_but";
            this.minus_but.Size = new System.Drawing.Size(24, 22);
            this.minus_but.TabIndex = 54;
            this.minus_but.Text = "-";
            this.minus_but.UseVisualStyleBackColor = true;
            // 
            // plus_but
            // 
            this.plus_but.Location = new System.Drawing.Point(149, 429);
            this.plus_but.Name = "plus_but";
            this.plus_but.Size = new System.Drawing.Size(24, 22);
            this.plus_but.TabIndex = 53;
            this.plus_but.Text = "+";
            this.plus_but.UseVisualStyleBackColor = true;
            // 
            // filtr_but
            // 
            this.filtr_but.Location = new System.Drawing.Point(21, 429);
            this.filtr_but.Name = "filtr_but";
            this.filtr_but.Size = new System.Drawing.Size(122, 22);
            this.filtr_but.TabIndex = 52;
            this.filtr_but.Text = "Фильтр";
            this.filtr_but.UseVisualStyleBackColor = true;
            // 
            // fasovka_combox
            // 
            this.fasovka_combox.FormattingEnabled = true;
            this.fasovka_combox.Location = new System.Drawing.Point(101, 390);
            this.fasovka_combox.Name = "fasovka_combox";
            this.fasovka_combox.Size = new System.Drawing.Size(139, 21);
            this.fasovka_combox.TabIndex = 51;
            // 
            // tovar_combox
            // 
            this.tovar_combox.FormattingEnabled = true;
            this.tovar_combox.Location = new System.Drawing.Point(101, 349);
            this.tovar_combox.Name = "tovar_combox";
            this.tovar_combox.Size = new System.Drawing.Size(139, 21);
            this.tovar_combox.TabIndex = 50;
            // 
            // incude_table
            // 
            this.incude_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incude_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date_column,
            this.org_column,
            this.tovar_column,
            this.tovar_shifr_column,
            this.price_column,
            this.fasovka_column,
            this.ed_izmer_column});
            this.incude_table.Location = new System.Drawing.Point(12, 12);
            this.incude_table.Name = "incude_table";
            this.incude_table.Size = new System.Drawing.Size(743, 331);
            this.incude_table.TabIndex = 49;
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
            // save_exit_but
            // 
            this.save_exit_but.Location = new System.Drawing.Point(578, 429);
            this.save_exit_but.Name = "save_exit_but";
            this.save_exit_but.Size = new System.Drawing.Size(70, 22);
            this.save_exit_but.TabIndex = 64;
            this.save_exit_but.Text = "Принять";
            this.save_exit_but.UseVisualStyleBackColor = true;
            // 
            // Include_v_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 461);
            this.Controls.Add(this.save_exit_but);
            this.Controls.Add(this.tovar_label);
            this.Controls.Add(this.fasovka_label);
            this.Controls.Add(this.tovar_shifr_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.back_exit_but);
            this.Controls.Add(this.tovar_shifr_textbox);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.clear_but);
            this.Controls.Add(this.minus_but);
            this.Controls.Add(this.plus_but);
            this.Controls.Add(this.filtr_but);
            this.Controls.Add(this.fasovka_combox);
            this.Controls.Add(this.tovar_combox);
            this.Controls.Add(this.incude_table);
            this.Name = "Include_v_form";
            this.Text = "Добавление акта приема-передачи товара";
            ((System.ComponentModel.ISupportInitialize)(this.incude_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tovar_label;
        private System.Windows.Forms.Label fasovka_label;
        private System.Windows.Forms.Label tovar_shifr_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Button back_exit_but;
        private System.Windows.Forms.TextBox tovar_shifr_textbox;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.Button clear_but;
        private System.Windows.Forms.Button minus_but;
        private System.Windows.Forms.Button plus_but;
        private System.Windows.Forms.Button filtr_but;
        private System.Windows.Forms.ComboBox fasovka_combox;
        private System.Windows.Forms.ComboBox tovar_combox;
        private System.Windows.Forms.DataGridView incude_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn org_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovar_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovar_shifr_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn fasovka_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ed_izmer_column;
        private System.Windows.Forms.Button save_exit_but;
    }
}
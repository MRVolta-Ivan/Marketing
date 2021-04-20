namespace ASTAX_5
{
    partial class Search_v_form
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
            this.org_label = new System.Windows.Forms.Label();
            this.tovar_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.tovar_shifr_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.exit_but = new System.Windows.Forms.Button();
            this.pricefrom_textbox = new System.Windows.Forms.TextBox();
            this.search_but = new System.Windows.Forms.Button();
            this.org_combox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelToPrice = new System.Windows.Forms.Label();
            this.priceto_textbox = new System.Windows.Forms.TextBox();
            this.num_doc_label = new System.Windows.Forms.Label();
            this.num_doc_combox = new System.Windows.Forms.ComboBox();
            this.tovar_combobox = new System.Windows.Forms.ComboBox();
            this.tovar_shifr_combobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // org_label
            // 
            this.org_label.AutoSize = true;
            this.org_label.Location = new System.Drawing.Point(37, 71);
            this.org_label.Name = "org_label";
            this.org_label.Size = new System.Drawing.Size(77, 13);
            this.org_label.TabIndex = 43;
            this.org_label.Text = "Организация:";
            // 
            // tovar_label
            // 
            this.tovar_label.AutoSize = true;
            this.tovar_label.Location = new System.Drawing.Point(37, 111);
            this.tovar_label.Name = "tovar_label";
            this.tovar_label.Size = new System.Drawing.Size(41, 13);
            this.tovar_label.TabIndex = 42;
            this.tovar_label.Text = "Товар:";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(36, 150);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(36, 13);
            this.date_label.TabIndex = 40;
            this.date_label.Text = "Дата:";
            // 
            // tovar_shifr_label
            // 
            this.tovar_shifr_label.AutoSize = true;
            this.tovar_shifr_label.Location = new System.Drawing.Point(36, 190);
            this.tovar_shifr_label.Name = "tovar_shifr_label";
            this.tovar_shifr_label.Size = new System.Drawing.Size(77, 13);
            this.tovar_shifr_label.TabIndex = 39;
            this.tovar_shifr_label.Text = "Шифр товара:";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(37, 228);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(50, 13);
            this.price_label.TabIndex = 38;
            this.price_label.Text = "Цена от:";
            // 
            // exit_but
            // 
            this.exit_but.Location = new System.Drawing.Point(294, 283);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(154, 40);
            this.exit_but.TabIndex = 37;
            this.exit_but.Text = "Выйти";
            this.exit_but.UseVisualStyleBackColor = true;
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click);
            // 
            // pricefrom_textbox
            // 
            this.pricefrom_textbox.Location = new System.Drawing.Point(137, 225);
            this.pricefrom_textbox.Name = "pricefrom_textbox";
            this.pricefrom_textbox.Size = new System.Drawing.Size(126, 20);
            this.pricefrom_textbox.TabIndex = 32;
            // 
            // search_but
            // 
            this.search_but.Location = new System.Drawing.Point(39, 283);
            this.search_but.Name = "search_but";
            this.search_but.Size = new System.Drawing.Size(154, 40);
            this.search_but.TabIndex = 28;
            this.search_but.Text = "Найти";
            this.search_but.UseVisualStyleBackColor = true;
            this.search_but.Click += new System.EventHandler(this.search_but_Click);
            // 
            // org_combox
            // 
            this.org_combox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.org_combox.FormattingEnabled = true;
            this.org_combox.Location = new System.Drawing.Point(137, 68);
            this.org_combox.Name = "org_combox";
            this.org_combox.Size = new System.Drawing.Size(311, 21);
            this.org_combox.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(311, 20);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // labelToPrice
            // 
            this.labelToPrice.AutoSize = true;
            this.labelToPrice.Location = new System.Drawing.Point(277, 228);
            this.labelToPrice.Name = "labelToPrice";
            this.labelToPrice.Size = new System.Drawing.Size(25, 13);
            this.labelToPrice.TabIndex = 52;
            this.labelToPrice.Text = "До:";
            // 
            // priceto_textbox
            // 
            this.priceto_textbox.Location = new System.Drawing.Point(314, 226);
            this.priceto_textbox.Name = "priceto_textbox";
            this.priceto_textbox.Size = new System.Drawing.Size(134, 20);
            this.priceto_textbox.TabIndex = 53;
            // 
            // num_doc_label
            // 
            this.num_doc_label.AutoSize = true;
            this.num_doc_label.Location = new System.Drawing.Point(37, 30);
            this.num_doc_label.Name = "num_doc_label";
            this.num_doc_label.Size = new System.Drawing.Size(94, 13);
            this.num_doc_label.TabIndex = 57;
            this.num_doc_label.Text = "Номер договора:";
            // 
            // num_doc_combox
            // 
            this.num_doc_combox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.num_doc_combox.FormattingEnabled = true;
            this.num_doc_combox.Location = new System.Drawing.Point(137, 27);
            this.num_doc_combox.Name = "num_doc_combox";
            this.num_doc_combox.Size = new System.Drawing.Size(311, 21);
            this.num_doc_combox.TabIndex = 56;
            // 
            // tovar_combobox
            // 
            this.tovar_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tovar_combobox.FormattingEnabled = true;
            this.tovar_combobox.Location = new System.Drawing.Point(137, 108);
            this.tovar_combobox.Name = "tovar_combobox";
            this.tovar_combobox.Size = new System.Drawing.Size(311, 21);
            this.tovar_combobox.TabIndex = 58;
            // 
            // tovar_shifr_combobox
            // 
            this.tovar_shifr_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tovar_shifr_combobox.FormattingEnabled = true;
            this.tovar_shifr_combobox.Location = new System.Drawing.Point(137, 187);
            this.tovar_shifr_combobox.Name = "tovar_shifr_combobox";
            this.tovar_shifr_combobox.Size = new System.Drawing.Size(311, 21);
            this.tovar_shifr_combobox.TabIndex = 59;
            // 
            // Search_v_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 368);
            this.Controls.Add(this.tovar_shifr_combobox);
            this.Controls.Add(this.tovar_combobox);
            this.Controls.Add(this.num_doc_label);
            this.Controls.Add(this.num_doc_combox);
            this.Controls.Add(this.priceto_textbox);
            this.Controls.Add(this.labelToPrice);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.org_label);
            this.Controls.Add(this.tovar_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.tovar_shifr_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.pricefrom_textbox);
            this.Controls.Add(this.search_but);
            this.Controls.Add(this.org_combox);
            this.Name = "Search_v_form";
            this.Text = "Поиск данных";
            this.Load += new System.EventHandler(this.V_anal_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label org_label;
        private System.Windows.Forms.Label tovar_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label tovar_shifr_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.TextBox pricefrom_textbox;
        private System.Windows.Forms.Button search_but;
        private System.Windows.Forms.ComboBox org_combox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelToPrice;
        private System.Windows.Forms.TextBox priceto_textbox;
        private System.Windows.Forms.Label num_doc_label;
        private System.Windows.Forms.ComboBox num_doc_combox;
        private System.Windows.Forms.ComboBox tovar_combobox;
        private System.Windows.Forms.ComboBox tovar_shifr_combobox;
    }
}
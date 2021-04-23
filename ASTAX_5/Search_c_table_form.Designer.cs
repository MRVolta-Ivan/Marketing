namespace ASTAX_5
{
    partial class Search_c_table_form
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
            this.back_but = new System.Windows.Forms.Button();
            this.v_anal_table = new System.Windows.Forms.DataGridView();
            this.date_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovar_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovar_shifr_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.org_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shifr_org_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ed_izm_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.v_anal_table)).BeginInit();
            this.SuspendLayout();
            // 
            // back_but
            // 
            this.back_but.Location = new System.Drawing.Point(12, 12);
            this.back_but.Name = "back_but";
            this.back_but.Size = new System.Drawing.Size(175, 37);
            this.back_but.TabIndex = 5;
            this.back_but.Text = "Вернуться к поиску данных";
            this.back_but.UseVisualStyleBackColor = true;
            this.back_but.Click += new System.EventHandler(this.back_but_Click);
            // 
            // v_anal_table
            // 
            this.v_anal_table.AllowUserToAddRows = false;
            this.v_anal_table.AllowUserToDeleteRows = false;
            this.v_anal_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.v_anal_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.v_anal_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date_column,
            this.tovar_column,
            this.tovar_shifr_col,
            this.org_column,
            this.shifr_org_column,
            this.price_column,
            this.ed_izm_column});
            this.v_anal_table.Location = new System.Drawing.Point(13, 55);
            this.v_anal_table.Name = "v_anal_table";
            this.v_anal_table.ReadOnly = true;
            this.v_anal_table.Size = new System.Drawing.Size(959, 464);
            this.v_anal_table.TabIndex = 4;
            // 
            // date_column
            // 
            this.date_column.HeaderText = "Дата";
            this.date_column.Name = "date_column";
            this.date_column.ReadOnly = true;
            // 
            // tovar_column
            // 
            this.tovar_column.HeaderText = "Товар";
            this.tovar_column.Name = "tovar_column";
            this.tovar_column.ReadOnly = true;
            // 
            // tovar_shifr_col
            // 
            this.tovar_shifr_col.HeaderText = "Шифр товара";
            this.tovar_shifr_col.Name = "tovar_shifr_col";
            this.tovar_shifr_col.ReadOnly = true;
            // 
            // org_column
            // 
            this.org_column.HeaderText = "Организация";
            this.org_column.Name = "org_column";
            this.org_column.ReadOnly = true;
            // 
            // shifr_org_column
            // 
            this.shifr_org_column.HeaderText = "Шифр организации";
            this.shifr_org_column.Name = "shifr_org_column";
            this.shifr_org_column.ReadOnly = true;
            // 
            // price_column
            // 
            this.price_column.HeaderText = "Цена";
            this.price_column.Name = "price_column";
            this.price_column.ReadOnly = true;
            // 
            // ed_izm_column
            // 
            this.ed_izm_column.HeaderText = "Единицы измерения";
            this.ed_izm_column.Name = "ed_izm_column";
            this.ed_izm_column.ReadOnly = true;
            // 
            // Search_c_table_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 531);
            this.Controls.Add(this.back_but);
            this.Controls.Add(this.v_anal_table);
            this.Name = "Search_c_table_form";
            this.Text = "Результат поиска";
            this.Load += new System.EventHandler(this.Search_c_table_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.v_anal_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button back_but;
        private System.Windows.Forms.DataGridView v_anal_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovar_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovar_shifr_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn org_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn shifr_org_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ed_izm_column;
    }
}
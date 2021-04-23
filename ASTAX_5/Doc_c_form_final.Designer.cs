
namespace ASTAX_5
{
    partial class Doc_c_form_final
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
            this.doc_table = new System.Windows.Forms.DataGridView();
            this.org_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min_price_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max_price_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sr_price_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.save_but = new System.Windows.Forms.Button();
            this.exit_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doc_table)).BeginInit();
            this.SuspendLayout();
            // 
            // doc_table
            // 
            this.doc_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doc_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doc_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.org_column,
            this.min_price_column,
            this.max_price_column,
            this.sr_price_column});
            this.doc_table.Location = new System.Drawing.Point(25, 75);
            this.doc_table.Name = "doc_table";
            this.doc_table.Size = new System.Drawing.Size(929, 434);
            this.doc_table.TabIndex = 53;
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
            // save_but
            // 
            this.save_but.Location = new System.Drawing.Point(25, 12);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(122, 48);
            this.save_but.TabIndex = 72;
            this.save_but.Text = "Сохранить документ";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(this.save_but_Click);
            // 
            // exit_but
            // 
            this.exit_but.Location = new System.Drawing.Point(172, 12);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(122, 48);
            this.exit_but.TabIndex = 73;
            this.exit_but.Text = "Вернуться к выбору периода анализа ";
            this.exit_but.UseVisualStyleBackColor = true;
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click);
            // 
            // Doc_c_form_final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 531);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.doc_table);
            this.Name = "Doc_c_form_final";
            this.Text = "Конкурентный анализ";
            this.Load += new System.EventHandler(this.Doc_c_form_final_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doc_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView doc_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn org_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn min_price_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn max_price_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn sr_price_column;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.Button exit_but;
    }
}
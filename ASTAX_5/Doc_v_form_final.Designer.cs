
namespace ASTAX_5
{
    partial class Doc_v_form_final
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
            this.exit_but = new System.Windows.Forms.Button();
            this.save_but = new System.Windows.Forms.Button();
            this.doc_table = new System.Windows.Forms.DataGridView();
            this.segm_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.doc_table)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_but
            // 
            this.exit_but.Location = new System.Drawing.Point(171, 12);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(122, 48);
            this.exit_but.TabIndex = 72;
            this.exit_but.Text = "Вернуться к выбору периода анализа ";
            this.exit_but.UseVisualStyleBackColor = true;
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click);
            // 
            // save_but
            // 
            this.save_but.Location = new System.Drawing.Point(23, 12);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(122, 48);
            this.save_but.TabIndex = 71;
            this.save_but.Text = "Сохранить документ";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(this.save_but_Click);
            // 
            // doc_table
            // 
            this.doc_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doc_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.segm_column});
            this.doc_table.Location = new System.Drawing.Point(23, 74);
            this.doc_table.Name = "doc_table";
            this.doc_table.Size = new System.Drawing.Size(938, 434);
            this.doc_table.TabIndex = 70;
            // 
            // segm_column
            // 
            this.segm_column.HeaderText = "Сегмент";
            this.segm_column.Name = "segm_column";
            // 
            // Doc_v_form_final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 531);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.doc_table);
            this.Name = "Doc_v_form_final";
            this.Text = "Анализ обьема продаж по территориальным сегментам";
            this.Load += new System.EventHandler(this.Doc_v_form_final_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doc_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.DataGridView doc_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn segm_column;
    }
}
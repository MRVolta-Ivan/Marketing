namespace ASTAX_5
{
    partial class Doc_v_form
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
            this.segm_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.doc_table)).BeginInit();
            this.SuspendLayout();
            // 
            // period_label
            // 
            this.period_label.AutoSize = true;
            this.period_label.Location = new System.Drawing.Point(14, 12);
            this.period_label.Name = "period_label";
            this.period_label.Size = new System.Drawing.Size(88, 13);
            this.period_label.TabIndex = 70;
            this.period_label.Text = "Введите период";
            // 
            // exit_but
            // 
            this.exit_but.Location = new System.Drawing.Point(330, 241);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(125, 40);
            this.exit_but.TabIndex = 69;
            this.exit_but.Text = "Выход";
            this.exit_but.UseVisualStyleBackColor = true;
            // 
            // print_but
            // 
            this.print_but.Location = new System.Drawing.Point(171, 241);
            this.print_but.Name = "print_but";
            this.print_but.Size = new System.Drawing.Size(125, 40);
            this.print_but.TabIndex = 68;
            this.print_but.Text = "Печать";
            this.print_but.UseVisualStyleBackColor = true;
            // 
            // date_textbox
            // 
            this.date_textbox.Location = new System.Drawing.Point(108, 9);
            this.date_textbox.Name = "date_textbox";
            this.date_textbox.Size = new System.Drawing.Size(107, 20);
            this.date_textbox.TabIndex = 67;
            // 
            // save_but
            // 
            this.save_but.Location = new System.Drawing.Point(12, 241);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(125, 40);
            this.save_but.TabIndex = 66;
            this.save_but.Text = "Сохранить документ";
            this.save_but.UseVisualStyleBackColor = true;
            // 
            // doc_table
            // 
            this.doc_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doc_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.segm_column});
            this.doc_table.Location = new System.Drawing.Point(12, 45);
            this.doc_table.Name = "doc_table";
            this.doc_table.Size = new System.Drawing.Size(443, 168);
            this.doc_table.TabIndex = 65;
            // 
            // segm_column
            // 
            this.segm_column.HeaderText = "Сегмент";
            this.segm_column.Name = "segm_column";
            // 
            // Doc_v_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 295);
            this.Controls.Add(this.period_label);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.print_but);
            this.Controls.Add(this.date_textbox);
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.doc_table);
            this.Name = "Doc_v_form";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn segm_column;
    }
}
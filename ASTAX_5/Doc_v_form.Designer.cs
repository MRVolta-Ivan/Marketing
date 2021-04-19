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
            this.save_but = new System.Windows.Forms.Button();
            this.doc_table = new System.Windows.Forms.DataGridView();
            this.segm_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.org_combox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doc_table)).BeginInit();
            this.SuspendLayout();
            // 
            // period_label
            // 
            this.period_label.AutoSize = true;
            this.period_label.Location = new System.Drawing.Point(24, 28);
            this.period_label.Name = "period_label";
            this.period_label.Size = new System.Drawing.Size(106, 13);
            this.period_label.TabIndex = 70;
            this.period_label.Text = "Введите период:   с";
            // 
            // exit_but
            // 
            this.exit_but.Location = new System.Drawing.Point(842, 165);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(122, 48);
            this.exit_but.TabIndex = 69;
            this.exit_but.Text = "Выход";
            this.exit_but.UseVisualStyleBackColor = true;
            // 
            // save_but
            // 
            this.save_but.Location = new System.Drawing.Point(842, 91);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(122, 48);
            this.save_but.TabIndex = 66;
            this.save_but.Text = "Сохранить документ";
            this.save_but.UseVisualStyleBackColor = true;
            // 
            // doc_table
            // 
            this.doc_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doc_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.segm_column});
            this.doc_table.Location = new System.Drawing.Point(27, 71);
            this.doc_table.Name = "doc_table";
            this.doc_table.Size = new System.Drawing.Size(797, 434);
            this.doc_table.TabIndex = 65;
            // 
            // segm_column
            // 
            this.segm_column.HeaderText = "Сегмент";
            this.segm_column.Name = "segm_column";
            // 
            // org_combox
            // 
            this.org_combox.FormattingEnabled = true;
            this.org_combox.Location = new System.Drawing.Point(136, 25);
            this.org_combox.Name = "org_combox";
            this.org_combox.Size = new System.Drawing.Size(116, 21);
            this.org_combox.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "года   по";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(315, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 21);
            this.comboBox1.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "год";
            // 
            // Doc_v_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 531);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.org_combox);
            this.Controls.Add(this.period_label);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.doc_table);
            this.Name = "Doc_v_form";
            this.Text = "Анализ обьема продаж по территориальным сегментам";
            ((System.ComponentModel.ISupportInitialize)(this.doc_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label period_label;
        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.DataGridView doc_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn segm_column;
        private System.Windows.Forms.ComboBox org_combox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}
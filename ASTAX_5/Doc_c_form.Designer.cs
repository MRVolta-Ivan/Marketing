namespace ASTAX_5
{
    partial class Doc_c_form
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateto_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datefrom_combox = new System.Windows.Forms.ComboBox();
            this.period_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit_but
            // 
            this.exit_but.Location = new System.Drawing.Point(110, 249);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(256, 68);
            this.exit_but.TabIndex = 81;
            this.exit_but.Text = "Выход";
            this.exit_but.UseVisualStyleBackColor = true;
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click);
            // 
            // save_but
            // 
            this.save_but.Location = new System.Drawing.Point(110, 156);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(256, 68);
            this.save_but.TabIndex = 80;
            this.save_but.Text = "Анализ";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(this.save_but_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "по";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "год";
            // 
            // dateto_combobox
            // 
            this.dateto_combobox.FormattingEnabled = true;
            this.dateto_combobox.Location = new System.Drawing.Point(220, 100);
            this.dateto_combobox.Name = "dateto_combobox";
            this.dateto_combobox.Size = new System.Drawing.Size(116, 21);
            this.dateto_combobox.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "года  ";
            // 
            // datefrom_combox
            // 
            this.datefrom_combox.FormattingEnabled = true;
            this.datefrom_combox.Location = new System.Drawing.Point(220, 73);
            this.datefrom_combox.Name = "datefrom_combox";
            this.datefrom_combox.Size = new System.Drawing.Size(116, 21);
            this.datefrom_combox.TabIndex = 83;
            // 
            // period_label
            // 
            this.period_label.AutoSize = true;
            this.period_label.Location = new System.Drawing.Point(108, 76);
            this.period_label.Name = "period_label";
            this.period_label.Size = new System.Drawing.Size(106, 13);
            this.period_label.TabIndex = 82;
            this.period_label.Text = "Введите период:   с";
            // 
            // Doc_c_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 368);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateto_combobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datefrom_combox);
            this.Controls.Add(this.period_label);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.save_but);
            this.Name = "Doc_c_form";
            this.Text = "Выбор периода анализа";
            this.Load += new System.EventHandler(this.Doc_c_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dateto_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox datefrom_combox;
        private System.Windows.Forms.Label period_label;
    }
}
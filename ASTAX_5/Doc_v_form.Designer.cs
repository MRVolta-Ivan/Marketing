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
            this.datefrom_combox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateto_combobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exit_but = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // period_label
            // 
            this.period_label.AutoSize = true;
            this.period_label.Location = new System.Drawing.Point(111, 74);
            this.period_label.Name = "period_label";
            this.period_label.Size = new System.Drawing.Size(106, 13);
            this.period_label.TabIndex = 70;
            this.period_label.Text = "Введите период:   с";
            // 
            // datefrom_combox
            // 
            this.datefrom_combox.FormattingEnabled = true;
            this.datefrom_combox.Location = new System.Drawing.Point(223, 71);
            this.datefrom_combox.Name = "datefrom_combox";
            this.datefrom_combox.Size = new System.Drawing.Size(116, 21);
            this.datefrom_combox.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "года  ";
            // 
            // dateto_combobox
            // 
            this.dateto_combobox.FormattingEnabled = true;
            this.dateto_combobox.Location = new System.Drawing.Point(223, 98);
            this.dateto_combobox.Name = "dateto_combobox";
            this.dateto_combobox.Size = new System.Drawing.Size(116, 21);
            this.dateto_combobox.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "год";
            // 
            // exit_but
            // 
            this.exit_but.Location = new System.Drawing.Point(114, 247);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(256, 68);
            this.exit_but.TabIndex = 75;
            this.exit_but.Text = "Выйти";
            this.exit_but.UseVisualStyleBackColor = true;
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 68);
            this.button1.TabIndex = 76;
            this.button1.Text = "Анализ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "по";
            // 
            // Doc_v_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 368);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateto_combobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datefrom_combox);
            this.Controls.Add(this.period_label);
            this.Name = "Doc_v_form";
            this.Text = "Выбор периода анализа";
            this.Load += new System.EventHandler(this.Doc_v_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label period_label;
        private System.Windows.Forms.ComboBox datefrom_combox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dateto_combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}
namespace ASTAX_5
{
    partial class Menu_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.conc_anal_but = new System.Windows.Forms.Button();
            this.V_anal_but = new System.Windows.Forms.Button();
            this.exit_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conc_anal_but
            // 
            this.conc_anal_but.Location = new System.Drawing.Point(39, 30);
            this.conc_anal_but.Name = "conc_anal_but";
            this.conc_anal_but.Size = new System.Drawing.Size(192, 45);
            this.conc_anal_but.TabIndex = 0;
            this.conc_anal_but.Text = "Конкурентный анализ";
            this.conc_anal_but.UseVisualStyleBackColor = true;
            this.conc_anal_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // V_anal_but
            // 
            this.V_anal_but.Location = new System.Drawing.Point(39, 91);
            this.V_anal_but.Name = "V_anal_but";
            this.V_anal_but.Size = new System.Drawing.Size(192, 47);
            this.V_anal_but.TabIndex = 1;
            this.V_anal_but.Text = "Анализ объема продаж по территориальным сегментам";
            this.V_anal_but.UseVisualStyleBackColor = true;
            // 
            // exit_but
            // 
            this.exit_but.Location = new System.Drawing.Point(39, 154);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(192, 40);
            this.exit_but.TabIndex = 2;
            this.exit_but.Text = "Выход";
            this.exit_but.UseVisualStyleBackColor = true;
            // 
            // Menu_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 223);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.V_anal_but);
            this.Controls.Add(this.conc_anal_but);
            this.Name = "Menu_form";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button conc_anal_but;
        private System.Windows.Forms.Button V_anal_but;
        private System.Windows.Forms.Button exit_but;
    }
}


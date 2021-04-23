namespace ASTAX_5
{
    partial class Menu_c_form
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
            this.anal_but = new System.Windows.Forms.Button();
            this.search_but = new System.Windows.Forms.Button();
            this.include_but = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_but
            // 
            this.back_but.Location = new System.Drawing.Point(115, 261);
            this.back_but.Name = "back_but";
            this.back_but.Size = new System.Drawing.Size(256, 68);
            this.back_but.TabIndex = 7;
            this.back_but.Text = "Вернуться в Меню";
            this.back_but.UseVisualStyleBackColor = true;
            this.back_but.Click += new System.EventHandler(this.back_but_Click);
            // 
            // anal_but
            // 
            this.anal_but.Location = new System.Drawing.Point(115, 187);
            this.anal_but.Name = "anal_but";
            this.anal_but.Size = new System.Drawing.Size(256, 68);
            this.anal_but.TabIndex = 6;
            this.anal_but.Text = "Конкурентный анализ";
            this.anal_but.UseVisualStyleBackColor = true;
            this.anal_but.Click += new System.EventHandler(this.anal_but_Click);
            // 
            // search_but
            // 
            this.search_but.Location = new System.Drawing.Point(115, 113);
            this.search_but.Name = "search_but";
            this.search_but.Size = new System.Drawing.Size(256, 68);
            this.search_but.TabIndex = 5;
            this.search_but.Text = "Поиск данных";
            this.search_but.UseVisualStyleBackColor = true;
            this.search_but.Click += new System.EventHandler(this.search_but_Click);
            // 
            // include_but
            // 
            this.include_but.Location = new System.Drawing.Point(115, 39);
            this.include_but.Name = "include_but";
            this.include_but.Size = new System.Drawing.Size(256, 68);
            this.include_but.TabIndex = 4;
            this.include_but.Text = "Ввод данных";
            this.include_but.UseVisualStyleBackColor = true;
            this.include_but.Click += new System.EventHandler(this.include_but_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(115, 335);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(256, 68);
            this.button_exit.TabIndex = 8;
            this.button_exit.Text = "Выйти из программы";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Menu_c_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 430);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.back_but);
            this.Controls.Add(this.anal_but);
            this.Controls.Add(this.search_but);
            this.Controls.Add(this.include_but);
            this.Name = "Menu_c_form";
            this.Text = "Меню конкурентного анализа";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_but;
        private System.Windows.Forms.Button anal_but;
        private System.Windows.Forms.Button search_but;
        private System.Windows.Forms.Button include_but;
        private System.Windows.Forms.Button button_exit;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASTAX_5
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.instance.Init(textBoxUserName.Text, textBoxPassword.Text);

                Menu_form menu = new Menu_form(this);
                menu.Show();
                Hide();
            }
            catch (Exception ex)
            {
                string message = "Неправильный логин или пароль!";
                string caption = "Ошибка!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
        }
    }
}

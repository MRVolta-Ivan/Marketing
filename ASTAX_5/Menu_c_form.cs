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
    public partial class Menu_c_form : Form
    {
        public Menu_c_form()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_but_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void include_but_Click(object sender, EventArgs e)
        {
            Include_c_form form = new Include_c_form();
            Hide();
            form.ShowDialog();
            Show();
            
        }

        private void search_but_Click(object sender, EventArgs e)
        {
            Search_c_form form = new Search_c_form();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void anal_but_Click(object sender, EventArgs e)
        {
            Doc_c_form form = new Doc_c_form();
            Hide();
            form.ShowDialog();
            Show();
        }
    }
}

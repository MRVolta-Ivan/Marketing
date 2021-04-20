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
    public partial class Menu_v_form : Form
    {
        public Menu_v_form()
        {
            InitializeComponent();
        }

        private void include_but_Click(object sender, EventArgs e)
        {
            Include_v_form form = new Include_v_form();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void search_but_Click(object sender, EventArgs e)
        {
            Search_v_form form = new Search_v_form();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void anal_but_Click(object sender, EventArgs e)
        {
            Doc_v_form form = new Doc_v_form();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void back_but_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

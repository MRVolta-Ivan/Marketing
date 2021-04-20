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
    public partial class Menu_form : Form
    {
        private bool exit = false;

        public Menu_form()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            exit = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_c_form form = new Menu_c_form();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            exit = false;
            Close();
        }

        private void Menu_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            DBConnection.instance.CloseCon();

            if (exit)
                Application.Exit();
        }

        private void V_anal_but_Click(object sender, EventArgs e)
        {
            Menu_v_form form = new Menu_v_form();
            Hide();
            form.ShowDialog();
            Show();
        }
    }
}

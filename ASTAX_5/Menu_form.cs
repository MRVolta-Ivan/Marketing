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
        bool exit;

        Form loginForm;

        public Menu_form(Form loginForm)
        {
            InitializeComponent();
            exit = true;
            this.loginForm = loginForm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conc_anal_form form = new Conc_anal_form();
            form.ShowDialog();
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
            else
                loginForm.Show();
        }

        private void V_anal_but_Click(object sender, EventArgs e)
        {
            V_anal_form form = new V_anal_form();
            form.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASTAX_5.Repository;

namespace ASTAX_5
{
    public partial class Doc_v_form : Form
    {
        InputOutputRepository IORepos = new InputOutputRepository();

        public Doc_v_form()
        {
            InitializeComponent();
        }

        private void Doc_v_form_Load(object sender, EventArgs e)
        {
            List<List<string>> years = IORepos.GetUniqYears();
            foreach (List<string> i in years)
            {
                datefrom_combox.Items.Add(i[0]);
                dateto_combobox.Items.Add(i[0]);
            }
            if (years.Count > 0)
            {
                datefrom_combox.SelectedIndex = 0;
                dateto_combobox.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doc_v_form_final form = new Doc_v_form_final(IORepos.Analis(datefrom_combox.Text, dateto_combobox.Text));
            form.Show();
        }

        private void exit_but_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

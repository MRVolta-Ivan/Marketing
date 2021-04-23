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
    public partial class Doc_c_form : Form
    {
        PriceRepository IORepos = new PriceRepository();

        public Doc_c_form()
        {
            InitializeComponent();
        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_but_Click(object sender, EventArgs e)
        {
            Doc_c_form_final form = new Doc_c_form_final(IORepos.Analis(datefrom_combox.Text, dateto_combobox.Text));
            form.Show();
        }

        private void Doc_c_form_Load(object sender, EventArgs e)
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
    }
}

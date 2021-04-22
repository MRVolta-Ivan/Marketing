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
        SegmentRepository segments = new SegmentRepository();
        ProductRepository products = new ProductRepository();
        TypeSegmentRepository typeRepos = new TypeSegmentRepository();

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
            List<List<string>> result = new List<List<string>>();
            
            List<Product> prods = products.GetUniqueFromToDate(datefrom_combox.Text, dateto_combobox.Text);

            List<TypeSegment> type = typeRepos.GetUniqueFromToDate(datefrom_combox.Text, dateto_combobox.Text);

            result.Add(new List<string>());
            result[0].Add("");

            for (int i = 0; i < prods.Count; i++)
            {
                result[0].Add(prods[i].name);
            }

            for (int i = 0; i < type.Count; i++)
            {
                result.Add(new List<string>());
                result[i + 1].Add(type[i].name);
                for (int j = 0; j < prods.Count; j++)
                {
                    result[i + 1].Add(IORepos.GetSumSegmentProduct(
                        datefrom_combox.Text,
                        dateto_combobox.Text,
                        prods[j].id,
                        type[i].id));
                }
            }

            Doc_v_form_final form = new Doc_v_form_final(result);
            form.Show();
        }

        private void exit_but_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

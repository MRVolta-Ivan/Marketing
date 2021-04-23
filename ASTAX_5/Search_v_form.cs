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
    public partial class Search_v_form : Form
    {

        InputOutputRepository inputoutput = new InputOutputRepository();
        ProductRepository products = new ProductRepository();
        EdIzmRepository EIzmer = new EdIzmRepository();
        OrgRepository Orgs = new OrgRepository();

        public Search_v_form()
        {
            InitializeComponent();
        }

        private void V_anal_form_Load(object sender, EventArgs e)
        {
            List<List<string>> num_doc = inputoutput.GetUniqNumDoc();
            foreach (List<string> i in num_doc)
                num_doc_combox.Items.Add(i[0]);
            num_doc_combox.Items.Add("");

            List<Org> orgio = Orgs.GetOrgIO();
            orgio.Add(new Org(-1, "", ""));
            org_combox.DataSource = orgio;
            org_combox.DisplayMember = "name";
            org_combox.ValueMember = "id";

            List<Product> productio = products.GetProductIO();
            productio.Add(new Product(-1, "", ""));
            tovar_combobox.DataSource = productio;
            tovar_combobox.DisplayMember = "name";
            tovar_combobox.ValueMember = "id";
        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void search_but_Click(object sender, EventArgs e)
        {
            bool filtr = true;
            string sql = "select * from \"Input_output\"";

            if (num_doc_combox.Text != "")
            {
                if (filtr)
                {
                    sql += " where";
                    filtr = false;
                }
                else
                {
                    sql += " and";
                }
                sql += " \"number_doc\" = '" + num_doc_combox.Text + "'";
            }

            if (org_combox.SelectedValue.ToString() != "-1")
            {
                if (filtr)
                {
                    sql += " where";
                    filtr = false;
                }
                else
                {
                    sql += " and";
                }
                sql += " \"PK_Org\" = " + org_combox.SelectedValue.ToString();
            }

            if (tovar_combobox.SelectedValue.ToString() != "-1")
            {
                if (filtr)
                {
                    sql += " where";
                    filtr = false;
                }
                else
                {
                    sql += " and";
                }
                sql += " \"PK_product\" = " + tovar_combobox.SelectedValue.ToString();
            }

            if (pricefrom_textbox.Text != "")
            {
                if (filtr)
                {
                    sql += " where";
                    filtr = false;
                }
                else
                {
                    sql += " and";
                }
                sql += " \"price_for_one\" > " + pricefrom_textbox.Text; 
            }

            if (priceto_textbox.Text != "")
            {
                if (filtr)
                {
                    sql += " where";
                    filtr = false;
                }
                else
                {
                    sql += " and";
                }
                sql += " \"price_for_one\" < " + priceto_textbox.Text;
            }

            Search_v_table_form form = new Search_v_table_form(inputoutput.Search(sql));
            form.ShowDialog();
        }
    }
}

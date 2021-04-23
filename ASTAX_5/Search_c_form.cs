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
    public partial class Search_c_form : Form
    {
        
        PriceRepository price = new PriceRepository();
        ProductRepository products = new ProductRepository();
        EdIzmRepository EIzmer = new EdIzmRepository();
        OrgRepository Orgs = new OrgRepository();
        public Search_c_form()
        {
            InitializeComponent();
        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void search_but_Click(object sender, EventArgs e)
        {
            bool filtr = true;
            string sql = "select * from \"Price\"";

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
                sql += " \"PK_Product\" = " + tovar_combobox.SelectedValue.ToString();
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

            Search_c_table_form form = new Search_c_table_form(price.Search(sql));
            form.ShowDialog();
        }

        private void Search_c_form_Load(object sender, EventArgs e)
        {

            List<Org> orgio = Orgs.GetOrgIO2();
            orgio.Add(new Org(-1, "", ""));
            org_combox.DataSource = orgio;
            org_combox.DisplayMember = "name";
            org_combox.ValueMember = "id";

            List<Product> productio = products.GetProductIO2();
            productio.Add(new Product(-1, "", ""));
            tovar_combobox.DataSource = productio;
            tovar_combobox.DisplayMember = "name";
            tovar_combobox.ValueMember = "id";
        }
    }
}

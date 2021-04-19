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
            resetTable();
        }

        private void back_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetTable()
        {

            v_anal_table.Rows.Clear();
            List<InputOutput> io = inputoutput.GetAll();

            foreach (InputOutput i in io)
            {
                Product product = products.GetById(i.product);
                EdIzm EI = EIzmer.GetById(i.edizm);
                Org org = Orgs.GetById(i.org);
                v_anal_table.Rows.Add(i.id, i.date, product.name, product.shifr, org.name, i.count, i.price, i.fasovka, EI.name);
            }
        }

        private void clear_but_Click(object sender, EventArgs e)
        {
            resetTable();
            pricefrom_textbox.ResetText();
            priceto_textbox.ResetText();
            dateTimePicker1.ResetText();
            tovar_shifr_comboBox.ResetText();
            fasovka_combox.ResetText();
            tovar_combox.ResetText();
            org_combox.ResetText();
        }

        private void search_but_Click(object sender, EventArgs e)
        {

        }
    }
}

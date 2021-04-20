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
            
        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void search_but_Click(object sender, EventArgs e)
        {
            Search_v_table_form form = new Search_v_table_form(inputoutput.GetAll());
            form.ShowDialog();
        }
    }
}

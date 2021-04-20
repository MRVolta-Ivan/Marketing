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
    public partial class Include_v_form : Form
    {
        InputOutputRepository ioRepos = new InputOutputRepository();
        OrgRepository orgRepos = new OrgRepository();
        EdIzmRepository edizmRepos = new EdIzmRepository();
        ProductRepository productRepos = new ProductRepository();


        public Include_v_form()
        {
            InitializeComponent();
        }

        private void plus_but_Click(object sender, EventArgs e)
        {
            AddIO();
            incude_table.Rows.Clear();
            org_combox.ResetText();
            dateTimePicker.ResetText();
            num_doc_textbox.ResetText();
        }

        private void plus_exit_but_Click(object sender, EventArgs e)
        {
            AddIO();
            Close();
        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Include_v_form_Load(object sender, EventArgs e)
        {
            List<Org> orgs = orgRepos.GetAll();
            List<Product> tovars = productRepos.GetAll();
            List<EdIzm> eizm = edizmRepos.GetAll();

            org_combox.DataSource = orgs;
            org_combox.DisplayMember = "name";
            org_combox.ValueMember = "id";

            tovar_column.DataSource = tovars;
            tovar_column.DisplayMember = "name";
            tovar_column.ValueMember = "id";

            ed_izmer_column.DataSource = eizm;
            ed_izmer_column.DisplayMember = "name";
            ed_izmer_column.ValueMember = "id";
        }

        private void incude_table_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < incude_table.Rows.Count - 1; i++)
            {
                if (incude_table.Rows[i].Cells[0].Value != null)
                    incude_table.Rows[i].Cells[1].Value = productRepos.GetById(Convert.ToInt64(incude_table.Rows[i].Cells[0].Value)).shifr;
            }
        }

        private void AddIO()
        {
            for (int i = 0; i < incude_table.Rows.Count - 1; i++)
            {
                ioRepos.Add(
                    dateTimePicker.Text, 
                    num_doc_textbox.Text,
                    Convert.ToInt64(incude_table.Rows[i].Cells[2].Value),
                    Convert.ToDouble(incude_table.Rows[i].Cells[3].Value),
                    Convert.ToInt64(org_combox.SelectedValue),
                    Convert.ToInt64(incude_table.Rows[i].Cells[0].Value),
                    Convert.ToInt64(incude_table.Rows[i].Cells[4].Value));
            }
        }
    }
}

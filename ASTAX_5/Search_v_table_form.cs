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
    public partial class Search_v_table_form : Form
    {
        private List<InputOutput> list;

        private ProductRepository products = new ProductRepository();
        private OrgRepository orgs = new OrgRepository();
        private EdIzmRepository edizm = new EdIzmRepository();

        public Search_v_table_form(List<InputOutput> ioList)
        {
            InitializeComponent();
            list = ioList;
        }

        private void back_but_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Search_v_table_form_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Org org = orgs.GetById(list[i].org);
                Product prod = products.GetById(list[i].product);
                EdIzm ei = edizm.GetById(list[i].edizm);

                v_anal_table.Rows.Add(
                    list[i].date,
                    list[i].number,
                    prod.name,
                    prod.shifr,
                    org.name,
                    org.shifr,
                    list[i].count,
                    list[i].price,
                    ei.name);
            }
        }
    }
}
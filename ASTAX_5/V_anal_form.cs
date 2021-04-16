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
    public partial class V_anal_form : Form
    {

        InputOutputRepository inputoutput = new InputOutputRepository();

        public V_anal_form()
        {
            InitializeComponent();
        }

        private void V_anal_form_Load(object sender, EventArgs e)
        {
            List<InputOutput> io = inputoutput.GetAll();

            foreach(InputOutput i in io)
            {
                v_anal_table.Rows.Add(i.id, i.date, i.product, 0, i.org, i.count, i.price, i.fasovka, i.edizm);
            }
        }
    }
}

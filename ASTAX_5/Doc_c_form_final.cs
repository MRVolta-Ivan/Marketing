using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASTAX_5
{
    public partial class Doc_c_form_final : Form
    {
        List<List<string>> list;
        public Doc_c_form_final(List<List<string>> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void Doc_c_form_final_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                doc_table.Rows.Add(list[i].ToArray());
            }
        }

        private void save_but_Click(object sender, EventArgs e)
        {

        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

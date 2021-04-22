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
    public partial class Doc_v_form_final : Form
    {
        List<List<string>> list;

        public Doc_v_form_final(List<List<string>> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_but_Click(object sender, EventArgs e)
        {

        }

        private void Doc_v_form_final_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < list[0].Count - 1; i++)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = list[0][i + 1];
                doc_table.Columns.Add(col);
            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                doc_table.Rows.Add(list[i + 1].ToArray());
            }
        }
    }
}

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

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp_Project_deluxe
{
    public partial class f_explore : Form
    {
        string whole;

        public f_explore()
        {
            InitializeComponent();
        }

        private void bn_up_Click(object sender, EventArgs e)
        {
            string toAdd = "Fuck you Sam" + Environment.NewLine;
            whole = whole + toAdd;

            tb_output.Text = whole;
        }

        private void f_explore_Load(object sender, EventArgs e)
        {
            whole = null;
        }
    }
}

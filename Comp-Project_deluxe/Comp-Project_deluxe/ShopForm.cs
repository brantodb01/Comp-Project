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
    public partial class ShopForm : Form
    {
        Dagger a = new Dagger(5);
        Dagger b = new Dagger(10);
        Dagger c = new Dagger(15);
        Dagger d = new Dagger(20);


        public ShopForm()
        {
            InitializeComponent();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            s_txt_1.Text = a.ToString();
        }

        private void s_btn_4_Click(object sender, EventArgs e)
        {
            Game.player.itemAdd(d);
        }

        private void s_btn_3_Click(object sender, EventArgs e)
        {
            Game.player.itemAdd(c);
        }

        private void s_btn_2_Click(object sender, EventArgs e)
        {
            Game.player.itemAdd(b);
        }

        private void s_btn_1_Click(object sender, EventArgs e)
        {
            Game.player.itemAdd(a);
        }

        private void s_txt_title_TextChanged(object sender, EventArgs e)
        {

        }

        private void s_txt_money_TextChanged(object sender, EventArgs e)
        {

        }

        private void buy()
        {


        }

        private void S_btn_exit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void s_txt_1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void s_txt_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void s_txt_3_TextChanged(object sender, EventArgs e)
        {

        }

        private void s_txt_4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

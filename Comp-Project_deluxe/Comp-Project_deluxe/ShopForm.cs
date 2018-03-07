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


        public ShopForm()
        {
            InitializeComponent();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            s_txt_1.Text = Shop.shopItemA.ToString();
            s_txt_2.Text = Shop.shopItemB.ToString();
            s_txt_3.Text = Shop.shopItemC.ToString();
            s_txt_4.Text = Shop.shopItemD.ToString();
        }

        private void s_btn_4_Click(object sender, EventArgs e)
        {
            Game.player.itemAdd(Shop.shopItemD);
        }

        private void s_btn_3_Click(object sender, EventArgs e)
        {
            Game.player.itemAdd(Shop.shopItemC);
        }

        private void s_btn_2_Click(object sender, EventArgs e)
        {
            Game.player.itemAdd(Shop.shopItemB);
        }

        private void s_btn_1_Click(object sender, EventArgs e)
        {
            Game.player.itemAdd(Shop.shopItemA);
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

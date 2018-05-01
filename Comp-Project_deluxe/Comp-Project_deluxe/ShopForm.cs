using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Creates Shop Form
/// </summary>


namespace Comp_Project_deluxe
{
    //adds shop form
    public partial class ShopForm : Form
    {


        public ShopForm()
        {
            InitializeComponent();
        }
        //makes all the shop textboxes display the stats for what Item they are associated with
        private void ShopForm_Load(object sender, EventArgs e)
        {
            s_txt_1.Text = Shop.shopItemA.ToString();
            s_txt_2.Text = Shop.shopItemB.ToString();
            s_txt_3.Text = Shop.shopItemC.ToString();
            s_txt_4.Text = Shop.shopItemD.ToString();
            s_txt_money.Text = Game.player.gold.ToString();
        }
        public void sRefresh()
        {
            s_txt_money.Text = Game.player.gold.ToString(); // refreshes the players gold count as they buy stuff
        }
        //method for buying stuff
        public void buying(Item purchase)
        {
            if (purchase.value <= Game.player.gold) // makes sure the players gold is above the needed amount to purchase
            {
                Game.player.itemAdd(purchase);//calls itemadding method
                Game.player.gold -= purchase.value;//removes gold from pocket
                sRefresh();//calls refresh
            }
        }
        //connects each of the buying buttons with the buying function and passes in which item it corrosponds to
        private void s_btn_4_Click(object sender, EventArgs e)
        {
            buying(Shop.shopItemD);
        }

        private void s_btn_3_Click(object sender, EventArgs e)
        {
            buying(Shop.shopItemC);
        }

        private void s_btn_2_Click(object sender, EventArgs e)
        {
            buying(Shop.shopItemB);
        }

        private void s_btn_1_Click(object sender, EventArgs e)
        {
            buying(Shop.shopItemA);
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
        //closes shop form
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

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
    public partial class battle_r1 : Form
    {
        public battle_r1()
        {
            InitializeComponent();
            B_txt_playerHealth.Text = Game.player.health.ToString();
        }

        public void bRefresh()
        {
            B_txt_playerHealth.Text = Game.player.health.ToString();
        }

        private void B_txt_playerHealth_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void B_txt_output_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_txt_enemyHealth_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_btn_Attack_Click(object sender, EventArgs e)
        {

        }

        private void B_btn_Ranged_Click(object sender, EventArgs e)
        {

        }

        private void B_btn_Inv_Click(object sender, EventArgs e)
        {

        }

        private void B_btn_Escape_Click(object sender, EventArgs e)
        {
            Hide();
            

        }
    }
}

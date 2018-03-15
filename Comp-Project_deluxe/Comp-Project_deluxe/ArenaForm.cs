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
        public Boss occupant = new AppleBoss(Game.INIT_APPLEBOSS_HEALTH, Game.INIT_APPLEBOSS_MELEEDAMAGE, Game.INIT_APPLEBOSS_RANGEDDAMAGE, Game.INIT_APPLEBOSS_ACCURACY);

        public battle_r1()
        {
            InitializeComponent();
            B_txt_playerHealth.Text = Game.player.health.ToString();
            B_txt_enemyHealth.Text = occupant.health.ToString();
        }

        public void bRefresh()
        {
            B_txt_playerHealth.Text = Game.player.health.ToString();
            B_txt_enemyHealth.Text = occupant.health.ToString();
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
            occupant.health -= Game.player.meleeD;
            if (occupant.health >= 400000)
            {
                occupant.health = 0;
            }
            bRefresh();
            if (occupant.myTurnHit() == false)
            {
                B_txt_output.Text += "The Enemy Missed" + Environment.NewLine;
            }
            else
            {
                if (occupant.myTurnWeapon() == 1)
                {
                    B_txt_output.Text += ("The Enemy struck for {0} damage", occupant.meleeDamage;
                }
            }
        }

        private void B_btn_Ranged_Click(object sender, EventArgs e)
        {
            occupant.health -= Game.player.rangedD;
            if (occupant.health >= 400000)
            {
                occupant.health = 0;
            }
            bRefresh();
        }

        private void B_btn_Inv_Click(object sender, EventArgs e)
        {
            new Inventory().Show();
        }

        private void B_btn_Escape_Click(object sender, EventArgs e)
        {
            Hide();
            

        }
    }
}

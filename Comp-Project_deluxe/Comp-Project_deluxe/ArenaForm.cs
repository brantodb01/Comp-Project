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

            if (Game.player.health == 0)
            {
                //open leaderboard
            }
            if (occupant.health == 0)
            {
                //Game.player.score += 
            }
        }

        public void yourTurn(int doctrine)
        {
            if (doctrine == 1)
            {
                occupant.health -= Game.player.meleeD;
                B_txt_output.Text += string.Format("You struck the enemy for {0} damage", Game.player.meleeD) + Environment.NewLine;
            }
            else
            {
                occupant.health -= Game.player.rangedD;
                B_txt_output.Text += string.Format("You struck the enemy for {0} damage", Game.player.rangedD) + Environment.NewLine;
            }
            if (occupant.health >= 400000)
            {
                occupant.health = 0;
            }
            bRefresh();
            enemyTurn();
        }

        public void enemyTurn()
        {
            if (occupant.myTurnHit() == false)
            {
                B_txt_output.Text += "The Enemy Missed" + Environment.NewLine;
            }
            else
            {
                if (occupant.myTurnWeapon() == 1)
                {
                    B_txt_output.Text += string.Format("The Enemy struck for {0} damage", occupant.meleeDamage) + Environment.NewLine;
                    Game.player.health -= occupant.meleeDamage;
                }
                else
                {
                    B_txt_output.Text += string.Format("The Enemy struck for {0} damage", occupant.rangedDamage) + Environment.NewLine;
                    Game.player.health -= occupant.rangedDamage;
                }
            }

            if (Game.player.health >= 400000)
            {
                Game.player.health = 0;
                ScoreDAO ded = new ScoreDAO();
                ded.savePlayerScore(Game.player.userName, Game.player.score);
                new Leaderboard().ShowDialog();
            }

            bRefresh();
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
            
            yourTurn(1);

        }

        private void B_btn_Ranged_Click(object sender, EventArgs e)
        {
            
            yourTurn(2);
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

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
    public partial class Inventory : Form
    {
        Item temp;
        public Inventory()
        {
            InitializeComponent();
        }

        public void iRefresh()
        {
            try
            {

                textBox1.Text = Game.player.inventory[0].ToString();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                textBox1.Text = " ";
            }
            try
            {

                textBox2.Text = Game.player.inventory[1].ToString();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                textBox2.Text = " ";
            }
            try
            {

                textBox3.Text = Game.player.inventory[2].ToString();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                textBox3.Text = " ";
            }
            try
            {

                textBox6.Text = Game.player.inventory[3].ToString();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                textBox6.Text = " ";
            }
            try
            {

                textBox5.Text = Game.player.inventory[4].ToString();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                textBox5.Text = " ";
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            textBox1.Text = Game.player.inventory[0].ToString();
            textBox2.Text = Game.player.inventory[1].ToString();
            textBox3.Text = Game.player.inventory[2].ToString();
            textBox6.Text = Game.player.inventory[3].ToString();
            textBox5.Text = Game.player.inventory[4].ToString();
        }

        private void I_btn_1_Click(object sender, EventArgs e)
        {
            equipItem(0);
        }

        private void I_btn_2_Click(object sender, EventArgs e)
        {
            equipItem(1);
        }

        private void I_btn_3_Click(object sender, EventArgs e)
        {
            equipItem(2);
        }

        private void I_btn_4_Click(object sender, EventArgs e)
        {
            equipItem(3);
        }

        private void I_btn_5_Click(object sender, EventArgs e)
        {
            equipItem(4);
        }

        private void I_btn_6_Click(object sender, EventArgs e)
        {
            removeItem(0);
        }

        private void I_btn_7_Click(object sender, EventArgs e)
        {
            removeItem(1);
        }

        private void I_btn_8_Click(object sender, EventArgs e)
        {
            removeItem(2);
        }

        private void I_btn_9_Click(object sender, EventArgs e)
        {
            removeItem(3);
        }

        private void I_btn_10_Click(object sender, EventArgs e)
        {
            removeItem(4);
        }

        private void removeItem(int index)
        {
            if (Game.player.inventory.Count() > index)
            {
                Game.player.inventory.RemoveAt(index);

                iRefresh();
            }
            
        }
        private void equipItem(int index)
        {
            if (Game.player.inventory.Count() > index)
            {
                if (Game.player.inventory[index] is Melee)
                {
                    if (Game.player.meleeWeapon != null)
                    {
                        temp = Game.player.meleeWeapon;
                    }
                    Game.player.meleeWeapon = (Melee)Game.player.inventory[index];
                    Game.player.inventory.RemoveAt(index);
                    if (temp != null)
                    {
                        Game.player.itemAdd(temp);
                    }
                }

                
                
                iRefresh();
                Game.player.pRefresh();
            }
        }

        private void I_btn_exit_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}

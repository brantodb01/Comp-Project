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
        public Inventory()
        {
            InitializeComponent();
        }

        public void iRefresh(int slotDrop)
        {
            switch (slotDrop)
            { 
                case 0:
                    try
                    {
                        textBox1.Text = Game.player.inventory[0].ToString();
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        textBox1.Text = " ";
                    }
                    break;
                case 1:
                    try
                    {
                        textBox1.Text = Game.player.inventory[1].ToString();
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        textBox1.Text = " ";
                    }
                    break;
                case 2:
                    try
                    {
                        textBox1.Text = Game.player.inventory[2].ToString();
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        textBox1.Text = " ";
                    }
                    break;
                case 3:
                    try
                    {
                        textBox1.Text = Game.player.inventory[3].ToString();
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        textBox1.Text = " ";
                    }
                    break;
                case 4:
                    try
                    {
                        textBox1.Text = Game.player.inventory[4].ToString();
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        textBox1.Text = " ";
                    }
                    break;
            }


            

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            textBox1.Text = Game.player.inventory[0].ToString();
        }

        private void I_btn_1_Click(object sender, EventArgs e)
        {

        }

        private void I_btn_2_Click(object sender, EventArgs e)
        {

        }

        private void I_btn_3_Click(object sender, EventArgs e)
        {

        }

        private void I_btn_4_Click(object sender, EventArgs e)
        {

        }

        private void I_btn_5_Click(object sender, EventArgs e)
        {

        }

        private void I_btn_6_Click(object sender, EventArgs e)
        {
            try
            { 
                Game.player.inventory.RemoveAt(0);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                //nothin' here
            }
            
            iRefresh(0);
        }

        private void I_btn_7_Click(object sender, EventArgs e)
        {
            try
            {
                Game.player.inventory.RemoveAt(1);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                //nothin' here
            }

            iRefresh(1);
        }

        private void I_btn_8_Click(object sender, EventArgs e)
        {
            try
            {
                Game.player.inventory.RemoveAt(2);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                //nothin' here
            }

            iRefresh(2);
        }

        private void I_btn_9_Click(object sender, EventArgs e)
        {
            try
            {
                Game.player.inventory.RemoveAt(3);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                //nothin' here
            }

            iRefresh(3);
        }

        private void I_btn_10_Click(object sender, EventArgs e)
        {
            try
            {
                Game.player.inventory.RemoveAt(4);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                //nothin' here
            }

            iRefresh(4);
        }

        private void I_btn_exit_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}

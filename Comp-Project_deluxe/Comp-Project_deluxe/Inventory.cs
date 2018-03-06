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
            Game.player.inventory.RemoveAt(0);
            Close();
            new Inventory().Show();
        }

        private void I_btn_7_Click(object sender, EventArgs e)
        {
            Game.player.inventory.RemoveAt(1);
            Close();
            new Inventory().Show();
        }

        private void I_btn_8_Click(object sender, EventArgs e)
        {
            Game.player.inventory.RemoveAt(2);
            Close();
            new Inventory().Show();
        }

        private void I_btn_9_Click(object sender, EventArgs e)
        {
            Game.player.inventory.RemoveAt(3);
            Close();
            new Inventory().Show();
        }

        private void I_btn_10_Click(object sender, EventArgs e)
        {
            Game.player.inventory.RemoveAt(4);
            Close();
            new Inventory().Show();
        }

        private void I_btn_exit_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}

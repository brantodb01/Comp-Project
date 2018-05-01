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
/// This is the form for the inventory Menu 
/// </summary>

namespace Comp_Project_deluxe
{
    //creates the Inventory Form
    public partial class Inventory : Form
    {
        Item temp;
        public Inventory()
        {
            InitializeComponent();
        }

        // used to refresh the inventory screen so it displays up to dat information

        public void iRefresh()
        {
            // validates that an inventory slot is occupied so it has something to represent
            try
            {

                textBox1.Text = Game.player.inventory[0].ToString();
            }
            //defaults an inventory slot to blank to show empty
            catch (System.ArgumentOutOfRangeException)
            {
                textBox1.Text = " ";
            }
            try// validates that an inventory slot is occupied so it has something to represent
            {

                textBox2.Text = Game.player.inventory[1].ToString();
            }
            //defaults an inventory slot to blank to show empty
            catch (System.ArgumentOutOfRangeException)
            {
                textBox2.Text = " ";
            }
            try// validates that an inventory slot is occupied so it has something to represent
            {

                textBox3.Text = Game.player.inventory[2].ToString();
            }
            //defaults an inventory slot to blank to show empty
            catch (System.ArgumentOutOfRangeException)
            {
                textBox3.Text = " ";
            }
            try// validates that an inventory slot is occupied so it has something to represent
            {

                textBox6.Text = Game.player.inventory[3].ToString();
            }
            //defaults an inventory slot to blank to show empty
            catch (System.ArgumentOutOfRangeException)
            {
                textBox6.Text = " ";
            }
            try// validates that an inventory slot is occupied so it has something to represent
            {

                textBox5.Text = Game.player.inventory[4].ToString();
            }
            //defaults an inventory slot to blank to show empty
            catch (System.ArgumentOutOfRangeException)
            {
                textBox5.Text = " ";
            }
        }

        //makes each text box display which item it represents

        private void Inventory_Load(object sender, EventArgs e)
        {
            textBox1.Text = Game.player.inventory[0].ToString();
            textBox2.Text = Game.player.inventory[1].ToString();
            textBox3.Text = Game.player.inventory[2].ToString();
            textBox6.Text = Game.player.inventory[3].ToString();
            textBox5.Text = Game.player.inventory[4].ToString();
        }

        // If Any of the Equip buttons are pressed calls the equip method and gives which inv slot is being equipped

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

        // If Any of the Drop buttons are pressed calls the Remove method and gives which inv slot is being dropped

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

        //used to drop/delete an item

        private void removeItem(int index)
        {
            if (Game.player.inventory.Count() > index)
            {
                Game.player.inventory.RemoveAt(index);

                iRefresh();
            }
            
        }

        // is used to equip an item when the equip function is called

        private void equipItem(int index)
        {
            if (Game.player.inventory.Count() > index)
            {
                if (Game.player.inventory[index] is Melee) // checks equip item is a melee weapon
                {
                    if (Game.player.meleeWeapon != null) // checks if something is already equipped
                    {
                        temp = Game.player.meleeWeapon; // temp store for pre equipped item
                    }
                    Game.player.meleeWeapon = (Melee)Game.player.inventory[index]; // adds weapon to be equipped to equip slot
                    Game.player.inventory.RemoveAt(index); // removes weapon being equipped from inv
                    if (temp != null) // checks if an item is in temp
                    {
                        Game.player.itemAdd(temp); // adds previously equipped item to inventory
                    }
                }

                
                
                iRefresh();
                Game.player.pRefresh();
            }
        }
        
        // closes the inventory

        private void I_btn_exit_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Comp_Project_deluxe.Game;

namespace Comp_Project_deluxe
{
    public class Player
    {
        public List<Item> inventory { get; }
        public uint health { get; set; }
        public uint meleeD { get; set; }
        public uint rangedD { get; set; }
        public Item meleeWeapon { get; set; }
        public Item rangedWeapon { get; set; }
        public Item armourWearing { get; set; }

        public Player(uint health, uint meleeD, uint rangedd)
        {
            inventory = new List<Item>();
            this.health = health;
            this.meleeD = meleeD;
            this.rangedD = rangedd;
        }

        public void pRefresh()
        {

        }

        public void itemAdd(Item item)
        {
            if (inventory.Count >= 5)
            {
                MessageBox.Show("Inventory is Full");
            }
            else
            {
                inventory.Add(item);
            }
            
        }

    }
}

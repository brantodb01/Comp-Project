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
        public Melee meleeWeapon { get; set; }
        public Ranged rangedWeapon { get; set; }
        public Item armourWearing { get; set; }
        public uint gold { get; set; }
        public uint score { get; set; }
        public string userName { get; set; }

        public Player(uint health, uint meleeD, uint rangedd, uint gold, string userName)
        {
            inventory = new List<Item>();
            this.health = health;
            this.meleeD = meleeD;
            this.rangedD = rangedd;
            this.gold = gold;
            this.userName = userName;
        }

        public void pRefresh()
        {
            if (meleeWeapon != null)
            {
                this.meleeD = meleeWeapon.Mdamage;
            }
            else
            {
                this.meleeD = INIT_PLAYER_MELEED;
            }
            if (rangedWeapon != null)
            {
                this.rangedD = rangedWeapon.Rdamage;
            }
            else
            {
                this.rangedD = INIT_PLAYER_RANGEDD;
            }
            
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

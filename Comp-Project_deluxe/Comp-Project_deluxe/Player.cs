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

/// <summary>
/// Creates the player class and establishes all of thir attributes
/// </summary>
namespace Comp_Project_deluxe
{
    // creates player class
    public class Player
    {
        //makes all of the player's attributes
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

        //constructs a player
        public Player(uint health, uint meleeD, uint rangedd, uint gold, string userName)
        {
            inventory = new List<Item>();
            this.health = health;
            this.meleeD = meleeD;
            this.rangedD = rangedd;
            this.gold = gold;
            this.userName = userName;
        }
        //refreshes a players stats when equipment changes
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
        //manages the player's inventory and ensures it doesn't overflow
        public void itemAdd(Item item)
        {
            if (inventory.Count >= 5) // checks the inventory isn't full
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

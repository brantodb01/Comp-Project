using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp_Project_deluxe
{
    public class Player
    {
        public List<Item> inventory { get; }
        public uint health { get; set; }

        public Player(uint health)
        {
            inventory = new List<Item>();
            this.health = health;
        }

        public void itemAdd(Item item)
        {
            inventory.Add(item);
        }
    }
}

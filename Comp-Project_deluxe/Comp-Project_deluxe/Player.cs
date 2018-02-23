using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp_Project_deluxe
{
    class Player
    {
        private List<Item> inventory = new List<Item>();
        private uint health;

        public Player(uint health)
        {
            this.health = health;
        }
    }
}

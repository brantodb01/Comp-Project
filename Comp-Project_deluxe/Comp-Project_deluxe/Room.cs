using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp_Project_deluxe
{
    class Room
    {
        public List<Item> items { get; set; }
        public Room aboveNeighbour { get; set; }
        public Room belowNeighbour { get; set; }
        public Room leftNeighbour { get; set; }
        public Room rightNeighbour { get; set; }

        public Room()
        {
            this.items = new List<Item>();
        }

        // Returns true if this room has a neighbour in the said location, else false
        public bool hasNeighbour(Direction location)
        {
            switch (location)
            {
                case Direction.UP: return aboveNeighbour != null;
                case Direction.DOWN: return belowNeighbour != null;
                case Direction.LEFT: return leftNeighbour != null;
                case Direction.RIGHT: return rightNeighbour != null;
            }

            throw new Exception("It's gone to shit");
        }

        public override string ToString()
        {
            return string.Format(
                "Room [numItems={0}, aboveNeighbour={1}, belowNeighbout={2}, leftNeighbout={3}, rightNeighbour={4}]",
                items.Count(), hasNeighbour(Direction.UP), hasNeighbour(Direction.DOWN), hasNeighbour(Direction.LEFT), 
                hasNeighbour(Direction.RIGHT));
        }
    }
}
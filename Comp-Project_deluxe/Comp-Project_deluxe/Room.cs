using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Comp_Project_deluxe.Game;


/// <summary>
/// Establishes the Room class
/// </summary>
namespace Comp_Project_deluxe
{
    public class Room
    {
        // Gives each room the attributes for its neighbours

        public List<Item> items { get; set; }
        public Room aboveNeighbour { get; set; }
        public Room belowNeighbour { get; set; }
        public Room leftNeighbour { get; set; }
        public Room rightNeighbour { get; set; }

        // Returns true if this room has a neighbour in the said location, else false
        // validation for if a room is located there
        public bool hasNeighbour(Orientation location)
        {
            switch (location)
            {
                case Orientation.UP: return aboveNeighbour != null;
                case Orientation.DOWN: return belowNeighbour != null;
                case Orientation.LEFT: return leftNeighbour != null;
                case Orientation.RIGHT: return rightNeighbour != null;
            }
            throw new Exception("magic");
        }

        // returns the rom which is neighbouring in a particular direction

        public Room getNeighbour(Orientation location)
        {
            switch (location)
            {
                case Orientation.UP: return aboveNeighbour;
                case Orientation.DOWN: return belowNeighbour;
                case Orientation.LEFT: return leftNeighbour;
                case Orientation.RIGHT: return rightNeighbour;
            }
            throw new Exception("magic");
        }

        // overrides the string for each room to include the information about it

        public override string ToString()
        {
            return string.Format(
                "Room [numItems={0}, aboveNeighbour={1}, belowNeighbour={2}, leftNeighbour={3}, rightNeighbour={4}]",
                items.Count(), hasNeighbour(Orientation.UP), hasNeighbour(Orientation.DOWN), hasNeighbour(Orientation.LEFT), 
                hasNeighbour(Orientation.RIGHT));
        }

        // Links a and b together.
        // used to link rooms together so they have neighbours
        public void addNeighbour(Room b, Orientation orientation)
        {
            switch (orientation)
            {
                case Orientation.UP:
                    aboveNeighbour = b;
                    b.belowNeighbour = this;
                    break;
                case Orientation.DOWN:
                    belowNeighbour = b;
                    b.aboveNeighbour = this;
                    break;
                case Orientation.LEFT:
                    leftNeighbour = b;
                    b.rightNeighbour = this;
                    break;
                case Orientation.RIGHT:
                    rightNeighbour = b;
                    b.leftNeighbour = this;
                    break;
            }
        }






    }
}
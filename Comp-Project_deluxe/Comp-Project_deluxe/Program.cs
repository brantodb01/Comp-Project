using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp_Project_deluxe
{
    // Directions the player can move
    public enum Direction { UP, DOWN, LEFT, RIGHT}

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new f_explore());*/

            Room r1 = new Room();
            Room r2 = new Room();
            Room r3 = new Room();
            Room r4 = new Room();
            Room r5 = new Room();
            Room r6 = new Room();
            Room r7 = new Room();
            Room r8 = new Room();

            addRoom(r1, r2, Direction.RIGHT);
            addRoom(r2, r3, Direction.RIGHT);
            addRoom(r2, r4, Direction.UP);
            addRoom(r4, r5, Direction.UP);
            addRoom(r5, r6, Direction.LEFT);
            addRoom(r5, r7, Direction.RIGHT);
            addRoom(r5, r8, Direction.UP);

            r1.items.Add(new Dagger(12));
            MessageBox.Show(r1.ToString());
        }

        // Links a and b together.
        static void addRoom(Room a, Room b, Direction location)
        {
            switch (location)
            {
                case Direction.UP:
                    a.aboveNeighbour = b;
                    b.belowNeighbour = a;
                    break;
                case Direction.DOWN:
                    a.belowNeighbour = b;
                    b.aboveNeighbour = a;
                    break;
                case Direction.LEFT:
                    a.leftNeighbour = b;
                    b.rightNeighbour = a;
                    break;
                case Direction.RIGHT:
                    a.rightNeighbour = b;
                    b.leftNeighbour = a;
                    break;
            }
        }
    }
}

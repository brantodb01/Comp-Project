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
    // Out 'main class'
    public partial class Game : Form
    {
        public enum Orientation { UP, DOWN, LEFT, RIGHT }

        const uint INIT_PLAYER_HEALTH = 100;

        Player player; // Our player
        Room currRoom; // The current room we're in

        public Game()
        {
            InitializeComponent();

            player = new Player(INIT_PLAYER_HEALTH);
            Room r1 = new Room();
            Room r2 = new Room();
            Room r3 = new Room();
            Room r4 = new Room();
            Room r5 = new Room();
            Room r6 = new Room();
            Room r7 = new Room();
            Room r8 = new Room();

            addRoom(r1, r2, Orientation.RIGHT);
            addRoom(r2, r3, Orientation.RIGHT);
            addRoom(r2, r4, Orientation.UP);
            addRoom(r4, r5, Orientation.UP);
            addRoom(r5, r6, Orientation.LEFT);
            addRoom(r5, r7, Orientation.RIGHT);
            addRoom(r5, r8, Orientation.UP);

            currRoom = r2;
        }

        // Links a and b together.
        void addRoom(Room a, Room b, Orientation orientation)
        {
            switch (orientation)
            {
                case Orientation.UP:
                    a.aboveNeighbour = b;
                    b.belowNeighbour = a;
                    break;
                case Orientation.DOWN:
                    a.belowNeighbour = b;
                    b.aboveNeighbour = a;
                    break;
                case Orientation.LEFT:
                    a.leftNeighbour = b;
                    b.rightNeighbour = a;
                    break;
                case Orientation.RIGHT:
                    a.rightNeighbour = b;
                    b.leftNeighbour = a;
                    break;
            }
        }

        private void f_explore_Load(object sender, EventArgs e) {}

        // 
        bool isValidMove(Orientation orientation)
        {
            // check if user move is valid t if yes f if no
        }

        private void move(Orientation orientation)
        {
            if (isValidMove(orientation))
            {
                // Do stuff
            }
            else
            {
                // Moan
            }
        }

        private void bn_up_Click(object sender, EventArgs e)
        {
            
        }

        private void bn_right_Click(object sender, EventArgs e)
        {

        }

        private void bn_down_Click(object sender, EventArgs e)
        {

        }

        private void bn_left_Click(object sender, EventArgs e)
        {

        }
    }
}

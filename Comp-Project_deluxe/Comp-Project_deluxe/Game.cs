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
    // Out 'main class'
    public partial class Game : Form
    {
        public enum Orientation { UP, DOWN, LEFT, RIGHT }

        const uint INIT_PLAYER_HEALTH = 100; 
        public static Player player; // Our player
        Room currRoom; // The current room we're in
        Panel currPanel; // The current panel we've highlighted (representing the room we're in)
        Room  r2, r5, r9;
        Shop r4, r8, r12;
        Arena r1, r3, r6, r7, r10, r11, r13;
        Dictionary<Room, Panel> panelDictionary = new Dictionary<Room, Panel>();
        Room lastRoom;
        ShopForm Shop = new ShopForm();

        public Game()
        {
            InitializeComponent();

            player = new Player(INIT_PLAYER_HEALTH);
            r1 = new Arena();
            r2 = new Room();
            r3 = new Arena();
            r4 = new Shop();
            r5 = new Room();
            r6 = new Arena();
            r7 = new Arena();
            r8 = new Shop();
            r9 = new Room();
            r10 = new Arena();
            r11 = new Arena();
            r12 = new Shop();
            r13 = new Arena();

            r1.addNeighbour(r2, Orientation.RIGHT);
            r2.addNeighbour(r3, Orientation.RIGHT);
            r2.addNeighbour(r4, Orientation.UP);
            r4.addNeighbour(r5, Orientation.UP);
            r5.addNeighbour(r6, Orientation.LEFT);
            r5.addNeighbour(r7, Orientation.RIGHT);
            r5.addNeighbour(r8, Orientation.UP);
            r8.addNeighbour(r9, Orientation.UP);
            r9.addNeighbour(r10, Orientation.LEFT);
            r9.addNeighbour(r11, Orientation.RIGHT);
            r9.addNeighbour(r12, Orientation.UP);
            r12.addNeighbour(r13, Orientation.UP);

            currRoom = r2;

            panelDictionary.Add(r1, E_pnl_room1);
            panelDictionary.Add(r2, E_pnl_room2);
            panelDictionary.Add(r3, E_pnl_room3);
            panelDictionary.Add(r4, E_pnl_room4);
            panelDictionary.Add(r5, E_pnl_room5);
            panelDictionary.Add(r6, E_pnl_room6);
            panelDictionary.Add(r7, E_pnl_room7);
            panelDictionary.Add(r8, E_pnl_room8);
            panelDictionary.Add(r9, E_pnl_room9);
            panelDictionary.Add(r10, E_pnl_room10);
            panelDictionary.Add(r11, E_pnl_room11);
            panelDictionary.Add(r12, E_pnl_room12);
            panelDictionary.Add(r13, E_pnl_room13);


            currPanel = (Panel)Controls.Find("E_pnl_room2", true)[0];
            currPanel.BackColor = Color.Black; // Set the starting room's background colour to black

        }


        private void f_explore_Load(object sender, EventArgs e) {}

        // 
        bool isValidMove(Orientation orientation)
        {
            // check if user move is valid t if yes f if no
            //return true; // QWFX
            return currRoom.hasNeighbour(orientation);
        }


        private void updateRoomPanel()
        {
            //Panel panel = (Panel)Controls.Find("pnl_room3", true)[0];
            panelDictionary[lastRoom].BackColor = Color.Transparent; // Set the old room's background to nothing
            panelDictionary[currRoom].BackColor = Color.Black;

        }

        private void move(Orientation orientation)
        {
            if (isValidMove(orientation))
            {
                // Do stuff
                lastRoom = currRoom;
                currRoom = currRoom.getNeighbour(orientation);
                updateRoomPanel();
            }
            else
            {
                // Moan
            }
            
            // if the room is a shop opens its shop form

            if (currRoom.GetType() == typeof(Shop)) 
            {
                ((Shop)currRoom).vShop.ShowDialog();
            }

            // if the room is a shop opens its shop form

            if (currRoom.GetType() == typeof(Arena))
            {
                ((Arena)currRoom).vArena.ShowDialog();
            }
        }
       
        private void E_btn_up_Click(object sender, EventArgs e)
        {
            move(Orientation.UP);
        }

        private void E_btn_right_Click(object sender, EventArgs e)
        {
            move(Orientation.RIGHT);
        }

        private void E_btn_down_Click(object sender, EventArgs e)
        {
            move(Orientation.DOWN);
        }

        private void E_btn_left_Click(object sender, EventArgs e)
        {
            move(Orientation.LEFT);
        }

        private void pnl_room2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_room12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void E_btn_inventory_Click(object sender, EventArgs e)
        {
            new Inventory().Show();
        }
    }
}

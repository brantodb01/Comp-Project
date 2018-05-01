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
    /// <summary>
    /// Creates the main Menu to show either the leaderboard 
    /// start a new game and provide a name
    /// </summary>
    
    //creates the menu as a subclass of Form
    public partial class Menu : Form
    {
        // creates classes that would be used depending on the chosen option
        public Game Play;
        public Leaderboard scoreBoard;
        public Menu()
        {
            InitializeComponent(); // starts the program
        }

        //starts a new game and pulls the input name 
        private void M_btn_play_Click(object sender, EventArgs e)
        {
            string Name = M_txt_name.Text; //takes input name
            Play = new Game(Name);
            Hide(); // hides main menu
            Play.Show(); // shows Explore Form
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Shows leaderboard

        private void M_btn_leaderboard_Click(object sender, EventArgs e)
        {
            scoreBoard = new Leaderboard();
            scoreBoard.ShowDialog();
        }
    }
}

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
    public partial class Menu : Form
    {

        Game Play;
        Leaderboard scoreBoard;
        public Menu()
        {
            InitializeComponent();
        }

        private void M_btn_play_Click(object sender, EventArgs e)
        {
            string Name = M_txt_name.Text;
            Play = new Game(Name);
            Hide();
            Play.Show();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void M_btn_leaderboard_Click(object sender, EventArgs e)
        {
            scoreBoard = new Leaderboard();
            scoreBoard.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Creates the leaderboard form
/// </summary>
namespace Comp_Project_deluxe
{
    //leaderboard form made
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //closes form
        private void L_btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'cSProjDataSet.PlayerScore' table.
            this.playerScoreTableAdapter.Fill(this.cSProjDataSet.PlayerScore);

        }
        
    }
}

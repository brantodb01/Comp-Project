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
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void L_btn_exit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSProjDataSet.PlayerScore' table. You can move, or remove it, as needed.
            this.playerScoreTableAdapter.Fill(this.cSProjDataSet.PlayerScore);

        }
    }
}

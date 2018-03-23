using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Comp_Project_deluxe
{
    class ScoreDAO
    {
        string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["CSProj.Properties.Settings.connStr"].ConnectionString;

        public void savePlayerScore(Player player, uint score)
        
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                SqlCommand add = new SqlCommand();

               /* string command = "SELECT playerUsername FROM Players";

                SqlCommand cmd = new SqlCommand(command, connection);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MessageBox.Show(reader.GetString(0));
                }
                */



                connection.Close();
            }
        }

        public List<string> findTopNScores(uint n)
        {
            return null;
        }
    }
}

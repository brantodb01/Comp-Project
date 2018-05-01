using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Transactions;
/// <summary>
/// Handles the Database
/// </summary>
namespace Comp_Project_deluxe
{
    //Creates class ScoreDATA-ACCESS-OBJECTS
    class ScoreDAO
    {
        //connection string to database
        string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["CSProj.Properties.Settings.connStr"].ConnectionString;
        string add;
        string Sscore;
        //method for saving plyer score
        public void savePlayerScore(string userName, uint score)
        
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open(); // opens conection
                // creates SQL code in one variable
                add = "INSERT PlayerScore ([playerUsername], [Score]) VALUES (@userName, @score)"; 

                /* string command = "SELECT playerUsername FROM Players";

                 SqlCommand cmd = new SqlCommand(command, connection);

                 SqlDataReader reader = cmd.ExecuteReader();

                 while (reader.Read())
                 {
                     MessageBox.Show(reader.GetString(0));
                 }
                 */

                

                Sscore = score.ToString();
                //peerforms the save
                using (SqlCommand cmd = new SqlCommand(add, connection))
                {
                    cmd.Parameters.AddWithValue("@userName", userName);//saves username
                    cmd.Parameters.AddWithValue("@score", Sscore);//saves score
                    cmd.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}

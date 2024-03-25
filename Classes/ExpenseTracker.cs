using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Project.Classes
{
    internal class ExpenseTracker : ShowChartFactory
    {

        DBCONNECTOR con;
        public ExpenseTracker()
        {
           con = new DBCONNECTOR();
        }


        // check for duplicate user
        public int duplicateUser(string username)
        {
            int result = 0;

            try
            {
                MySqlCommand mysqlcmd = new MySqlCommand("SELECT * FROM users WHERE username=@Name");

                mysqlcmd.Connection = con.GetConnection();
                con.OpenConnection();
                mysqlcmd.Parameters.AddWithValue("@Name", username);
                MySqlDataReader dr = mysqlcmd.ExecuteReader();

                if (dr.Read())
                {
                    con.CloseConnection();
                    result = 1;
                }
                else
                {
                    con.CloseConnection();
                    result = 0;
                }
            }

            catch (MySqlException ex)
            {

                if (ex.Number == 1042)
                {
                    MessageBox.Show("You Need to Connect the Database!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.CloseConnection();
                    Environment.Exit(0);
                }
            }
            return result;
        }


        // show data in the barchart
        public override int showChart(string mth, int uid, string cate)
        {            
            MySqlCommand mysqlcmd = new MySqlCommand("SELECT sum(cost) FROM expense WHERE userid=@uid AND month=@mth AND category=@cate;");
            mysqlcmd.Connection = con.GetConnection();
            mysqlcmd.Parameters.AddWithValue("@uid", uid);
            mysqlcmd.Parameters.AddWithValue("@mth", mth);
            mysqlcmd.Parameters.AddWithValue("@cate", cate);
            con.OpenConnection();

            // if the data is empty, show nothing
            if (!String.IsNullOrEmpty(mysqlcmd.ExecuteScalar().ToString()))
            {
                int total_cost = Convert.ToInt32(mysqlcmd.ExecuteScalar());
                con.CloseConnection();
                return total_cost;
            }
            else
            {
                con.CloseConnection();
                return -1;
            }
        }
    }
}

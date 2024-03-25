using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Project.Classes
{
    internal class ExpenseCategory
    {

        // create object to get database connection
        DBCONNECTOR con = new DBCONNECTOR();


        // get all data in the expense database
        public DataTable retrieveExpense(int uId, string cate)
        {
            MySqlCommand mysqlcmd = new MySqlCommand("SELECT expid AS ExpenseId, month AS Month, payment AS Payment, cost AS Cost, description AS Description FROM expense WHERE userid=@uid AND category=@cate;", con.GetConnection());
            mysqlcmd.Connection = con.GetConnection();
            mysqlcmd.Parameters.AddWithValue("@uid", uId);
            mysqlcmd.Parameters.AddWithValue("@cate", cate);
            MySqlDataAdapter adapter = new MySqlDataAdapter(mysqlcmd);
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = mysqlcmd;
            adapter.Fill(dataTable);
            return dataTable;
        }


        // add new expense in the database 
        public bool addExpense(string month, int cost, string payment, string description, string cate, int uId)
        {

            bool result = false;

            MySqlCommand mysqlcmd = new MySqlCommand();
            string query = "INSERT INTO expense (userid,month,payment,cost,description,category) VALUES (@uid,@mth,@ptype,@cost,@desc,@cate);";
            mysqlcmd.CommandText = query;
            mysqlcmd.Connection = con.GetConnection();
            mysqlcmd.Parameters.AddWithValue("@uid", uId);
            mysqlcmd.Parameters.AddWithValue("@mth", month);
            mysqlcmd.Parameters.AddWithValue("@ptype", payment);
            mysqlcmd.Parameters.AddWithValue("@cost", cost);
            mysqlcmd.Parameters.AddWithValue("@desc", description);
            mysqlcmd.Parameters.AddWithValue("@cate", cate);
            con.OpenConnection();

            if (mysqlcmd.ExecuteNonQuery() == 1)
            {
                con.CloseConnection();
                result = true;

            }
            else
            {
                con.CloseConnection();
                result = false;

            }
            return result;

        }


        // update expense in the database
        public bool updateExpense(string month, int cost, string payment, string description, string cate, int eId)
        {
            MySqlCommand mysqlcmd = new MySqlCommand();
            string query = "UPDATE expense SET month=@month,payment=@payment,cost=@cost,description=@description,category=@cate WHERE expid=@eId;";
            mysqlcmd.CommandText = query;
            mysqlcmd.Connection = con.GetConnection();
            mysqlcmd.Parameters.AddWithValue("@month", month);
            mysqlcmd.Parameters.AddWithValue("@payment", payment);
            mysqlcmd.Parameters.AddWithValue("@cost", cost);
            mysqlcmd.Parameters.AddWithValue("@description", description);
            mysqlcmd.Parameters.AddWithValue("@cate", cate);
            mysqlcmd.Parameters.AddWithValue("@eId", eId);
            con.OpenConnection();

            if (mysqlcmd.ExecuteNonQuery() == 1)
            {
                con.CloseConnection();
                return true;

            }
            else
            {
                con.CloseConnection();
                return false;
            }

        }


        // delete expense in database
        public bool deleteExpense(int eId)
        {
            bool res = false;
            MySqlCommand mysqlcmd = new MySqlCommand("DELETE FROM expense WHERE expid=@eId;");
            mysqlcmd.Connection = con.GetConnection();
            mysqlcmd.Parameters.AddWithValue("@eId", eId);
            try
            {
                con.OpenConnection();

                int rowsAffected = mysqlcmd.ExecuteNonQuery();
                if (rowsAffected >= 1)
                {
                    res = true; // Set result to true if at least one row was affected
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                // You can also log the error for further analysis
            }
            finally
            {
                con.CloseConnection();
            }
            return res;
        }

    }
}

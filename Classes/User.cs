using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Project.Classes
{
    internal class User : UserFactory
    {

        DBCONNECTOR con = new DBCONNECTOR();


        // private variable for username and password
        public string username { get; set; }
        public string password { get; set; }


        // retrive the userid of the current user
        public override int getUser(string uname, string pass)
        {
            this.username = uname;
            this.password = pass;

            MySqlCommand mysqlcmd = new MySqlCommand("SELECT userid FROM users WHERE username=@Name and password=@Password");
            mysqlcmd.Connection = con.GetConnection();
            mysqlcmd.Parameters.AddWithValue("@Name", this.username);
            mysqlcmd.Parameters.AddWithValue("@Password", this.password);
            con.OpenConnection();
            int id = Convert.ToInt32(mysqlcmd.ExecuteScalar());
            con.CloseConnection();
            return id;
        }


        // check valid user or not
        public bool loginUser(string uName, string uPassword)
        {

            bool result = false;

            try
            {
                MySqlCommand mysqlcmd = new MySqlCommand("SELECT * FROM users WHERE username=@Name and password=@Password;");

                mysqlcmd.Connection = con.GetConnection();
                con.OpenConnection();
                mysqlcmd.Parameters.AddWithValue("@Name", uName);
                mysqlcmd.Parameters.AddWithValue("@Password", uPassword);
                MySqlDataReader dr = mysqlcmd.ExecuteReader();

                if (dr.Read())
                {
                    con.CloseConnection();
                    result = true;
                }
                else
                {
                    con.CloseConnection();
                    result =  false;
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


        // register the user
        public bool registerUser(string uName, string uPassword)
        {
            bool result = false;

            MySqlCommand mysqlcmd = new MySqlCommand();
            string query = "INSERT INTO users (username,password) VALUES (@uName,@uPassword);";
            mysqlcmd.CommandText = query;
            mysqlcmd.Connection = con.GetConnection();
            mysqlcmd.Parameters.AddWithValue("@uName", uName);
            mysqlcmd.Parameters.AddWithValue("@uPassword", uPassword);
            con.OpenConnection();

            if (mysqlcmd.ExecuteNonQuery() == 0)
            {
                con.CloseConnection();
                result = false;
            }
            else
            {
                con.CloseConnection();
                result = true;
            }
            return result;
        }
    }
}

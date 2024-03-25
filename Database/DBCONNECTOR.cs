using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Project
{
    class DBCONNECTOR
    {
        public MySqlConnection mySqlConnection;

        // change the database information
        private string db_info = "datasource=localhost;port=3306;username=root;password=;database=expense_tracker";
        public DBCONNECTOR()
        {
            try
            {
                mySqlConnection = new MySqlConnection(db_info);

            }
            catch (Exception error_message)
            {
                MessageBox.Show($"error occur : {error_message.Message}");
            }
        }

        public MySqlConnection GetConnection()
        {
            return mySqlConnection;
        }

        public void OpenConnection()
        {
            mySqlConnection.Open();
        }
        public void CloseConnection()
        {
            mySqlConnection.Close();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;

namespace Tracker
{
    class connection
    {

        private MySqlConnection con;
        private string server;
        private string pass;
        private string db;
        private string user;

       
        public connection()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            db = "pharmacy";
            user = "root";
            pass = "";
            string connectionString;
            connectionString = "Data Source=" + server + ";Database=" + db + ";User Id=" + user + "Password=" + pass + ";SSL Mode=0";
            con = new MySqlConnection(connectionString);

        }
            
        public bool OpenConnection()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connnect to server. Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;

                }
                return false;
            }
        }

        public void close_conn()
        {
            this.con.Close();
        }

        public MySqlConnection get_connection()
        {
            return this.con;
        }
    }

}

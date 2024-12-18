using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataStrucAndAlgo
{
    public static class DatabaseManager
    {
        private static string server = "localhost";
        private static string databaseName = "banking_app";
        private static string connectionString = String.Format("Server={0};Database={1};Uid=root;", server, databaseName);
        private static MySqlConnection connection = new MySqlConnection(connectionString);

        // i co-connect dun sa database
        public static bool OpenDatabaseConnection()
        {
            try
            {
                // i check kung naka close yung connection sa database, if oo then i open lang
                if(ConnectionState.Closed == connection.State) connection.Open();
                return true; // return true kapag succesful yung connection
            } catch(Exception e)
            {
                MessageBox.Show("Cannot established connection to the database, Plase check if the database is running.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true; // return false naman kapag hindi succesful yung connection
            }
        }
    }
}

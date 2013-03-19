using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IllBeThere
{
    class DatabaseConnectivity
    {

        

        private static DatabaseConnectivity instance;
        private SqlConnection connection;
        private string connectionString;

        public static DatabaseConnectivity GetInstance
        {
            get
            {
                if (instance == null) instance = new DatabaseConnectivity();
                return instance;
            }
        }

        private DatabaseConnectivity()
        {
            Initialize();
        }

        private void Initialize()
        {
            //load info about databases and apps into dictionary here
        }

        private bool Connect()
        {
            connectionString = "Server=mysql.itu.dk;Database=Secret;UID=temp;password=temp";
            connection = new SqlConnection(connectionString);
            try
            {
                if (connection.State != System.Data.ConnectionState.Open) connection.Open();
                Console.WriteLine("works");
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }

        public bool CloseConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed) { connection.Close(); return true; }
            else return false;
        }

        private void ExecuteQuery(string query)
        {
            if (connection.State != System.Data.ConnectionState.Open) Connect();
            if (connection.State != System.Data.ConnectionState.Open) ErrorMessage("Cannot open connection to server");
            else
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        private SqlDataReader ExecuteReader(string query, string database)
        {
            if (connection.State != System.Data.ConnectionState.Open) Connect();
            if (connection.State != System.Data.ConnectionState.Open) ErrorMessage("Cannot open connection to server");
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    //CloseConnection();
                    return reader;
                }
                catch (SqlException e) { ErrorMessage(e.ToString()); }
            }
            return null;
        }

        private void ErrorMessage(string s)
        {
            Console.Write(s);
        }

//***************************************************** CREATE *********************************************************
        public bool CreateBar()
        {
            return false;
        }

        public bool CreateUser()
        {
            return false;
        }

        public bool CreateAdditionalInfo()
        {
            return false;
        }

        public bool CreateOpeningHours()
        {
            return false;
        }

        public bool CreateSpecialDeals()
        {
            return false;
        }
//**********************************************************************************************************************
//***************************************************** READ/GET (single) **********************************************
        public bool GetSingleBar()
        {
            return false;
        }

        public bool GetSingleUser()
        {
            return false;
        }

        public bool GetSingleAdditionalInfo()
        {
            return false;
        }

        public bool GetSingleOpeningHours()
        {
            return false;
        }

        public bool GetSingleSpecialDeals()
        {
            return false;
        }
//**********************************************************************************************************************

    }
}

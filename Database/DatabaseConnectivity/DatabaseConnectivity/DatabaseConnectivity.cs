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
        private enum Table { Bar="bartable", User="usertable", AdditionalInfo="add_info", OpeningHours="open_hours", SpecialDeals="spec_deal"}

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
        public bool CreateBar(Bar bar)
        {
            string query ="INSERT INTO "+Table.Bar+" (name, address, image, user, add_info, spec_deal, openings) Values()";
            return false;
        }

        public bool CreateUser(User user)
        {
            return false;
        }

        public bool CreateAdditionalInfo(AdditionalInfo addInfo)
        {
            return false;
        }

        public bool CreateOpeningHours(OpeningHours openHours)
        {
            return false;
        }

        public bool CreateSpecialDeals(SpecialDeal specialDeal)
        {
            return false;
        }
//**********************************************************************************************************************
//***************************************************** READ/GET (List) ************************************************
        public bool GetBar(List<Bar> bars)
        {
            return false;
        }

        public bool GetUser(List<User> user)
        {
            return false;
        }

        public bool GetAdditionalInfo()
        {
            return false;
        }

        public bool GetOpeningHours()
        {
            return false;
        }

        public bool GetSpecialDeals()
        {
            return false;
        }
//**********************************************************************************************************************
//***************************************************** UPDATE/EDIT ****************************************************
        public bool UpdateBar()
        {
            return false;
        }

        public bool UpdateUser()
        {
            return false;
        }

        public bool UpdateAdditionalInfo()
        {
            return false;
        }

        public bool UpdateOpeningHours()
        {
            return false;
        }

        public bool UpdateSpecialDeals()
        {
            return false;
        }
//**********************************************************************************************************************
//***************************************************** DELETE (List) **************************************************
        public bool DeleteBar(List<Bar> bars)
        {
            return false;
        }

        public bool DeleteUser()
        {
            return false;
        }

        public bool DeleteAdditionalInfo()
        {
            return false;
        }

        public bool DeleteOpeningHours()
        {
            return false;
        }

        public bool DeleteSpecialDeals()
        {
            return false;
        }
//**********************************************************************************************************************
    }
}

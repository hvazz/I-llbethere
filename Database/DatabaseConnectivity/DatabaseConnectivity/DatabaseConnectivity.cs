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
        public static enum Table {
            Bar="bar", 
            User="user", 
            OpeningHour="opening_hour", 
            SpecialDeal="special_deal", 
            IllBeThere="ill_be_there"}

        public static DatabaseConnectivity Instance
        {
            get
            {
                if (Instance == null) return new DatabaseConnectivity();
                return Instance;
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

        private bool ExecuteQuery(string query)
        {
            if (connection.State != System.Data.ConnectionState.Open) Connect();
            if (connection.State != System.Data.ConnectionState.Open)
            {
                ErrorMessage("Cannot open connection to server");
                return false;
            } else {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
                return true;
            }
        }

        private SqlDataReader ExecuteReader(string query, string database)
        {
            if (connection.State != System.Data.ConnectionState.Open) Connect();
            if (connection.State != System.Data.ConnectionState.Open)
            {
                ErrorMessage("Cannot open connection to server");
                return null;
            }else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    //CloseConnection();
                    return reader;
                }
                catch (SqlException e) { ErrorMessage(e.ToString());}
            }
            return null;
        }

        private void ErrorMessage(string s)
        {
            Console.Write(s);
        }

        private int[] IntListToArray(List<int> list)
        { 
            int[] returnArray = new int[list.Count];

            int toolInt = 0;
            foreach (int s in list)
            {
                returnArray[toolInt] = s; ;
                toolInt++;
            }

                return returnArray;
        }

        private string CombineIDs(List<int> incStrings)
        {
            string returnString = "";
            int[] stringArray = IntListToArray(incStrings);

            for (int i = 0 ; i<stringArray.Length;i++)
            {
                if (i == stringArray.Length - 1) returnString += stringArray[i];
                else returnString += stringArray[i].ToString() +", ";
            }

            return returnString;
        }

        private List<int> ExtractId(List<IDHolder> IDHolders)
        {
            List<int> idList = new List<int>();

            foreach (IDHolder b in IDHolders)
            {
                idList.Add(b.ID);
            }

            return idList;
        }

//***************************************************** CREATE *********************************************************
        public bool CreateBar(Bar bar)
        {
            string query ="INSERT INTO "+Table.Bar+
            " Values('','"+bar.Name+"', '"+bar.Address+"', '"+bar.Image+"', '"+bar.ContactInfo+"', '"+bar.AdditionalInfo+"')";
            return ExecuteQuery(query);
        }

        public void CreateUser(User user)
        {
            string query = "INSERT INTO "+Table.User+
            " Values('', '"+user.ForeName+"', '"+user.LastName+"', '"+user.PhoneNumber+"', '"+user.Email+"')";
            ExecuteQuery(query);
        }

        public void CreateIllBeThere(User user, Bar bar, DateTime date)
        {
            string query = "INSERT INTO "+Table.IllBeThere+
            " Values('', '"+user.ID+"', '"+bar.ID+"', '"+date+"')" ;
            ExecuteQuery(query);
        }

        public void CreateOpeningHours(OpeningHours openHours)
        {
            string query = "INSERT INTO "+Table.OpeningHour+
            " Values('', '"+openHours.Times+"', '"+openHours.Date+"')";
            ExecuteQuery(query);
        }

        public void CreateSpecialDeals(SpecialDeal specialDeal)
        {
            string query = "INSERT INTO "+Table.SpecialDeal+
            " Values('', '"+specialDeal.Info+"', '"+specialDeal.From+"', '"+specialDeal.To+"')";
            ExecuteQuery(query);
        }
//**********************************************************************************************************************
//***************************************************** READ/GET (List) ************************************************
        public void GetBarByID(List<Bar> bars)
        {
            
        }

        public Bar GetBarByName(Bar bar)
        {


            return null;
        }

        public void GetUserByID(List<User> user)
        {
            
        }

        public User GetUserByName(User user)
        {


            return null;
        }

        public void GetIllBeThereByID(int id)
        {

        }

        public void GetOpeningHoursByID()
        {
            
        }

        public void GetSpecialDealsByID()
        {
            
        }
//**********************************************************************************************************************
//***************************************************** UPDATE/EDIT ****************************************************
        public void UpdateTable( string[] column, string[] value, List<IDHolder> IDs, Table table)
        {
            List<string> updates = new List<string>();
            string barIDString = CombineIDs(ExtractId(IDs));
            string doneUpdate = "";

            for (int i = 0; i < column.Length; i++)
            {
                if (i == column.Length - 1) updates.Add(column[i] + " = '" + value[i] + "'");

                else updates.Add("SET " + column[i] + " = '" + value[i] + "',");
            }
            
            foreach (string s in updates){doneUpdate = doneUpdate + s;}

            string query = "UPDATE "+table+" " + doneUpdate + " WHERE id IN (" + barIDString + ")";
            ExecuteQuery(query); 
        }
        /*
        public void UpdateUser()
        {
            
        }

        public void UpdateIllBeThere(int id)
        {

        }

        public void UpdateOpeningHours()
        {
            
        }

        public void UpdateSpecialDeals()
        {
            
        }*/
//**********************************************************************************************************************
//***************************************************** DELETE (List) **************************************************
        public void DeleteEntries(List<IDHolder> ids, Table target)
        {
            string toBeDeleted = CombineIDs(ExtractId(ids));
            string query = "DELETE FROM "+target+" WHERE id In (" + toBeDeleted + ")";
            ExecuteQuery(query);
        }

        /*
        public void DeleteUser()
        {
            
        }

        public void DeleteIllBeThere(int id)
        {

        }

        public void DeleteOpeningHours()
        {
            
        }

        public void DeleteSpecialDeals()
        {
            
        }
         * */
//**********************************************************************************************************************
    }
}

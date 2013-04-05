using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllBeThere
{
    class Server
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            
            //server.dbCon.CreateBar
            Console.ReadKey();
        }

        DatabaseConnectivity dbCon;

        public Server()
        {
            dbCon = DatabaseConnectivity.GetInstance;
        }
    }
}

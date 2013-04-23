using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllBeThere
{
    public class Server
    {
        static void Main(string[] args)
        {
            Server server = new Server();

            //server.dbCon.CreateBar
            Console.ReadKey();
        }

        DatabaseConnectivity dbCon;
        UserHandler userHandler;
        BarHandler barHandler;

        public Server()
        {
            dbCon = DatabaseConnectivity.Instance;
            userHandler = UserHandler.Instance;
            barHandler = BarHandler.Instance;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllBeThere
{
    public class UserHandler
    {

        List<User> users;

        private UserHandler()
        {
            users = new List<User>();
        }

        public static UserHandler Instance
        {
            get
            {
                if (Instance == null) return new UserHandler();
                else return Instance;
            }
        }

        public User FindCurrentUser()
        {
            

            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllBeThere
{
    class User : IDHolder
    {

        public User()
        { 
            
        }

        public int ID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string ForeName
        {
            get { return ForeName; }//return name; }
            set { ForeName = value; }
        }

        public string LastName
        {
            get { return LastName; }
            set { LastName = value; }
        }

        public string PhoneNumber
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }

        public string Email
        {
            get { return Email; }
            set { Email = value; }
        }

    }
}

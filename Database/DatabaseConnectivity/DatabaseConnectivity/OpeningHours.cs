using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllBeThere
{
    class OpeningHours : IDHolder
    {

        public OpeningHours()
        {

        }

        public DateTime Date
        {
            get { return Date; }
            set { Date = value; }
        }

        public string Times
        {
            get { return Times; }
            set { Times = value; }
        }
    }
}

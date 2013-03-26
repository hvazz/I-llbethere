using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllBeThere
{
    class OpeningHours
    {

        private DateTime start;
        private DateTime end;

        public OpeningHours()
        {
            start = new DateTime();
            end = new DateTime();
        }

        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }

        public DateTime End
        {
            get { return end; }
            set { end = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllBeThere
{
    class SpecialDeal : IDHolder
    {
        public SpecialDeal()
        { 
            
        }

        public string Info
        {
            get { return Info; }
            set { Info = value; }
        }

        public string Image
        {
            get { return Image; }
            set { Image= value; }
        }

        public DateTime From
        {
            get { return From; }
            set { From = value; }
        }

        public DateTime To
        {
            get { return To; }
            set { To = value; }
        }
    }
}

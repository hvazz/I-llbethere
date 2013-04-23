using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllBeThere
{
    public class BarHandler
    {

        List<Bar> bars;

        private BarHandler()
        {
            bars = new List<Bar>();
        }

        public static BarHandler Instance
        {
            get
            {
                if (Instance == null) return new BarHandler();
                else return Instance;
            }
        }
//******************************************** Server Side ***************************************************
        public void LoadBarsFromDB()
        { 
            
        }

        public void ServerSelectBars(List<int> idList)
        { 
            
        }

        public void ServerDeleteBars(List<int> isList)
        { 
            
        }

        public void ServerUpdateBar()
        { 
            
        }

        public void ServerCreateBar()
        { 
            
        }

//******************************************** Database    ***************************************************

        public List<IDHolder> DeleteBars(List<int> idList)
        {
            

            return null;
        }
    }
}

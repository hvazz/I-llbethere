using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllBeThere
{
    class Bar : IDHolder
    {
        private SpecialDeal specDeal;
        private List<OpeningHours> openings;
        private double barEntryFee;


        public Bar()
        {
            specDeal = new SpecialDeal();
            openings = new List<OpeningHours>();            
        }

        public string ID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Name
        {
            get { return Name; }
            set { Name = value;}
        }
        
        public string Address
        {
            get { return Address; }
            set { Address = value; }
        }

        public string Image
        {
            get { return Image; }
            set { Image= value; }
        }

        public string ContactInfo
        {
            get { return ContactInfo; }
            set { ContactInfo = value; }
        }

        public string AdditionalInfo
        {
            get { return AdditionalInfo; }
            set { AdditionalInfo = value; }
        }

        public string GetSpecialDealInfo()
        {
            return specDeal.Info;
        }

        public void SetSpecialDealInfo(string newInfo)
        {
            specDeal.Info = newInfo;
        }

        public string GetSpecialDealImage()
        {
            return specDeal.Image;
        }

        public void SetSpecialDealImage(string newImage)
        {
            specDeal.Image = newImage;
        }

        /*public List<OpeningHours> GetRelevantOpeningHours()
        {

            List<OpeningHours> returnList = new List<OpeningHours>();
            DateTime current = new DateTime();

            foreach (OpeningHours oh in openings)
            {
                int result = DateTime.Compare(oh.Start,current);
                if (result == 0 || result > 0) openings.Add(oh);
            }

            return returnList;
        }*/

        /*public OpeningHours GetSingleOpeningHouers(DateTime targetStart, DateTime targetEnd)
        {
            DateTime result = new DateTime();

            foreach (OpeningHours oh in openings)
            { 
                int startResult = DateTime.Compare(oh.Start,targetStart);
                int endResult = DateTime.Compare(oh.End,targetEnd);
                if (startResult == 0 && endResult == 0) return oh;
            }

            return null;
        }*/
        
        public List<OpeningHours> GetAllOpeningsHours()
        {
            return openings;
        }

        /*public void DeleteOpeningHouers(List<OpeningHours> ohList)
        {
            foreach (OpeningHours oh in openings)
            {
                foreach (OpeningHours oh2 in ohList)
                {
                    if (DateTime.Compare(oh.Start, oh2.Start) == 0 && DateTime.Compare(oh.End, oh2.End) == 0) openings.Remove(oh);
                }
            }
        }*/

        public void AddOpeningHours(List<OpeningHours> ohList)
        { 
            foreach (OpeningHours oh in ohList)
            {
                openings.Add(oh);
            }
        }

        public double EntryFee
        {
            get { return barEntryFee; }
            set { barEntryFee = value;}
        }
    }
}

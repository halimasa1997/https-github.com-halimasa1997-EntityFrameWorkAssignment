using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Model
{
    internal class Baggage
    {  public int BaggageID { get; set; }
        public string Weight { get; set; }
        public string TrackingNum { get; set; }

        public Baggage(int BaggageID, string Weight, string TrackingNum)
        {
            this.BaggageID = BaggageID;
            this.Weight = Weight;
            this.TrackingNum = TrackingNum;



        }
    }
}

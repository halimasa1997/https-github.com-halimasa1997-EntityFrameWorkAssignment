using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Model
{
    internal class Gate
    {
        public int GateID { get; set; }
        public int GateNumber { get; set; }
        public bool GavailabilityStatus { get; set; }



        public Gate(int gateID, int gateNumber, bool gavailabilityStatus)
        {
            GateID = gateID;
            GateNumber = gateNumber;
            GavailabilityStatus = gavailabilityStatus;
        }
    }
}

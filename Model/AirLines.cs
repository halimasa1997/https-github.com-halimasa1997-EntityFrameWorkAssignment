using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Model
{
    internal class AirLines
    {
    public int AirLineID { get; set; }
        public string AirLineName { get; set; }
        public int AirLNumber { get; set; }
        public string Email { get; set; }
        public string PersonRepresentName { get; set; }

        public AirLines(int airLineID, string airLineName, int airLNumber, string email, string personRepresentName)
        {
            AirLineID = airLineID;
            AirLineName = airLineName;
            AirLNumber = airLNumber;
            Email = email;
            PersonRepresentName = personRepresentName;
        }
    }

}



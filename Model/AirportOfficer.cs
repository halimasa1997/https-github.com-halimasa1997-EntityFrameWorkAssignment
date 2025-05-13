using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Model
{
    internal class AirportOfficer
    {   public int OfficerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public long ContactPhone { get; set; }
        public string Email { get; set; }

        public AirportOfficer(int officerID, string firstName, string lastName, string position, string department, long contactPhone, string email)
        {
            OfficerID = officerID;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            Department = department;
            ContactPhone = contactPhone;
            Email = email;
        }
    }
}
    


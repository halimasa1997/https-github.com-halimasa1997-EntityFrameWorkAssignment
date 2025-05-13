using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Model
{
    internal class Passenger
    {
        public int PasssengerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string PassportNumber { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }

        public Passenger(int passengerID, string firstName, string lastName, string dateOfBirth, string gender, string nationality, string passportNumber, string ContactPhone, string contactEmail)
        {
            PasssengerID = passengerID;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Nationality = nationality;
            PassportNumber = passportNumber;
            this.ContactPhone = ContactPhone;
            ContactEmail = contactEmail;




        }
    }
}

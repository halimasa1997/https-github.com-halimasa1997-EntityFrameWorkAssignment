using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Model
{
    internal class Flight
    {
        public int FlightID { get; set; }
        public string DepartureCity { get; set; }
        public string DestinationCity { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public string FlightStatus { get; set; }
        public string GateNumber { get; set; }


        public Flight(int flightID, string departureCity, string destinationCity, string departureTime, string arrivalTime, string flightStatus, string gateNumber)
        {
            FlightID = flightID;
            DepartureCity = departureCity;
            DestinationCity = destinationCity;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            FlightStatus = flightStatus;
            GateNumber = gateNumber;
        }
    }
}

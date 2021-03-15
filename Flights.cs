using System;
using System.Collections.Generic;
using System.Text;

namespace FlightReservationSystem
{
    class Flights
    {
        public string AirlineCode { get; set; }
        public string FlightNumber { get; set; }
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public string STD { get; set; }
        public string STA { get; set; }

        public Flights(string airlineCode, string flightNumber, string departureStation, string arrivalStation, string sTD, string sTA)
        {
            this.AirlineCode = airlineCode;
            this.FlightNumber = flightNumber;
            this.DepartureStation = departureStation;
            this.ArrivalStation = arrivalStation;
            this.STD = sTD;
            this.STA = sTA;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FlightReservationSystem
{
    class WriteToFile
    {
        //private readonly string UserTextFile = ConfigurationManager.AppSettings["textFileName"];
        public void WriteFlightToFile(Flights flight)
        {
            using (StreamWriter sw = new StreamWriter(@"Flights.txt", true))
            {
                sw.WriteLine(flight.AirlineCode + "," + flight.FlightNumber + "," + flight.DepartureStation + "," + flight.ArrivalStation + "," + flight.STD + "," + flight.STA);
            }
        }

        public void ReadFromFile(FlightMaintenance fm)
        {
            string textline;
            using (StreamReader sr = new StreamReader(@"Flights.txt"))
            {
                while ((textline = sr.ReadLine()) != null)
                {
                    string[] flightInformation = textline.Split(',');
                    Flights f = new Flights(flightInformation[0], flightInformation[1], flightInformation[2], flightInformation[3], flightInformation[4], flightInformation[5]);
                    fm._FlightsList.Add(f);
                }
            }
        }
    }

}


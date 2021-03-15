using System;
using System.Collections.Generic;
using System.Text;

namespace FlightReservationSystem
{
    class FlightMaintenance
    {
        private WriteToFile wtf;
        public List<Flights> _FlightsList = new List<Flights>();

        public FlightMaintenance()
        {
            _FlightsList = new List<Flights>();
            wtf = new WriteToFile();
            LoadFlightsFromSource();
        }

        public void CreateFlight()
        {
            Console.Write("Enter Airline Code:");
            var airlineCode = Console.ReadLine();

            Console.Write("Enter Flight Number:");
            var flightNumber = Console.ReadLine();

            Console.Write("Enter Departure Station:");
            var departureStation = Console.ReadLine();

            Console.Write("Enter Arrival Station:");
            var arrivalStation = Console.ReadLine();

            Console.Write("Enter STD:");
            var sTD = Console.ReadLine();

            Console.Write("Enter STA:");
            var sTA = Console.ReadLine();

            Flights flights = new Flights(airlineCode, flightNumber, departureStation, arrivalStation, sTD, sTA);
            AddFlightToList(flights, flights);
            wtf.WriteFlightToFile(flights);

        }

        private void AddFlightToList(Flights flight, Flights flights) => _FlightsList.Add(flights);

        public void ShowAllFlightsInList()
        {
            // TODO show total number of flights
            foreach (var flights in _FlightsList)
            {
                Console.WriteLine("AirlineCode: {0}, FlightNumber: {1}, DepartureStation: {2}, ArrivalStation: {3}, STD: {4}, STA: {5}", flights.AirlineCode, flights.FlightNumber, flights.DepartureStation, flights.ArrivalStation, flights.STD, flights.STD);
            }
            Console.WriteLine("Press any key to continue.");
            var a = Console.ReadLine();
        }

        public void LoadFlightsFromSource() {
            // TODO load flight data from file to _FlightsList
            wtf.ReadFromFile(this);
        }
    }
}

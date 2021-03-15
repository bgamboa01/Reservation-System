using System;

namespace FlightReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            FlightMaintenance flm = StartProgram();
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome! Choose an option:");
            Console.WriteLine("[1] Flight Maintenance");
            Console.WriteLine("[2] Reservation");
            Console.WriteLine("[3] Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    FlightMaintenanceMenu();
                    return true;
                case "2":
                    ReservationMenu();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static bool FlightMaintenanceMenu()
        {
            Console.Clear();
            Console.WriteLine("[1] Add Flight");
            Console.WriteLine("[2] View All Flights");
            Console.WriteLine("[3] View Flights by Carrier Code");
            Console.WriteLine("[4] View Flights by Station");
            Console.WriteLine("[5] Exit");
            Console.Write("\r\nSelect an option: ");

            FlightMaintenance flm = null;
            flm = new FlightMaintenance();

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    flm.CreateFlight();
                    return true;
                case "2":
                    flm.ShowAllFlightsInList();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static bool ReservationMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("[1] Create Reservation");
            Console.WriteLine("[2] View All Reservations");
            Console.WriteLine("[3] View Specific Reservation");
            Console.WriteLine("[4] Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    return true;
                case "2":
                    ReservationMenu();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }
        private static FlightMaintenance StartProgram()
        {
            FlightMaintenance flm = new FlightMaintenance();

            //Start program by loading saved users from txt-file
            WriteToFile writer = new WriteToFile();
            writer.ReadFromFile(flm);
            return flm;
        }
    }
}

using SkyScanner.Models;

namespace SkyScanner
{
    public static class VirtualDatabase
    {
        public static List<CharterFlight> charterFlight = new List<CharterFlight>()
        {
            new CharterFlight {FligthNumber = 3001, Airline = "SkyFree", DepartureAirport = "JFK", ArrivalAirport = "ADA", Status = "Active", DepartureDateTime = DateTime.Now, ArrivalDateTime = DateTime.Now.AddHours(3), Price = 100 },
            new CharterFlight {FligthNumber = 3002, Airline = "SkyFree", DepartureAirport = "JFK", ArrivalAirport = "LAX", Status = "Active", DepartureDateTime = new DateTime(2024,9,1,9,0,0), ArrivalDateTime = new DateTime(2024,9,1,12,0,0), Price = 200 },
            new CharterFlight {FligthNumber = 3003, Airline = "FlyBee", DepartureAirport = "JFK", ArrivalAirport = "ADA", Status = "Active", DepartureDateTime = new DateTime(2024,12,1,9,0,0), ArrivalDateTime = new DateTime(2024,12,1,15,0,0), Price = 150 },
            new CharterFlight {FligthNumber = 3004, Airline = "Zeus", DepartureAirport = "ADA", ArrivalAirport = "JFK", Status = "Canceled", DepartureDateTime = new DateTime(2024,12,1,12,0,0), ArrivalDateTime = new DateTime(2024,12,1,18,0,0), Price = 200 },
            new CharterFlight {FligthNumber = 3005, Airline = "Zeus", DepartureAirport = "LAX", ArrivalAirport = "JFK", Status = "Active", DepartureDateTime = new DateTime(2024,12,31,7,0,0), ArrivalDateTime = new DateTime(2024,12,31,10,0,0), Price = 350 },
        };

    }
}

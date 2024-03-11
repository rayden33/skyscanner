namespace SkyScanner.Models
{
    public class CharterBooking
    {
        public CharterBooking() { }
        public CharterBooking(int id, int flightNumber, int bookingPlacesCount, string passengerName) 
        {
            Random random = new Random();
            Id = id;
            FlightNumber = flightNumber;
            BookingPlacesCount = bookingPlacesCount;
            PassengerName = passengerName;
            BookingDateTime = DateTime.Now;
        }
        public int Id { get; set; }
        public int FlightNumber { get; set; }
        public int BookingPlacesCount { get; set; }
        public string PassengerName { get; set; }
        public DateTime BookingDateTime { get; set; }
    }
}

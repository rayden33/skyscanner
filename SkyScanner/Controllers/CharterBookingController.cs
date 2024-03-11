using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkyScanner.Models;

namespace SkyScanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharterBookingController : ControllerBase
    {
        private static List<CharterBooking> charterBookings = new List<CharterBooking>();
        private static readonly List<CharterFlight> charterFlights = VirtualDatabase.charterFlight;
        private static int bookingIdCounter = 1;

        [HttpGet]
        public IEnumerable<CharterBooking> Get()
        {
            return charterBookings;
        }

        [HttpPost]
        public ActionResult<CharterBooking> CharterBook([FromBody] CharterBooking charterRequest)
        {
            var selectedFlight = charterFlights.FirstOrDefault(f => f.FligthNumber == charterRequest.FlightNumber);
            if(selectedFlight == null)
            {
                return NotFound("Charter flight not found");
            }
            if(selectedFlight.Status == "Canceled")
            {
                return NotFound("Charter flight is canceled");
            }
            var charterBook = new CharterBooking(bookingIdCounter++,charterRequest.FlightNumber,
                charterRequest.BookingPlacesCount, charterRequest.PassengerName);

            charterBookings.Add(charterBook);

            return Ok(charterBook);
        }
    }
}

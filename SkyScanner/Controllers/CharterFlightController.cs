using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkyScanner.Models;

namespace SkyScanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharterFlightController : ControllerBase
    {
        private static readonly List<CharterFlight> charterFlights = VirtualDatabase.charterFlight;

        [HttpGet]
        public IEnumerable<CharterFlight> Get()
        {
            return charterFlights;
        }

        [HttpGet("flightNumber")]
        public ActionResult<CharterFlight> GetCharterFlight(int flightNumber)
        {
            var selectedFlight = charterFlights.FirstOrDefault(f => f.FligthNumber == flightNumber);
            if (selectedFlight == null)
            {
                return NotFound("Charter flight not found");
            }

            return selectedFlight;
        }
    }
}

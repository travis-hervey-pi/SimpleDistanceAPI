using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleDistanceApi.Attributes;
using static SimpleDistanceApi.CityInfoConstants;

namespace SimpleDistanceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiKey]
    public class SimpleDistanceController : ControllerBase
    {
        [HttpGet]
        [Route("Cities")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<string>> GetCities()
        {
            return CityNameLookup.Keys.ToList();
        }

        [HttpGet]
        [Route("GetSimpleDistance")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<DistanceResponse> GetDistance(string originCity, string destinationCity)
        {
            var origin = CityNameLookup.ContainsKey(originCity) ? CityNameLookup[originCity] : City.Unknown;
            var destination = CityNameLookup.ContainsKey(destinationCity) ? CityNameLookup[destinationCity] : City.Unknown;

            if (origin == City.Unknown)
            {
                return BadRequest($"Origin not recognized: {originCity}");
            }
            if (destination == City.Unknown)
            {
                return BadRequest(destinationCity);
            }
            if (originCity == destinationCity)
            {
                return BadRequest($"Destination not recognized: {destinationCity}");

            }

            var route = new Route(origin, destination);

            if (!RouteLookup.ContainsKey(route))
            {
                return BadRequest($"No route available for {originCity} to {destinationCity}");
            }

            var time = new TimeSpan(0, 0, RouteLookup[route].Time);
            return new DistanceResponse
            {
                destination_addresses = destinationCity,
                origin_addresses = originCity,
                rows = new List<Row>
                {
                    new Row
                    {
                        elements = new List<Element>
                        {
                            new Element
                            {
                                distance = new Distance
                                {
                                    value = RouteLookup[route].Distance,
                                    text = $"{RouteLookup[route].Distance} mi"
                                },
                                duration = new Duration
                                {
                                    value = RouteLookup[route].Time,
                                    text = $"{time.Hours} hours {time.Minutes} minutes"
                                },
                                status = "OK"
                            }
                        }
                    }
                },
                status="OK"
            };
        }

    }
}

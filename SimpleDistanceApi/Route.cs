using static SimpleDistanceApi.CityInfoConstants;

namespace SimpleDistanceApi
{
    public class Route
    {
        public Route(City origin, City destination)
        {
            Origin = origin;
            Destination = destination;
        }

        public City Origin { get; set; }
        public City Destination { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Route route &&
                   Origin == route.Origin &&
                   Destination == route.Destination;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Origin, Destination);
        }
    }
}

namespace SimpleDistanceApi
{
    public class RouteInfo
    {
        public RouteInfo(int distance, int time)
        {
            Distance = distance;
            Time = time;
        }

        public int Distance { get; set; }
        public int Time { get; set; }
    }
}

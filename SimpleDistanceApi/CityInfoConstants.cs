namespace SimpleDistanceApi
{
    public static class CityInfoConstants
    {
        public enum City {
            Unknown,
            Boston,
            NewYork,
            LosAngeles,
            Atlanta,
            Miami,
            Cincinnati
        }

        public static Dictionary<Route, RouteInfo> RouteLookup { get; set; } = new Dictionary<Route, RouteInfo>()
        {
            // Boston
            { new Route(City.Boston, City.NewYork), new RouteInfo(215, 13980) },
            { new Route(City.Boston, City.LosAngeles), new RouteInfo(2983, 158400)},
            { new Route(City.Boston, City.Atlanta), new RouteInfo(1095, 62640)},
            { new Route(City.Boston, City.Miami), new RouteInfo(1491, 85200)},
            { new Route(City.Boston, City.Cincinnati), new RouteInfo(882, 47340)},

            // Los Angeles
            { new Route(City.LosAngeles, City.NewYork), new RouteInfo(2799, 151200) },
            { new Route(City.LosAngeles, City.Boston), new RouteInfo(2983, 158400)},
            { new Route(City.LosAngeles, City.Atlanta), new RouteInfo(2181, 115200)},
            { new Route(City.LosAngeles, City.Miami), new RouteInfo(2733, 144000)},
            { new Route(City.LosAngeles, City.Cincinnati), new RouteInfo(2173, 115200)},

            // Atlanta
            { new Route(City.Atlanta, City.NewYork), new RouteInfo(866, 48180) },
            { new Route(City.Atlanta, City.Boston), new RouteInfo(1076, 59940)},
            { new Route(City.Atlanta, City.LosAngeles), new RouteInfo(2184, 115200)},
            { new Route(City.Atlanta, City.Miami), new RouteInfo(663, 35820)},
            { new Route(City.Atlanta, City.Cincinnati), new RouteInfo(461, 24480)},

            // Miami
            { new Route(City.Miami, City.NewYork), new RouteInfo(1280, 67860) },
            { new Route(City.Miami, City.Boston), new RouteInfo(1490, 80760)},
            { new Route(City.Miami, City.LosAngeles), new RouteInfo(2733, 144000)},
            { new Route(City.Miami, City.Atlanta), new RouteInfo(664, 34800)},
            { new Route(City.Miami, City.Cincinnati), new RouteInfo(1124, 59940)},

            // Cincinnati
            { new Route(City.Cincinnati, City.NewYork), new RouteInfo(639, 36300) },
            { new Route(City.Cincinnati, City.Boston), new RouteInfo(883, 46920)},
            { new Route(City.Cincinnati, City.LosAngeles), new RouteInfo(2175, 115200)},
            { new Route(City.Cincinnati, City.Atlanta), new RouteInfo(461, 24480)},
            { new Route(City.Cincinnati, City.Miami), new RouteInfo(1123, 59460)},

            // New York
            { new Route(City.NewYork, City.Cincinnati), new RouteInfo(639, 36300) },
            { new Route(City.NewYork, City.Boston), new RouteInfo(215, 13980)},
            { new Route(City.NewYork, City.LosAngeles), new RouteInfo(2799, 151200)},
            { new Route(City.NewYork, City.Atlanta), new RouteInfo(866, 48180)},
            { new Route(City.NewYork, City.Miami), new RouteInfo(1280, 67860)}
        };

        public static Dictionary<string, City> CityNameLookup { get; set; } = new Dictionary<string, City>
        {
            { "Boston", City.Boston },
            { "New York", City.NewYork },
            { "Los Angeles", City.LosAngeles },
            { "Atlanta", City.Atlanta },
            { "Miami" , City.Miami },
            { "Cincinnati", City.Cincinnati }
        };
    }
}

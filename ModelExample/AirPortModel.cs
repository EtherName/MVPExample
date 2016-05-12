using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelExample
{
    class AirPortModel : IAirPortModel
    {
        List<Flight> _flights;
        public IEnumerable<Flight> Flights => _flights;

        public AirPortModel()
        {
            _flights = new List<Flight>
            {
                new Flight {Arrival= true, City="London", Number = 1 },
                new Flight {Arrival= false, City="Paris", Number = 2 },
                new Flight {Arrival= true, City="Moscov", Number = 31 },
            };
        }
    }
}

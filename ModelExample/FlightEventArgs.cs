using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelExample
{
    public class FlightEventArgs : EventArgs
    {
        public IEnumerable<Flight> Flights { get; set; }
    }
}

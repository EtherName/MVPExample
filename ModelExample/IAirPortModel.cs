using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelExample
{
    public interface IAirPortModel
    {
        IEnumerable<Flight> Flights { get; }
    }
}

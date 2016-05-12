using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelExample
{
    public class AirPortModelFactory
    {
        public static IAirPortModel CreateAirportModel() => new AirPortModel();        
    }
}

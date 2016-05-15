using ModelExample;
using System;
using System.Collections.Generic;

namespace PresenterExample
{
    public interface IView
    {
        void UpdateFlights(IEnumerable<Flight> flights);
        void DeleteFlights();
        event EventHandler<EventArgs> PopulateFlightsEventRaised;
        event EventHandler<FlightEventArgs> DeleteFlightsEventRaised;
    }
}
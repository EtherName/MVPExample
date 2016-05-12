using ModelExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresenterExample
{
    public class Presenter
    {
        IView _view;
        IAirPortModel _airPortModel;
        

        public Presenter(IView view)
        {
            _view = view;
            _airPortModel = AirPortModelFactory.CreateAirportModel();
            _view.PopulateFlightsEventRaised += PopulateFlightsEventHandler;
        }
        private void PopulateFlightsEventHandler(object sender, EventArgs e)
        {
            _view.UpdateFlights(_airPortModel.Flights);
        }
    }
}

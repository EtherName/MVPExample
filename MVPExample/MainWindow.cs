using PresenterExample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelExample;

namespace MVPExample
{
    public partial class MainWindow : Form, IView
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public event EventHandler<FlightEventArgs> DeleteFlightsEventRaised;
        public event EventHandler<EventArgs> PopulateFlightsEventRaised;

        FlightEventArgs _flightEA = new FlightEventArgs();

        public void DeleteFlights()
        {
            List<Flight> flights = new List<Flight>();
            foreach (var row in FlightsGridView.SelectedRows)
            {
                var datarow = row as DataGridViewRow;
                flights.Add((Flight)datarow.DataBoundItem);
            }
            _flightEA.Flights = flights;
        }

        public void UpdateFlights(IEnumerable<Flight> flights)
        {
            FlightsGridView.DataSource = null;
            FlightsGridView.DataSource = flights;
        }

        private void PopulateButtonClick(object sender, EventArgs e)
        {
            var handler = PopulateFlightsEventRaised;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            var handler = DeleteFlightsEventRaised;
            DeleteFlights();
            if (handler != null)
            {
                handler(this, _flightEA);
            }

        }
    }
}

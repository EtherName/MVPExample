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
        public event EventHandler<FlightEventArgs> AddNewFlightsEventRaised;

        FlightEventArgs _flightEA = new FlightEventArgs();
        int _length = 0;

        public IEnumerable<Flight> DeleteFlights()
        {
            List<Flight> flights = new List<Flight>();
            foreach (var row in FlightsGridView.SelectedRows)
            {
                var datarow = row as DataGridViewRow;
                flights.Add((Flight)datarow.DataBoundItem);
            }
            return flights;
        }

        public void UpdateFlights(IEnumerable<Flight> flights)
        {
            _length = flights.Count();
            FlightsGridView.DataSource = null;
            FlightsGridView.DataSource = flights;
        }

        public IEnumerable<Flight> AddNewFlights()
        {
            List<Flight> flights = new List<Flight>();

            for (int i = _length; i < FlightsGridView.ColumnCount - 1; i++)
            {
                var datarow = FlightsGridView.SelectedRows[i] as DataGridViewRow;
                flights.Add((Flight)datarow.DataBoundItem);
            }
            return flights;
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
            if (handler != null)
            {
                handler(this, _flightEA);
            }
        }

        private void AddItemsButtonClick(object sender, EventArgs e)
        {
            var handler = AddNewFlightsEventRaised;
            if (handler != null)
            {
                handler(this, _flightEA);
            }
        }
    }
}

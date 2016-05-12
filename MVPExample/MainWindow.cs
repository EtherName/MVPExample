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

        public event EventHandler<EventArgs> PopulateFlightsEventRaised;

        public void UpdateFlights(IEnumerable<Flight> flights)
        {
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

    }
}

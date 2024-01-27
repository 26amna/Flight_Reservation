using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_reservation
{
    public partial class Customersdo : Form
    {
        public Customersdo()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FlightsDisplay flightsDisplay = new FlightsDisplay();
            flightsDisplay.ShowDialog();
        }

        private void Customersdo_Load(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            DisplayFlightsAndAircrafts displayFlightsAndAircrafts = new DisplayFlightsAndAircrafts();
            displayFlightsAndAircrafts.ShowDialog();
        }
    }
}

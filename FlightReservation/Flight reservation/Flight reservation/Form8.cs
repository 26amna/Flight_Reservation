using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_reservation
{
    public partial class Admindo : Form
    {
        public Admindo()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Aircraft aircraft = new Aircraft();
            aircraft.ShowDialog();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAircraft updateair = new UpdateAircraft();
            updateair.ShowDialog();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Flight flight = new Flight();
            flight.ShowDialog();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            DeleteFlight dflight = new DeleteFlight();
            dflight.ShowDialog();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            DeleteAdmin dadmin= new DeleteAdmin();
            dadmin.ShowDialog();
        }
    }
}

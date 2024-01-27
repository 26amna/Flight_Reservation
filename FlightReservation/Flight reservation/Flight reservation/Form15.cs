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
    public partial class DisplayFlightsAndAircrafts : Form
    {
        public DisplayFlightsAndAircrafts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4OO8MTQ\SQLEXPRESS;Initial Catalog=FlightReservation;Integrated Security=True");
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Flights INNER JOIN Aircrafts ON Aircrafts.AircraftId = Flights.AircraftID", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            FlightsAndAircrafts.DataSource = dtbl;
            con.Close();
            MessageBox.Show("Connection made Successfully!!");
        }
    }
}

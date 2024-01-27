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
using System.Xml.Linq;

namespace Flight_reservation
{
    public partial class Flight : Form
    {
        public Flight()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4OO8MTQ\SQLEXPRESS;Initial Catalog=FlightReservation;Integrated Security=True");
            con.Open();
            SqlCommand myCommand = new SqlCommand("insert into Flights (FlightID,Source,Destination,DepartureDate, ArrivalDate, AircraftID) values ('" + txtFId.Text.ToString() + "','" + txtSource.Text.ToString() + "','" + txtDestination.Text.ToString() + "','" + txtDeprature.Text.ToString() + "','" + txtArrival.Text.ToString() + "', '" + txtAId.Text.ToString() + "')", con);
            myCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Connection made Successfully!!");
        }
    }
}

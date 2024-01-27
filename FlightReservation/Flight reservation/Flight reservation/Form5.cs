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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Flight_reservation
{
    public partial class UpdateAircraft : Form
    {
        public UpdateAircraft()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4OO8MTQ\SQLEXPRESS;Initial Catalog=FlightReservation;Integrated Security=True");
            con.Open();
            SqlCommand myCommand = new SqlCommand("update Aircrafts set Model='" + txtModel.Text.ToString() + "' where AircraftId='" + txtairId.Text.ToString() + "'", con);
            myCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Connection made Successfully!!");
        }
    }
}

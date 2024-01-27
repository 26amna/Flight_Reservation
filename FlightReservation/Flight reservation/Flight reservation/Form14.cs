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
    public partial class FlightsDisplay : Form
    {
        public FlightsDisplay()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4OO8MTQ\SQLEXPRESS;Initial Catalog=FlightReservation;Integrated Security=True");
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Flights", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            FlightsTable.DataSource = dtbl;
            con.Close();
            MessageBox.Show("Connection made Successfully!!");
        }
    }
}

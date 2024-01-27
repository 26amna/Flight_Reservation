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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4OO8MTQ\SQLEXPRESS;Initial Catalog=FlightReservation;Integrated Security=True");
            con.Open();
            SqlCommand myCommand = new SqlCommand("insert into Customers (CustomerID,CustomerName,UserID,BaggageID) values ('" + txtCId.Text.ToString() + "','" + txtName.Text.ToString() + "','" + txtUId.Text.ToString() + "','" + txtBaggage.Text.ToString() + "')", con);
            myCommand.ExecuteNonQuery();
            Customersdo customersdo = new Customersdo();
            customersdo.ShowDialog();
            con.Close();
            MessageBox.Show("Connection made Successfully!!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Flight_reservation
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4OO8MTQ\SQLEXPRESS;Initial Catalog=FlightReservation;Integrated Security=True");
            con.Open();
            SqlCommand myCommand = new SqlCommand("insert into Users (UserId,Username,Email,Password) values ('" + txtID.Text.ToString() + "','" + txtName.Text.ToString() + "','" + txtEmail.Text.ToString() + "','" + txtPassword.Text.ToString() + "')", con);
            myCommand.ExecuteNonQuery();
            Login login = new Login();
            login.ShowDialog();
            con.Close();
            MessageBox.Show("Connection made Successfully!!");
        }
    }

}
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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            User user = new User();
            user.ShowDialog();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePassword updatePassword = new UpdatePassword();
            updatePassword.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_register
{
    public partial class UserPage : Form
    {
        public UserPage()
        {
            InitializeComponent();
            pictureBox1.Load(User.GetProfilePic());
            fullNameLabel.Text = User.GetFullName();
            usernameLabel.Text = "@" + User.GetUsername();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

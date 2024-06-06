using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//panel1 -> form container
//panel2 -> menu
namespace login_register
{
    public partial class ContainerForm : Form
    {
        private User User;
        private HomePage homePage;
        public ContainerForm(User User)
        {
            InitializeComponent();
            this.User = User;
            pfpBox.Load(User.GetProfilePic());
            usernameLabel.Text = "@" + User.GetUsername();
            this.homePage = new HomePage(this);
            LoadForm(homePage);
        }
        /*
         Η συνάρτηση που διαχειρίζεται το container panel (panel1)
         Δίνει στο panel1 έλεγχο στην φόρμα που δέχεται ως παράμετρο
         */
        public void LoadForm(Form form)
        {
            //if (this.panel1.Controls.Count > 0) this.panel1.Controls.RemoveAt(0);
          if (form is HomePage)
            {
                Form f = form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(f);
                this.panel1.Tag = f;
                f.BringToFront();
                f.Show();
            }
            else
            {
                if (this.panel1.Controls.Count > 0) this.panel1.Controls.RemoveAt(0);
                Form f = form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(f);
                this.panel1.Tag = f;
                f.BringToFront();
                f.Show();
            }

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {
            if (User.GetAuthor() == true)
            {
                LoadForm(new AuthorPage());
            }
            else
            {
                LoadForm(new UserPage());
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginOrRegister_Click(object sender, EventArgs e)
        {
            //Restart application
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            Application.Exit();
        }

        private void bookLand_Click(object sender, EventArgs e)
        {
            //LoadForm(new HomePage(this));
            LoadForm(this.homePage);

        }
    }
}

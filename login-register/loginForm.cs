using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace login_register
{
    public partial class loginForm : Form
    {
        private User User;

        
        public loginForm()
        {
            InitializeComponent();
            //this.User = User;
        }
        
        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLOGIN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUserName.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Please complete all required fields!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                NpgsqlConnection connection = DBHandler.OpenConnection();
                NpgsqlCommand command = DBHandler.GetCommand(connection);
                command.CommandText = "SELECT * FROM users WHERE (username = '" + textBoxUserName.Text + "');";
                NpgsqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    //Verify password
                    string pass = textBoxPassword.Text;
                    pass = pass + GLOBALS.pepper;
                    string dbPass = "";
                    if (dataReader.Read())
                    {
                        dbPass = dataReader.GetString(2);

                        bool isMatch = BCrypt.Net.BCrypt.EnhancedVerify(pass, dbPass);
                        if (isMatch)
                        {

                            //MessageBox.Show("Welcome " + textBoxUserName.Text + "!", "Login Successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            User.SetUsername(textBoxUserName.Text);
                            User.SetFullName(dataReader.GetString(1));
                            User.SetProfilePic(dataReader.GetString(4));
                            User.SetAuthor(dataReader.GetBoolean(3));

                            ContainerForm containerForm = new ContainerForm(User);
                            containerForm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Please fill in the correct password", "Wrong Password!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxPassword.Clear();
                            textBoxPassword.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        button1_Click(sender, e);
                    }

                }
                else
                {
                    MessageBox.Show("Would you like to register?", "This username does not exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dataReader.Close();
                DBHandler.CloseConnection(connection, command);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new FormRegister(User).Show();
            this.Hide();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked) textBoxPassword.PasswordChar = '\0';
            else textBoxPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonClearLOGIN_Click(object sender, EventArgs e)
        {

        }
    }
}

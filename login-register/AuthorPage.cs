using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace login_register
{
    public partial class AuthorPage : Form
    {
        public AuthorPage()
        {
            InitializeComponent();
            pictureBox1.Load(User.GetProfilePic());
            authorNameLabel.Text = User.GetFullName();
            authorUsernameLabel.Text = "@" + User.GetUsername();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isbn_textBox.TextLength < 1 || title_textBox.TextLength < 1 || author_textBox.TextLength < 1 || plot_richTextBox.TextLength < 1 || price_textBox.TextLength < 1 || cover_textBox.TextLength < 1)
            {
                MessageBox.Show("Please complete all required fields!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string isbn = isbn_textBox.Text;
                string title = title_textBox.Text;
                string author = author_textBox.Text;
                string plot = plot_richTextBox.Text;
                float price = float.Parse(price_textBox.Text, CultureInfo.InvariantCulture.NumberFormat);
                string cover = cover_textBox.Text;

                Book book = new Book(isbn, title, author, plot, comboBox1.Text, price, cover);
                book.InsertBook_toDB();
            }


        }

    }
}

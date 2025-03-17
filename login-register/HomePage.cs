using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_register
{
    public partial class HomePage : Form
    {
        private ContainerForm containerForm;
        private List<Book> Books;
        public HomePage(ContainerForm containerForm)
        {
            InitializeComponent();
            Books = new List<Book>();
            this.containerForm = containerForm;
        }


        private void AddBookToUI(Book book)
        {
            //Create panel
            Panel panel;
            panel = new Panel();
            panel.Name = String.Format("BookPanel{0}", book.isbn);
            panel.BackColor = Color.PapayaWhip;
            panel.Size = new Size(125, 230);
            panel.Margin = new Padding(10);
            panel.Tag = book.isbn;

            //Add panel to flowlayoutpanel
            flowLayoutPanel.Controls.Add(panel);

            //Create picture box
            PictureBox picBox;
            picBox = new PictureBox();
            picBox.Name = String.Format("BookPanel{0}", book.isbn);
            picBox.Size = new Size(100, 148);
            picBox.Location = new Point(12, 10);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox.Load(book.cover);
            picBox.Tag = book.isbn;
            picBox.Click += (sender, e) => PicBox_Click(sender, e, book);
            picBox.Cursor = Cursors.Hand;

            //Create title label
            Label titleLabel;
            titleLabel = new Label();
            titleLabel.Name = String.Format("bookTitleLabel{0}", book.isbn);
            titleLabel.Text = book.title;
            titleLabel.Location = new Point(12, 165);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Font = new Font("Candara", 12f, FontStyle.Bold);
            titleLabel.AutoSize = true;
            titleLabel.Tag = book.isbn;

            //Create author label
            Label authorLabel;
            authorLabel = new Label();
            authorLabel.Name = String.Format("bookAuthorLabel{0}", book.isbn);
            authorLabel.Text = book.author;
            authorLabel.Location = new Point(12, 185);
            authorLabel.ForeColor = Color.Black;
            authorLabel.Font = new Font("Candara", 10f, FontStyle.Regular);
            authorLabel.Tag = book.isbn;

            //Create price label
            Label bookPriceLabel;
            bookPriceLabel = new Label();
            bookPriceLabel.Name = String.Format("bookPriceLabel{0}", book.isbn);
            bookPriceLabel.Text = book.price.ToString(CultureInfo.InvariantCulture);
            bookPriceLabel.Location = new Point(12, 205);
            bookPriceLabel.ForeColor = Color.Black;
            bookPriceLabel.Font = new Font("Candara", 10f, FontStyle.Regular);
            bookPriceLabel.Tag = book.isbn;

            //Add controls to panel
            panel.Controls.Add(picBox);
            panel.Controls.Add(titleLabel);
            panel.Controls.Add(authorLabel);
            panel.Controls.Add(bookPriceLabel);


        }

        //opens BookPage
        private void PicBox_Click(object sender, EventArgs e, Book book)
        {
            BookPage bp = new BookPage(book, this.containerForm);
            this.containerForm.LoadForm(bp);
            this.containerForm.Show();
            //this.Close();
        }

        private void GetBooks(string query)
        {
            // MessageBox.Show("The search bar is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            NpgsqlConnection connection = DBHandler.OpenConnection();
            NpgsqlCommand command = DBHandler.GetCommand(connection);
            command.CommandText = query;
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                Books.Clear();
                while (reader.Read())
                {
                    Book book = new Book(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetFloat(5), reader.GetString(6));
                    Books.Add(book);

                }

                for (int i = 0; i < Books.Count; i++)
                {
                    AddBookToUI(Books[i]);
                }
            }
            else
            {
                //No books were found
            }
            reader.Close();
            DBHandler.CloseConnection(connection, command);
        }

        private void SearchLabel_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            if (String.IsNullOrWhiteSpace(searchBar.Text))
            {
                // MessageBox.Show("The search bar is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.GetBooks("SELECT * FROM books;");
            }
            else
            {
                this.GetBooks("SELECT * FROM books WHERE title like '%" + searchBar.Text + "%';");
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.GetBooks("SELECT * FROM books;");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Books.Count == 0)
            {
                MessageBox.Show("The search bar is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            flowLayoutPanel.Controls.Clear();

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Books = Books.OrderBy(book => book.title).ToList();
                    for (int i = 0; i < Books.Count; i++)
                    {
                        AddBookToUI(Books[i]);
                    }
                    break;
                case 1:
                    Books = Books.OrderBy(book => book.author).ToList();
                    for (int i = 0; i < Books.Count; i++)
                    {
                        AddBookToUI(Books[i]);
                    }
                    break;
                default:
                    Books = Books.OrderBy(book => book.price).ToList();
                    for (int i = 0; i < Books.Count; i++)
                    {
                        AddBookToUI(Books[i]);
                    }
                    break;
            }

        }

        private void label_scifi_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            List<Book> scifiBooks = Books.FindAll(book => book.category == "Science Fiction");
            foreach (Book book in scifiBooks)
            {
                AddBookToUI(book);
            }
        }

        private void label_romance_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            List<Book> romBooks = Books.FindAll(book => book.category == "Romance");
            foreach (Book book in romBooks)
            {
                AddBookToUI(book);
            }
        }

        private void label_mystery_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            List<Book> mystBooks = Books.FindAll(book => book.category == "Mystery");
            foreach (Book book in mystBooks)
            {
                AddBookToUI(book);
            }
        }

        private void label_horror_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            List<Book> horrorBooks = Books.FindAll(book => book.category == "Horror");
            foreach (Book book in horrorBooks)
            {
                AddBookToUI(book);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}

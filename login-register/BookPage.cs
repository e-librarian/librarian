using login_register.Properties;
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
    public partial class BookPage : Form
    {
        private ContainerForm containerForm;
        private Book book;
        private int stars;

        public BookPage(Book book, ContainerForm containerForm)
        {
            InitializeComponent();
            this.book = book;
            this.containerForm = containerForm;
            stars = 0;
            coverPictureBox.Load(book.cover);
            bookTitle.Text = book.title;
            authorLabel.Text = "by " + book.author;
            categoryLabel.Text = "Category: " + book.category;
            plotText.Text = book.plot;
            isbnLabel.Text = "ISBN: " + book.isbn;
            buyButton.Text = "Buy: " + book.price.ToString() + "€";

            //Reviews
            List<Review> reviews = Review.GetReviews("SELECT * FROM reviews WHERE isbn='" + book.isbn + "';");
            for (int i = 0; i < reviews.Count; i++)
            {
                AddReviewToUI(reviews[i]);
            }
        }
        private void AddReviewToUI(Review review)
        {
            Panel panel1 = new Panel();

            panel1.BackColor = Color.FromArgb(73, 60, 52);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Margin = new Padding(10);
            panel1.Name = String.Format("ReviewPanel{0}", review.id);
            panel1.Size = new Size(375, 179);
            panel1.TabIndex = 0;

            reviewsFlowLayoutPanel.Controls.Add(panel1);

            PictureBox pfpBox = new PictureBox();
            pfpBox.Image = Properties.Resources.book_41626;
            pfpBox.BackColor = Color.FromArgb(73, 60, 52);
            pfpBox.Location = new Point(9, 3);
            pfpBox.Name = String.Format("ReviewPfpBox{0}", review.id);
            pfpBox.Size = new Size(40, 40);
            pfpBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pfpBox.TabIndex = 28;
            pfpBox.TabStop = false;

            Label usernameLabel = new Label();
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.FromArgb(73, 60, 52);
            usernameLabel.Cursor = Cursors.Hand;
            usernameLabel.Font = new Font("Candara", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.PapayaWhip;
            usernameLabel.Location = new Point(55, 12);
            usernameLabel.Name = String.Format("ReviewLabel{0}", review.id);
            usernameLabel.Size = new Size(65, 26);
            usernameLabel.TabIndex = 27;
            usernameLabel.Text = review.username;

            RichTextBox richTextBox1 = new RichTextBox();
            richTextBox1.BackColor = Color.FromArgb(73, 60, 52);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Candara", 14.25F, FontStyle.Italic);
            richTextBox1.ForeColor = Color.PapayaWhip;
            richTextBox1.Location = new Point(9, 49);
            richTextBox1.Name = String.Format("ReviewRichTextBox{0}", review.id);
            richTextBox1.Size = new Size(346, 125);
            richTextBox1.TabIndex = 34;
            richTextBox1.Text = review.text;

            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Location = new Point(200, 8);
            pictureBox1.Name = String.Format("ReviewPictureBox1{0}", review.id);
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;

            PictureBox pictureBox2 = new PictureBox();
            pictureBox2.Location = new Point(227, 8);
            pictureBox2.Name = String.Format("ReviewPictureBox2{0}", review.id);
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;

            PictureBox pictureBox3 = new PictureBox();
            pictureBox3.Location = new Point(254, 8);
            pictureBox3.Name = String.Format("ReviewPictureBox3{0}", review.id);
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;

            PictureBox pictureBox4 = new PictureBox();
            pictureBox4.Location = new Point(281, 8);
            pictureBox4.Name = String.Format("ReviewPictureBox4{0}", review.id);
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;

            PictureBox pictureBox5 = new PictureBox();
            pictureBox5.Location = new Point(308, 8);
            pictureBox5.Name = String.Format("ReviewPictureBox5{0}", review.id);
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 29;
            pictureBox5.TabStop = false;

            //Αστεράκια
            switch (review.stars)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.star_filled;
                    pictureBox2.Image = Properties.Resources.star_empty;
                    pictureBox3.Image = Properties.Resources.star_empty;
                    pictureBox4.Image = Properties.Resources.star_empty;
                    pictureBox5.Image = Properties.Resources.star_empty;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.star_filled;
                    pictureBox2.Image = Properties.Resources.star_filled;
                    pictureBox3.Image = Properties.Resources.star_empty;
                    pictureBox4.Image = Properties.Resources.star_empty;
                    pictureBox5.Image = Properties.Resources.star_empty;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.star_filled;
                    pictureBox2.Image = Properties.Resources.star_filled;
                    pictureBox3.Image = Properties.Resources.star_filled;
                    pictureBox4.Image = Properties.Resources.star_empty;
                    pictureBox5.Image = Properties.Resources.star_empty;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.star_filled;
                    pictureBox2.Image = Properties.Resources.star_filled;
                    pictureBox3.Image = Properties.Resources.star_filled;
                    pictureBox4.Image = Properties.Resources.star_filled;
                    pictureBox5.Image = Properties.Resources.star_empty;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.star_filled;
                    pictureBox2.Image = Properties.Resources.star_filled;
                    pictureBox3.Image = Properties.Resources.star_filled;
                    pictureBox4.Image = Properties.Resources.star_filled;
                    pictureBox5.Image = Properties.Resources.star_filled;
                    break;
                default:
                    pictureBox1.Image = Properties.Resources.star_empty;
                    pictureBox2.Image = Properties.Resources.star_empty;
                    pictureBox3.Image = Properties.Resources.star_empty;
                    pictureBox4.Image = Properties.Resources.star_empty;
                    pictureBox5.Image = Properties.Resources.star_empty;
                    break;
            }


            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pfpBox);
            panel1.Controls.Add(usernameLabel);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void star1_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star_filled;
            star2.Image = Resources.star_empty;
            star3.Image = Resources.star_empty;
            star4.Image = Resources.star_empty;
            star5.Image = Resources.star_empty;
            stars = 1;
        }

        private void star2_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star_filled;
            star2.Image = Resources.star_filled;
            star3.Image = Resources.star_empty;
            star4.Image = Resources.star_empty;
            star5.Image = Resources.star_empty;
            stars = 2;
        }

        private void star3_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star_filled;
            star2.Image = Resources.star_filled;
            star3.Image = Resources.star_filled;
            star4.Image = Resources.star_empty;
            star5.Image = Resources.star_empty;
            stars = 3;
        }

        private void star4_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star_filled;
            star2.Image = Resources.star_filled;
            star3.Image = Resources.star_filled;
            star4.Image = Resources.star_filled;
            star5.Image = Resources.star_empty;
            stars = 4;
        }

        private void star5_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star_filled;
            star2.Image = Resources.star_filled;
            star3.Image = Resources.star_filled;
            star4.Image = Resources.star_filled;
            star5.Image = Resources.star_filled;
            stars = 5;
        }
        // Bάλε κριτική 
        private void postReviewButton_Click(object sender, EventArgs e)
        {
            if (stars == 0)
            {
                MessageBox.Show("Please give a rating!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(reviewText.Text))
            {
                MessageBox.Show("Your review doesn't have any text!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string text = reviewText.Text;
                DateTime time = DateTime.Now;
                string isbn = book.isbn;    //get isbn from book here

                string query = "INSERT INTO reviews(username, isbn, text, stars, time) VALUES (@username, @isbn, @text, @stars, @timestamp)";

                using (var connection = DBHandler.OpenConnection())
                {
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        // Add parameter to the query
                        command.Parameters.AddWithValue("username", User.GetUsername());
                        command.Parameters.AddWithValue("isbn", isbn);
                        command.Parameters.AddWithValue("text", text);
                        command.Parameters.AddWithValue("stars", stars);
                        command.Parameters.AddWithValue("timestamp", time);

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Rows affected: {rowsAffected}");
                    }
                }
                MessageBox.Show("You review has been posted!", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Review> reviews = Review.GetReviews("SELECT * FROM reviews WHERE isbn='" + book.isbn + "';");
                reviewsFlowLayoutPanel.Controls.Clear();
                for (int i = 0; i < reviews.Count; i++)
                {
                    AddReviewToUI(reviews[i]);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TransactionPage transactionPage = new TransactionPage(this.book);
            this.containerForm.LoadForm(transactionPage);
            this.containerForm.Show();
            this.Close();
        }

        private void forumButton_Click(object sender, EventArgs e)
        {
            Forum forum = new Forum(this.book);
            this.containerForm.LoadForm(forum);
            this.containerForm.Show();
            this.Close();
        }

        private void bookTitle_Click(object sender, EventArgs e)
        {

        }
    }
}

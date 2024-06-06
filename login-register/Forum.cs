using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace login_register
{
    public partial class Forum : Form
    {
        Book book;
        public Forum(Book book)
        {
            InitializeComponent();
            this.book = book;
            //forumLabel1.Text = String.Format("Forum for: {0}", book.title);
            coverPictureBox.Load(book.cover);

            //Αν ο συνδεδεμένος χρήστης είναι ο συγγραφέας του βιβλίου δώσε την δυνατότητα να απαντάει σχόλια
            if (User.GetAuthor() == true && book.author == User.GetFullName())
            {
                author_answer_button.Enabled = true;
                author_answer_button.Visible = true;

                author_post_button.Enabled = true;
                author_post_button.Visible = true;
            }
            else
            {
                author_answer_button.Enabled = false;
                author_answer_button.Visible = false;

                author_post_button.Enabled = false;
                author_post_button.Visible = false;
            }

        }

        private void commentUI(Comment comment, Comment answer)
        {
            
        }

        private void postReviewButton_Click(object sender, EventArgs e)
        {
            string username = User.GetUsername();
            string isbn = book.isbn;
            string text = new_comment.Text;
            DateTime time = DateTime.Now;
            Comment comment = new Comment(username, isbn, text, false, 0, time);
            comment.InsertComment_toDB();
            new_comment.Clear();
        }
    }
}

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
using System.Xml.Linq;
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
            pictureBox1.Load(User.GetProfilePic());
            label3.Text = User.GetUsername();
            timestamp_label.Text = DateTime.Now.ToString();
            List<Comment> comments = Comment.getComments(book);
            List<Comment[]> comm_ans = Comment.getPairs(book);
            foreach (Comment comm in comments)
            {
                this.commentUI(comm);
            }
            foreach (Comment[] pair in comm_ans)
            {
                this.commentUI(pair[0], pair[1]);
            }


        }


        private void commentUI(Comment comment, Comment answer = null)
        {
            Panel comment_panel = new Panel();
            Label inside_label5 = new Label();
            Button author_post_button = new Button();
            Button author_answer_button = new Button();
            Label inside_label6 = new Label();
            RichTextBox inside_richTextBox3 = new RichTextBox();
            RichTextBox inside_richTextBox5 = new RichTextBox();
            PictureBox inside_pictureBox3 = new PictureBox();
            Label inside_label8 = new Label();

            // comment_panel
            // 
            comment_panel.BackColor = Color.PapayaWhip;
            comment_panel.BorderStyle = BorderStyle.Fixed3D;
            comment_panel.Controls.Add(inside_label5);
            comment_panel.Controls.Add(author_post_button);
            comment_panel.Controls.Add(author_answer_button);
            comment_panel.Controls.Add(inside_label6);
            comment_panel.Controls.Add(inside_richTextBox3);
            comment_panel.Controls.Add(inside_richTextBox5);
            comment_panel.Controls.Add(inside_pictureBox3);
            comment_panel.Controls.Add(inside_label8);
            comment_panel.Location = new Point(45, 8);
            comment_panel.Margin = new Padding(45, 8, 18, 18);
            comment_panel.Name = String.Format("CommentPanel{0}", comment.getID());
            comment_panel.TabIndex = 3;
            comment_panel.Size = new Size(484, 209); //ερώτηση χωρίς απάντηση

            flowLayoutPanel1.Controls.Add(comment_panel);

            // inside_label5
            // 
            inside_label5.AutoSize = true;
            inside_label5.BackColor = Color.PapayaWhip;
            inside_label5.Cursor = Cursors.Hand;
            inside_label5.Font = new Font("Candara", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inside_label5.ForeColor = Color.FromArgb(73, 60, 52);
            inside_label5.Location = new Point(9, 216);
            inside_label5.Name = String.Format("Comment_label5{0}", comment.getID());
            inside_label5.Size = new Size(146, 26);
            inside_label5.TabIndex = 41;
            inside_label5.Text = "Author Answer";
            // 
            // author_post_button
            // 
            author_post_button.BackColor = Color.FromArgb(73, 60, 52);
            author_post_button.Enabled = false;
            author_post_button.FlatStyle = FlatStyle.Flat;
            author_post_button.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            author_post_button.ForeColor = Color.PapayaWhip;
            author_post_button.Location = new Point(128, 374);
            author_post_button.Name = String.Format("author_post_button{0}", comment.getID());
            author_post_button.Size = new Size(226, 36);
            author_post_button.TabIndex = 40;
            author_post_button.Text = "Post";
            author_post_button.UseVisualStyleBackColor = false;
            author_post_button.Visible = false;
            // 
            // author_answer_button
            // 
            author_answer_button.BackColor = Color.FromArgb(73, 60, 52);
            author_answer_button.Enabled = false;
            author_answer_button.FlatStyle = FlatStyle.Flat;
            author_answer_button.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            author_answer_button.ForeColor = Color.PapayaWhip;
            author_answer_button.Location = new Point(128, 166);
            author_answer_button.Name = String.Format("author_answer_button{0}", comment.getID());
            author_answer_button.Size = new Size(226, 36);
            author_answer_button.TabIndex = 39;
            author_answer_button.Text = "Answer";
            author_answer_button.UseVisualStyleBackColor = false;
            author_answer_button.Visible = false;
            // 
            // inside_label6
            // 
            inside_label6.AutoSize = true;
            inside_label6.BackColor = Color.PapayaWhip;
            inside_label6.Cursor = Cursors.Hand;
            inside_label6.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inside_label6.ForeColor = Color.FromArgb(73, 60, 52);
            inside_label6.Location = new Point(320, 15); //(335, 15)
            inside_label6.Name = String.Format("comment_label6{0}", comment.getID());
            inside_label6.Size = new Size(98, 23);
            inside_label6.TabIndex = 37;
            inside_label6.Text = comment.getTime().ToString(); //πότε αναρτήθηκε η ερώτηση

            // inside_richTextBox5
            // 
            inside_richTextBox5.BackColor = Color.Tan;
            inside_richTextBox5.BorderStyle = BorderStyle.FixedSingle;
            inside_richTextBox5.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inside_richTextBox5.ForeColor = Color.FromArgb(73, 60, 52);
            inside_richTextBox5.Location = new Point(9, 49);
            inside_richTextBox5.Name = String.Format("comment_richTextBox{0}", comment.getID());
            inside_richTextBox5.Size = new Size(451, 108);
            inside_richTextBox5.TabIndex = 34;
            inside_richTextBox5.Text = comment.getText();
            // 
            // inside_richTextBox3
            // 
            inside_richTextBox3.BackColor = Color.PapayaWhip;
            inside_richTextBox3.BorderStyle = BorderStyle.FixedSingle;
            inside_richTextBox3.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inside_richTextBox3.ForeColor = Color.FromArgb(73, 60, 52);
            inside_richTextBox3.Location = new Point(9, 245);
            inside_richTextBox3.Name = String.Format("answer_richTextBox{0}", comment.getID());
            inside_richTextBox3.Size = new Size(451, 123);
            inside_richTextBox3.TabIndex = 36;
            inside_richTextBox3.Text = "";
            inside_richTextBox3.Enabled = false;

            // 
            // inside_pictureBox3
            // 
            inside_pictureBox3.Image = Properties.Resources.book_41626;
            inside_pictureBox3.Location = new Point(9, 3);
            inside_pictureBox3.Name = String.Format("comment_pictureBox{0}", comment.getID());
            inside_pictureBox3.Size = new Size(40, 40);
            inside_pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            inside_pictureBox3.TabIndex = 28;
            inside_pictureBox3.TabStop = false;
            // 
            // inside_label8
            // 
            inside_label8.AutoSize = true;
            inside_label8.BackColor = Color.PapayaWhip;
            inside_label8.Cursor = Cursors.Hand;
            inside_label8.Font = new Font("Candara", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inside_label8.ForeColor = Color.FromArgb(73, 60, 52);
            inside_label8.Location = new Point(55, 12);
            inside_label8.Name = String.Format("comment_label{0}", comment.getID());
            inside_label8.Size = new Size(65, 26);
            inside_label8.TabIndex = 27;
            inside_label8.Text = comment.getUsername();

            if (User.GetAuthor() == true && book.author == User.GetFullName())
            {
                if (answer == null) // εχει απαντήσει ο συγγραφέας?
                {
                    author_answer_button.Visible = true;
                    author_answer_button.Enabled = true;
                    author_post_button.Visible = true;
                    author_post_button.Enabled = true;
                    inside_richTextBox3.Enabled = true;
                    inside_richTextBox3.Visible = true;
                    // comment_panel.Size = new Size(484, 417); //ερώτηση που περιμένει απάντηση από το συγγραφέα ,φαίνεται όλο το panel
                    author_answer_button.Click += (sender, e) => Author_answer_button_Click(sender, e, comment_panel);
                    author_post_button.Click += (sender, e) => Post_answer_button_Click(sender, e, inside_richTextBox3, comment.getID());
                }
                else
                {
                    author_answer_button.Visible = false;
                    author_answer_button.Enabled = false;
                    author_post_button.Visible = false;
                    author_post_button.Enabled = false;
                    inside_richTextBox3.Enabled = false;
                    inside_richTextBox3.Text = answer.getText();
                    inside_richTextBox3.Visible = true;
                    comment_panel.Size = new Size(484, 417); //ερώτηση με απάντηση ,φαίνεται όλο το panel
                }


            }
            else //o user δεν είναι author 
            {
                if (answer == null)
                {
                    author_answer_button.Visible = false;
                    author_answer_button.Enabled = false;
                    author_post_button.Visible = false;
                    author_post_button.Enabled = false;
                    inside_richTextBox3.Enabled = false;
                    inside_richTextBox3.Visible = false;
                    comment_panel.Size = new Size(484, 209); //ερώτηση χωρίς απάντηση
                }
                else
                {
                    author_answer_button.Visible = false;
                    author_answer_button.Enabled = false;
                    author_post_button.Visible = false;
                    author_post_button.Enabled = false;
                    inside_richTextBox3.Enabled = false;
                    inside_richTextBox3.Text = answer.getText();
                    inside_richTextBox3.Visible = true;
                    comment_panel.Size = new Size(484, 417); //ερώτηση με απάντηση ,φαίνεται όλο το panel
                }
            }

        }
        private void Author_answer_button_Click(object sender, EventArgs e, Panel panel)
        {
            if (panel.Size == new Size(484, 417))
            {
                panel.Size = new Size(484, 209); //ερώτηση χωρίς απάντηση
                
            }
            else
            {
                panel.Size = new Size(484, 417); //δείξε όλο το panel
            }
        }
        private void Post_answer_button_Click(object sender, EventArgs e, RichTextBox richText, int ID)
        {
            Comment answer = new Comment(User.GetUsername(), book.isbn, richText.Text, true, ID, DateTime.Now);
            answer.InsertComment_toDB();
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
            flowLayoutPanel1.Controls.Clear();
            List<Comment> comments = Comment.getComments(book);
            List<Comment[]> comm_ans = Comment.getPairs(book);
            foreach (Comment comm in comments)
            {
                this.commentUI(comm);
            }
            foreach (Comment[] pair in comm_ans)
            {
                this.commentUI(pair[0], pair[1]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Comment[]> comm_ans = Comment.getPairs(book);
            flowLayoutPanel1.Controls.Clear();
            foreach (Comment[] pair in comm_ans)
            {
                this.commentUI(pair[0], pair[1]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Comment> comments = Comment.getComments(book);
            flowLayoutPanel1.Controls.Clear();
            foreach (Comment comm in comments)
            {
                this.commentUI(comm);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Comment> comments = Comment.getComments(book);
            List<Comment[]> comm_ans = Comment.getPairs(book);
            foreach (Comment comm in comments)
            {
                this.commentUI(comm);
            }
            foreach (Comment[] pair in comm_ans)
            {
                this.commentUI(pair[0], pair[1]);
            }
        }
    }
}

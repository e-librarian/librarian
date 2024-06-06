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
    public partial class Forum : Form
    {
        Book book;
        public Forum(Book book)
        {
            InitializeComponent();
            this.book = book;
            //forumLabel1.Text = String.Format("Forum for: {0}", book.title);
            coverPictureBox.Load(book.cover);
        }
    }
}

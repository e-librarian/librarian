namespace login_register
{
    partial class AuthorPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            profCover = new PictureBox();
            scroll_panel2 = new Panel();
            pictureBox2 = new PictureBox();
            authorNameLabel = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            button1 = new Button();
            plot_richTextBox = new RichTextBox();
            label1 = new Label();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            cover_label = new Label();
            cover_textBox = new TextBox();
            isbn_label = new Label();
            isbn_textBox = new TextBox();
            price_label = new Label();
            price_textBox = new TextBox();
            author_label = new Label();
            author_textBox = new TextBox();
            category_label = new Label();
            title_label = new Label();
            title_textBox = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            authorUsernameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)profCover).BeginInit();
            scroll_panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // profCover
            // 
            profCover.Dock = DockStyle.Top;
            profCover.Image = Properties.Resources.profCover;
            profCover.Location = new Point(0, 0);
            profCover.Name = "profCover";
            profCover.Size = new Size(1273, 116);
            profCover.SizeMode = PictureBoxSizeMode.StretchImage;
            profCover.TabIndex = 6;
            profCover.TabStop = false;
            // 
            // scroll_panel2
            // 
            scroll_panel2.AutoScroll = true;
            scroll_panel2.Controls.Add(pictureBox2);
            scroll_panel2.Controls.Add(authorNameLabel);
            scroll_panel2.Controls.Add(pictureBox1);
            scroll_panel2.Controls.Add(panel1);
            scroll_panel2.Controls.Add(label2);
            scroll_panel2.Controls.Add(authorUsernameLabel);
            scroll_panel2.Dock = DockStyle.Bottom;
            scroll_panel2.Location = new Point(0, 114);
            scroll_panel2.Name = "scroll_panel2";
            scroll_panel2.Size = new Size(1273, 602);
            scroll_panel2.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Sienna;
            pictureBox2.Location = new Point(12, 744);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(535, 341);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // authorNameLabel
            // 
            authorNameLabel.AutoSize = true;
            authorNameLabel.Font = new Font("Candara", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorNameLabel.ForeColor = Color.PapayaWhip;
            authorNameLabel.Location = new Point(138, 27);
            authorNameLabel.Name = "authorNameLabel";
            authorNameLabel.Size = new Size(138, 36);
            authorNameLabel.TabIndex = 2;
            authorNameLabel.Text = "Full Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(11, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(73, 60, 52);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(plot_richTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(470, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 481);
            panel1.TabIndex = 11;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.PapayaWhip;
            label4.Location = new Point(46, 288);
            label4.Name = "label4";
            label4.Size = new Size(52, 23);
            label4.TabIndex = 19;
            label4.Text = "Plot :";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(73, 60, 52);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Candara", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(186, 252, 203);
            button1.Location = new Point(270, 397);
            button1.Name = "button1";
            button1.Size = new Size(205, 56);
            button1.TabIndex = 18;
            button1.Text = "ADD BOOK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // plot_richTextBox
            // 
            plot_richTextBox.BackColor = Color.PapayaWhip;
            plot_richTextBox.BorderStyle = BorderStyle.None;
            plot_richTextBox.Font = new Font("Candara", 12F);
            plot_richTextBox.Location = new Point(144, 226);
            plot_richTextBox.Name = "plot_richTextBox";
            plot_richTextBox.Size = new Size(524, 152);
            plot_richTextBox.TabIndex = 17;
            plot_richTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PapayaWhip;
            label1.Location = new Point(216, 7);
            label1.Name = "label1";
            label1.Size = new Size(318, 36);
            label1.TabIndex = 8;
            label1.Text = "Add a Book in the Library";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.PapayaWhip;
            label3.Location = new Point(46, 698);
            label3.Name = "label3";
            label3.Size = new Size(52, 23);
            label3.TabIndex = 16;
            label3.Text = "Plot :";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(73, 60, 52);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.6851215F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.3158455F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.6831951F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.3158455F));
            tableLayoutPanel1.Controls.Add(cover_label, 2, 2);
            tableLayoutPanel1.Controls.Add(cover_textBox, 3, 2);
            tableLayoutPanel1.Controls.Add(isbn_label, 0, 2);
            tableLayoutPanel1.Controls.Add(isbn_textBox, 0, 2);
            tableLayoutPanel1.Controls.Add(price_label, 2, 1);
            tableLayoutPanel1.Controls.Add(price_textBox, 3, 1);
            tableLayoutPanel1.Controls.Add(author_label, 0, 1);
            tableLayoutPanel1.Controls.Add(author_textBox, 1, 1);
            tableLayoutPanel1.Controls.Add(category_label, 2, 0);
            tableLayoutPanel1.Controls.Add(title_label, 0, 0);
            tableLayoutPanel1.Controls.Add(title_textBox, 1, 0);
            tableLayoutPanel1.Controls.Add(comboBox1, 3, 0);
            tableLayoutPanel1.Location = new Point(43, 56);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(642, 154);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // cover_label
            // 
            cover_label.Anchor = AnchorStyles.Left;
            cover_label.AutoSize = true;
            cover_label.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cover_label.ForeColor = Color.PapayaWhip;
            cover_label.Location = new Point(323, 116);
            cover_label.Name = "cover_label";
            cover_label.Size = new Size(66, 23);
            cover_label.TabIndex = 11;
            cover_label.Text = "Cover :";
            // 
            // cover_textBox
            // 
            cover_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cover_textBox.BackColor = Color.PapayaWhip;
            cover_textBox.Font = new Font("Candara", 12F);
            cover_textBox.Location = new Point(423, 114);
            cover_textBox.Name = "cover_textBox";
            cover_textBox.Size = new Size(216, 27);
            cover_textBox.TabIndex = 10;
            // 
            // isbn_label
            // 
            isbn_label.Anchor = AnchorStyles.Left;
            isbn_label.AutoSize = true;
            isbn_label.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isbn_label.ForeColor = Color.PapayaWhip;
            isbn_label.Location = new Point(3, 116);
            isbn_label.Name = "isbn_label";
            isbn_label.Size = new Size(58, 23);
            isbn_label.TabIndex = 15;
            isbn_label.Text = "ISBN :";
            // 
            // isbn_textBox
            // 
            isbn_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            isbn_textBox.BackColor = Color.PapayaWhip;
            isbn_textBox.Font = new Font("Candara", 12F);
            isbn_textBox.Location = new Point(103, 114);
            isbn_textBox.Name = "isbn_textBox";
            isbn_textBox.Size = new Size(214, 27);
            isbn_textBox.TabIndex = 14;
            // 
            // price_label
            // 
            price_label.Anchor = AnchorStyles.Left;
            price_label.AutoSize = true;
            price_label.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price_label.ForeColor = Color.PapayaWhip;
            price_label.Location = new Point(323, 65);
            price_label.Name = "price_label";
            price_label.Size = new Size(60, 23);
            price_label.TabIndex = 13;
            price_label.Text = "Price :";
            // 
            // price_textBox
            // 
            price_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            price_textBox.BackColor = Color.PapayaWhip;
            price_textBox.Font = new Font("Candara", 12F);
            price_textBox.Location = new Point(423, 63);
            price_textBox.Name = "price_textBox";
            price_textBox.Size = new Size(216, 27);
            price_textBox.TabIndex = 12;
            // 
            // author_label
            // 
            author_label.Anchor = AnchorStyles.Left;
            author_label.AutoSize = true;
            author_label.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            author_label.ForeColor = Color.PapayaWhip;
            author_label.Location = new Point(3, 65);
            author_label.Name = "author_label";
            author_label.Size = new Size(76, 23);
            author_label.TabIndex = 11;
            author_label.Text = "Author :";
            // 
            // author_textBox
            // 
            author_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            author_textBox.BackColor = Color.PapayaWhip;
            author_textBox.Font = new Font("Candara", 12F);
            author_textBox.Location = new Point(103, 63);
            author_textBox.Name = "author_textBox";
            author_textBox.Size = new Size(214, 27);
            author_textBox.TabIndex = 10;
            // 
            // category_label
            // 
            category_label.Anchor = AnchorStyles.Left;
            category_label.AutoSize = true;
            category_label.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            category_label.ForeColor = Color.PapayaWhip;
            category_label.Location = new Point(323, 14);
            category_label.Name = "category_label";
            category_label.Size = new Size(92, 23);
            category_label.TabIndex = 9;
            category_label.Text = "Category :";
            // 
            // title_label
            // 
            title_label.Anchor = AnchorStyles.Left;
            title_label.AutoSize = true;
            title_label.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title_label.ForeColor = Color.PapayaWhip;
            title_label.Location = new Point(3, 14);
            title_label.Name = "title_label";
            title_label.Size = new Size(54, 23);
            title_label.TabIndex = 7;
            title_label.Text = "Title :";
            // 
            // title_textBox
            // 
            title_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            title_textBox.BackColor = Color.PapayaWhip;
            title_textBox.Font = new Font("Candara", 12F);
            title_textBox.Location = new Point(103, 12);
            title_textBox.Name = "title_textBox";
            title_textBox.Size = new Size(214, 27);
            title_textBox.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left;
            comboBox1.BackColor = Color.PapayaWhip;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Candara", 14.25F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Horror", "Science Fiction", "Romance", "Mystery" });
            comboBox1.Location = new Point(423, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(216, 31);
            comboBox1.TabIndex = 16;
            comboBox1.Text = "Mystery";
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PapayaWhip;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(73, 60, 52);
            label2.Location = new Point(138, 106);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 4;
            label2.Text = "Author ✔";
            // 
            // authorUsernameLabel
            // 
            authorUsernameLabel.AutoSize = true;
            authorUsernameLabel.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorUsernameLabel.ForeColor = Color.PapayaWhip;
            authorUsernameLabel.Location = new Point(138, 63);
            authorUsernameLabel.Name = "authorUsernameLabel";
            authorUsernameLabel.Size = new Size(109, 23);
            authorUsernameLabel.TabIndex = 6;
            authorUsernameLabel.Text = "@username";
            // 
            // AuthorPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Tan;
            ClientSize = new Size(1273, 716);
            Controls.Add(scroll_panel2);
            Controls.Add(profCover);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthorPage";
            Text = "AuthorPage";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)profCover).EndInit();
            scroll_panel2.ResumeLayout(false);
            scroll_panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox profCover;
        private Panel scroll_panel2;
        private PictureBox pictureBox2;
        private Label authorNameLabel;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button1;
        private RichTextBox plot_richTextBox;
        private Label label1;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label cover_label;
        private TextBox cover_textBox;
        private Label isbn_label;
        private TextBox isbn_textBox;
        private Label price_label;
        private TextBox price_textBox;
        private Label author_label;
        private TextBox author_textBox;
        private Label category_label;
        private Label title_label;
        private TextBox title_textBox;
        private Label label2;
        private Label authorUsernameLabel;
        private Label label4;
        private ComboBox comboBox1;
    }
}
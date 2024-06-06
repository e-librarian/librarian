namespace login_register
{
    partial class BookPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookPage));
            coverPictureBox = new PictureBox();
            bookTitle = new Label();
            plotText = new RichTextBox();
            authorLabel = new Label();
            isbnLabel = new Label();
            categoryLabel = new Label();
            forumButton = new Button();
            buyButton = new Button();
            reviewsFlowLayoutPanel = new FlowLayoutPanel();
            reviewsLabel = new Label();
            label1 = new Label();
            reviewText = new RichTextBox();
            postReviewButton = new Button();
            label2 = new Label();
            star1 = new PictureBox();
            star5 = new PictureBox();
            star4 = new PictureBox();
            star3 = new PictureBox();
            star2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)coverPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // coverPictureBox
            // 
            coverPictureBox.BackgroundImageLayout = ImageLayout.None;
            coverPictureBox.Image = Properties.Resources._71wM_BB9mtL__AC_UF1000_1000_QL80_;
            coverPictureBox.Location = new Point(66, 13);
            coverPictureBox.Name = "coverPictureBox";
            coverPictureBox.Size = new Size(226, 339);
            coverPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            coverPictureBox.TabIndex = 0;
            coverPictureBox.TabStop = false;
            // 
            // bookTitle
            // 
            bookTitle.AutoSize = true;
            bookTitle.Font = new Font("Candara", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookTitle.Location = new Point(311, 31);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(67, 33);
            bookTitle.TabIndex = 1;
            bookTitle.Text = "Title";
            // 
            // plotText
            // 
            plotText.BackColor = Color.PapayaWhip;
            plotText.BorderStyle = BorderStyle.None;
            plotText.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plotText.Location = new Point(318, 138);
            plotText.Name = "plotText";
            plotText.Size = new Size(374, 134);
            plotText.TabIndex = 2;
            plotText.Text = resources.GetString("plotText.Text");
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorLabel.Location = new Point(318, 64);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(94, 19);
            authorLabel.TabIndex = 3;
            authorLabel.Text = "by Author A.";
            // 
            // isbnLabel
            // 
            isbnLabel.AutoSize = true;
            isbnLabel.Font = new Font("Candara", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isbnLabel.Location = new Point(318, 298);
            isbnLabel.Name = "isbnLabel";
            isbnLabel.Size = new Size(41, 15);
            isbnLabel.TabIndex = 4;
            isbnLabel.Text = "ISBN: ";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryLabel.Location = new Point(318, 100);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(140, 19);
            categoryLabel.TabIndex = 5;
            categoryLabel.Text = "Category: Category";
            // 
            // forumButton
            // 
            forumButton.BackColor = Color.FromArgb(73, 60, 52);
            forumButton.FlatStyle = FlatStyle.Flat;
            forumButton.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            forumButton.ForeColor = Color.PapayaWhip;
            forumButton.Location = new Point(66, 378);
            forumButton.Name = "forumButton";
            forumButton.Size = new Size(226, 36);
            forumButton.TabIndex = 6;
            forumButton.Text = "Visit Forum 🗨";
            forumButton.UseVisualStyleBackColor = false;
            forumButton.Click += forumButton_Click;
            // 
            // buyButton
            // 
            buyButton.BackColor = Color.FromArgb(73, 60, 52);
            buyButton.FlatStyle = FlatStyle.Flat;
            buyButton.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buyButton.ForeColor = Color.PapayaWhip;
            buyButton.Location = new Point(311, 378);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(226, 36);
            buyButton.TabIndex = 7;
            buyButton.Text = "Buy: 15,99€";
            buyButton.UseVisualStyleBackColor = false;
            buyButton.Click += button1_Click;
            // 
            // reviewsFlowLayoutPanel
            // 
            reviewsFlowLayoutPanel.AutoScroll = true;
            reviewsFlowLayoutPanel.BackColor = Color.FromArgb(73, 60, 52);
            reviewsFlowLayoutPanel.Dock = DockStyle.Bottom;
            reviewsFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            reviewsFlowLayoutPanel.Location = new Point(0, 456);
            reviewsFlowLayoutPanel.Name = "reviewsFlowLayoutPanel";
            reviewsFlowLayoutPanel.Size = new Size(1273, 260);
            reviewsFlowLayoutPanel.TabIndex = 8;
            // 
            // reviewsLabel
            // 
            reviewsLabel.AutoSize = true;
            reviewsLabel.BackColor = Color.FromArgb(73, 60, 52);
            reviewsLabel.Dock = DockStyle.Bottom;
            reviewsLabel.FlatStyle = FlatStyle.Flat;
            reviewsLabel.Font = new Font("Candara", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reviewsLabel.ForeColor = Color.PapayaWhip;
            reviewsLabel.Location = new Point(0, 423);
            reviewsLabel.Name = "reviewsLabel";
            reviewsLabel.Size = new Size(111, 33);
            reviewsLabel.TabIndex = 9;
            reviewsLabel.Text = "Reviews";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(782, 31);
            label1.Name = "label1";
            label1.Size = new Size(173, 26);
            label1.TabIndex = 10;
            label1.Text = "Already read this?";
            // 
            // reviewText
            // 
            reviewText.BackColor = Color.PapayaWhip;
            reviewText.BorderStyle = BorderStyle.FixedSingle;
            reviewText.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reviewText.Location = new Point(782, 174);
            reviewText.Name = "reviewText";
            reviewText.Size = new Size(428, 169);
            reviewText.TabIndex = 11;
            reviewText.Text = "";
            // 
            // postReviewButton
            // 
            postReviewButton.BackColor = Color.FromArgb(73, 60, 52);
            postReviewButton.FlatStyle = FlatStyle.Flat;
            postReviewButton.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            postReviewButton.ForeColor = Color.PapayaWhip;
            postReviewButton.Location = new Point(782, 378);
            postReviewButton.Name = "postReviewButton";
            postReviewButton.Size = new Size(226, 36);
            postReviewButton.TabIndex = 12;
            postReviewButton.Text = "Post";
            postReviewButton.UseVisualStyleBackColor = false;
            postReviewButton.Click += postReviewButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(782, 60);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 13;
            label2.Text = "Rate it!";
            label2.Click += label2_Click;
            // 
            // star1
            // 
            star1.Image = Properties.Resources.star_empty;
            star1.Location = new Point(782, 112);
            star1.Name = "star1";
            star1.Size = new Size(30, 30);
            star1.SizeMode = PictureBoxSizeMode.StretchImage;
            star1.TabIndex = 14;
            star1.TabStop = false;
            star1.Click += star1_Click;
            // 
            // star5
            // 
            star5.Image = Properties.Resources.star_empty;
            star5.Location = new Point(889, 112);
            star5.Name = "star5";
            star5.Size = new Size(30, 30);
            star5.SizeMode = PictureBoxSizeMode.StretchImage;
            star5.TabIndex = 15;
            star5.TabStop = false;
            star5.Click += star5_Click;
            // 
            // star4
            // 
            star4.Image = Properties.Resources.star_empty;
            star4.Location = new Point(862, 112);
            star4.Name = "star4";
            star4.Size = new Size(30, 30);
            star4.SizeMode = PictureBoxSizeMode.StretchImage;
            star4.TabIndex = 16;
            star4.TabStop = false;
            star4.Click += star4_Click;
            // 
            // star3
            // 
            star3.Image = Properties.Resources.star_empty;
            star3.Location = new Point(836, 112);
            star3.Name = "star3";
            star3.Size = new Size(30, 30);
            star3.SizeMode = PictureBoxSizeMode.StretchImage;
            star3.TabIndex = 17;
            star3.TabStop = false;
            star3.Click += star3_Click;
            // 
            // star2
            // 
            star2.Image = Properties.Resources.star_empty;
            star2.Location = new Point(809, 112);
            star2.Name = "star2";
            star2.Size = new Size(30, 30);
            star2.SizeMode = PictureBoxSizeMode.StretchImage;
            star2.TabIndex = 18;
            star2.TabStop = false;
            star2.Click += star2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(73, 60, 52);
            pictureBox1.Location = new Point(726, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(3, 474);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // BookPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1273, 716);
            Controls.Add(star2);
            Controls.Add(star3);
            Controls.Add(star4);
            Controls.Add(star5);
            Controls.Add(star1);
            Controls.Add(label2);
            Controls.Add(postReviewButton);
            Controls.Add(reviewText);
            Controls.Add(label1);
            Controls.Add(reviewsLabel);
            Controls.Add(reviewsFlowLayoutPanel);
            Controls.Add(buyButton);
            Controls.Add(forumButton);
            Controls.Add(categoryLabel);
            Controls.Add(isbnLabel);
            Controls.Add(authorLabel);
            Controls.Add(plotText);
            Controls.Add(bookTitle);
            Controls.Add(coverPictureBox);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookPage";
            Text = "BookPage";
            ((System.ComponentModel.ISupportInitialize)coverPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)star1).EndInit();
            ((System.ComponentModel.ISupportInitialize)star5).EndInit();
            ((System.ComponentModel.ISupportInitialize)star4).EndInit();
            ((System.ComponentModel.ISupportInitialize)star3).EndInit();
            ((System.ComponentModel.ISupportInitialize)star2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox coverPictureBox;
        private Label bookTitle;
        private RichTextBox plotText;
        private Label authorLabel;
        private Label isbnLabel;
        private Label categoryLabel;
        private Button forumButton;
        private Button buyButton;
        private FlowLayoutPanel reviewsFlowLayoutPanel;
        private Label reviewsLabel;
        private Label label1;
        private RichTextBox reviewText;
        private Button postReviewButton;
        private Label label2;
        private PictureBox star1;
        private PictureBox star5;
        private PictureBox star4;
        private PictureBox star3;
        private PictureBox star2;
        private PictureBox pictureBox1;
    }
}
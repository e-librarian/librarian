namespace login_register
{
    partial class HomePage
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
            pictureBox9 = new PictureBox();
            splitContainer1 = new SplitContainer();
            comboBox1 = new ComboBox();
            label_sort = new Label();
            label3 = new Label();
            trackBar1 = new TrackBar();
            label_mystery = new Label();
            label_romance = new Label();
            label_scifi = new Label();
            label_horror = new Label();
            categoriesLabel = new Label();
            label5 = new Label();
            flowLayoutPanel = new FlowLayoutPanel();
            searchBar = new TextBox();
            SearchLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox9
            // 
            pictureBox9.Location = new Point(1329, 0);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(128, 209);
            pictureBox9.TabIndex = 16;
            pictureBox9.TabStop = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(73, 60, 52);
            splitContainer1.Panel1.Controls.Add(comboBox1);
            splitContainer1.Panel1.Controls.Add(label_sort);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(trackBar1);
            splitContainer1.Panel1.Controls.Add(label_mystery);
            splitContainer1.Panel1.Controls.Add(label_romance);
            splitContainer1.Panel1.Controls.Add(label_scifi);
            splitContainer1.Panel1.Controls.Add(label_horror);
            splitContainer1.Panel1.Controls.Add(categoriesLabel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel);
            splitContainer1.Panel2.Controls.Add(searchBar);
            splitContainer1.Panel2.Controls.Add(SearchLabel);
            splitContainer1.Size = new Size(1160, 704);
            splitContainer1.SplitterDistance = 228;
            splitContainer1.TabIndex = 21;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.PapayaWhip;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Candara", 14.25F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Title", "Author", "Price" });
            comboBox1.Location = new Point(39, 403);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 31);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label_sort
            // 
            label_sort.AutoSize = true;
            label_sort.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_sort.ForeColor = Color.White;
            label_sort.Location = new Point(42, 375);
            label_sort.Name = "label_sort";
            label_sort.Size = new Size(84, 25);
            label_sort.TabIndex = 43;
            label_sort.Text = "Sort By :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(39, 257);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 42;
            label3.Text = "Price";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(39, 304);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(131, 45);
            trackBar1.TabIndex = 36;
            // 
            // label_mystery
            // 
            label_mystery.AutoSize = true;
            label_mystery.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_mystery.ForeColor = Color.White;
            label_mystery.Location = new Point(39, 172);
            label_mystery.Name = "label_mystery";
            label_mystery.Size = new Size(66, 21);
            label_mystery.TabIndex = 41;
            label_mystery.Text = "Mystery";
            label_mystery.Click += label_mystery_Click;
            // 
            // label_romance
            // 
            label_romance.AutoSize = true;
            label_romance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_romance.ForeColor = Color.White;
            label_romance.Location = new Point(39, 137);
            label_romance.Name = "label_romance";
            label_romance.Size = new Size(75, 21);
            label_romance.TabIndex = 40;
            label_romance.Text = "Romance";
            label_romance.Click += label_romance_Click;
            // 
            // label_scifi
            // 
            label_scifi.AutoSize = true;
            label_scifi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_scifi.ForeColor = Color.White;
            label_scifi.Location = new Point(39, 101);
            label_scifi.Name = "label_scifi";
            label_scifi.Size = new Size(112, 21);
            label_scifi.TabIndex = 39;
            label_scifi.Text = "Science Fiction";
            label_scifi.Click += label_scifi_Click;
            // 
            // label_horror
            // 
            label_horror.AutoSize = true;
            label_horror.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_horror.ForeColor = Color.White;
            label_horror.Location = new Point(39, 66);
            label_horror.Name = "label_horror";
            label_horror.Size = new Size(57, 21);
            label_horror.TabIndex = 37;
            label_horror.Text = "Horror";
            label_horror.Click += label_horror_Click;
            // 
            // categoriesLabel
            // 
            categoriesLabel.AutoSize = true;
            categoriesLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoriesLabel.ForeColor = Color.White;
            categoriesLabel.Location = new Point(39, 27);
            categoriesLabel.Name = "categoriesLabel";
            categoriesLabel.Size = new Size(103, 25);
            categoriesLabel.TabIndex = 38;
            categoriesLabel.Text = "Categories";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label5.ForeColor = Color.FromArgb(73, 60, 52);
            label5.ImageAlign = ContentAlignment.BottomCenter;
            label5.Location = new Point(3, 14);
            label5.Name = "label5";
            label5.Size = new Size(490, 39);
            label5.TabIndex = 38;
            label5.Text = "Your Journey Through Pages Begins Here";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.UseCompatibleTextRendering = true;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Location = new Point(3, 66);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(913, 626);
            flowLayoutPanel.TabIndex = 41;
            // 
            // searchBar
            // 
            searchBar.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBar.Location = new Point(533, 17);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(242, 31);
            searchBar.TabIndex = 39;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Cursor = Cursors.Hand;
            SearchLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchLabel.ForeColor = Color.FromArgb(73, 60, 52);
            SearchLabel.Location = new Point(781, 18);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(42, 30);
            SearchLabel.TabIndex = 40;
            SearchLabel.Text = "🔍";
            SearchLabel.Click += SearchLabel_Click;
            // 
            // HomePage
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1160, 704);
            Controls.Add(splitContainer1);
            Controls.Add(pictureBox9);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox9;
        private SplitContainer splitContainer1;
        private Label label3;
        private TrackBar trackBar1;
        private Label label_mystery;
        private Label label_romance;
        private Label label_scifi;
        private Label label_horror;
        private Label categoriesLabel;
        private ComboBox comboBox1;
        private Label label_sort;
        private FlowLayoutPanel flowLayoutPanel;
        private TextBox searchBar;
        private Label SearchLabel;
        private Label label5;
    }
}

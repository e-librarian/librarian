namespace login_register
{
    partial class ContainerForm
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
            usernameLabel = new Label();
            pfpBox = new PictureBox();
            exitButton = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            bookLand = new PictureBox();
            loginOrRegister = new Label();
            ((System.ComponentModel.ISupportInitialize)pfpBox).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookLand).BeginInit();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.FromArgb(73, 60, 52);
            usernameLabel.Cursor = Cursors.Hand;
            usernameLabel.Font = new Font("Candara", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.PapayaWhip;
            usernameLabel.Location = new Point(58, 30);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(65, 26);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "label2";
            usernameLabel.Click += usernameLabel_Click;
            // 
            // pfpBox
            // 
            pfpBox.BackColor = Color.FromArgb(73, 60, 52);
            pfpBox.Location = new Point(12, 21);
            pfpBox.Name = "pfpBox";
            pfpBox.Size = new Size(40, 40);
            pfpBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pfpBox.TabIndex = 26;
            pfpBox.TabStop = false;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(73, 60, 52);
            exitButton.Cursor = Cursors.Hand;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.ForeColor = Color.PapayaWhip;
            exitButton.Location = new Point(1209, 21);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(35, 35);
            exitButton.TabIndex = 27;
            exitButton.Text = "X";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(1273, 716);
            panel1.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(73, 60, 52);
            panel2.Controls.Add(bookLand);
            panel2.Controls.Add(loginOrRegister);
            panel2.Controls.Add(exitButton);
            panel2.Controls.Add(pfpBox);
            panel2.Controls.Add(usernameLabel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1273, 82);
            panel2.TabIndex = 30;
            // 
            // bookLand
            // 
            bookLand.BackColor = Color.FromArgb(73, 60, 52);
            bookLand.Cursor = Cursors.Hand;
            bookLand.Image = Properties.Resources.text_1717247010360;
            bookLand.Location = new Point(469, 21);
            bookLand.Name = "bookLand";
            bookLand.Size = new Size(329, 50);
            bookLand.SizeMode = PictureBoxSizeMode.StretchImage;
            bookLand.TabIndex = 30;
            bookLand.TabStop = false;
            bookLand.Click += bookLand_Click;
            // 
            // loginOrRegister
            // 
            loginOrRegister.AutoSize = true;
            loginOrRegister.Cursor = Cursors.Hand;
            loginOrRegister.Font = new Font("Candara", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginOrRegister.ForeColor = Color.PapayaWhip;
            loginOrRegister.Location = new Point(1077, 30);
            loginOrRegister.Name = "loginOrRegister";
            loginOrRegister.Size = new Size(107, 26);
            loginOrRegister.TabIndex = 29;
            loginOrRegister.Text = "Logout 🔘";
            loginOrRegister.Click += loginOrRegister_Click;
            // 
            // ContainerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1273, 798);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ContainerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyProfile";
            ((System.ComponentModel.ISupportInitialize)pfpBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookLand).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label usernameLabel;
        private Label label3;
        private PictureBox pfpBox;
        private Button exitButton;
        public Panel panel1;
        private Panel panel2;
        private Label loginOrRegister;
        private PictureBox bookLand;
    }
}
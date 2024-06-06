namespace login_register
{
    partial class UserPage
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
            fullNameLabel = new Label();
            pictureBox1 = new PictureBox();
            usernameLabel = new Label();
            profCover = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profCover).BeginInit();
            SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Candara", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullNameLabel.ForeColor = Color.PapayaWhip;
            fullNameLabel.Location = new Point(148, 240);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(204, 36);
            fullNameLabel.TabIndex = 0;
            fullNameLabel.Text = "Name Surname";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(30, 240);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.PapayaWhip;
            usernameLabel.Location = new Point(148, 276);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(109, 23);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "@username";
            // 
            // profCover
            // 
            profCover.Image = Properties.Resources.profCover;
            profCover.Location = new Point(0, -3);
            profCover.Name = "profCover";
            profCover.Size = new Size(1273, 218);
            profCover.SizeMode = PictureBoxSizeMode.StretchImage;
            profCover.TabIndex = 4;
            profCover.TabStop = false;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1089, 602);
            Controls.Add(profCover);
            Controls.Add(usernameLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserPage";
            Text = "UserPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)profCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fullNameLabel;
        private PictureBox pictureBox1;
        private Label usernameLabel;
        private PictureBox profCover;
    }
}
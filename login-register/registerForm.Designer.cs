namespace login_register
{
    partial class FormRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            user_label = new Label();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            label3 = new Label();
            textBoxConfPassword = new TextBox();
            label4 = new Label();
            checkBoxShowPass = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBoxFullName = new TextBox();
            label7 = new Label();
            authorCheckBox = new CheckBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(73, 60, 52);
            label1.Location = new Point(44, 42);
            label1.Name = "label1";
            label1.Size = new Size(220, 33);
            label1.TabIndex = 0;
            label1.Text = "e-Βιβλιοθηκάριος";
            label1.Click += label1_Click;
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.Font = new Font("Candara", 12F, FontStyle.Bold);
            user_label.ForeColor = Color.FromArgb(73, 60, 52);
            user_label.Location = new Point(42, 102);
            user_label.Name = "user_label";
            user_label.Size = new Size(110, 19);
            user_label.TabIndex = 1;
            user_label.Text = "Όνομα χρήστη";
            // 
            // textBoxUserName
            // 
            textBoxUserName.BackColor = Color.PapayaWhip;
            textBoxUserName.BorderStyle = BorderStyle.FixedSingle;
            textBoxUserName.Font = new Font("Candara", 14.25F);
            textBoxUserName.ForeColor = SystemColors.WindowText;
            textBoxUserName.Location = new Point(44, 124);
            textBoxUserName.Multiline = true;
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(243, 31);
            textBoxUserName.TabIndex = 2;
            textBoxUserName.TextChanged += textBoxUserName_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.PapayaWhip;
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Candara", 14.25F);
            textBoxPassword.Location = new Point(44, 249);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(243, 31);
            textBoxPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(73, 60, 52);
            label3.Location = new Point(42, 227);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 3;
            label3.Text = "Κωδικός";
            // 
            // textBoxConfPassword
            // 
            textBoxConfPassword.BackColor = Color.PapayaWhip;
            textBoxConfPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxConfPassword.Font = new Font("Candara", 14.25F);
            textBoxConfPassword.Location = new Point(44, 315);
            textBoxConfPassword.Multiline = true;
            textBoxConfPassword.Name = "textBoxConfPassword";
            textBoxConfPassword.PasswordChar = '*';
            textBoxConfPassword.Size = new Size(243, 31);
            textBoxConfPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(73, 60, 52);
            label4.Location = new Point(42, 293);
            label4.Name = "label4";
            label4.Size = new Size(163, 19);
            label4.TabIndex = 5;
            label4.Text = "Επιβεβαιώση κωδικού";
            // 
            // checkBoxShowPass
            // 
            checkBoxShowPass.AutoSize = true;
            checkBoxShowPass.Cursor = Cursors.Hand;
            checkBoxShowPass.FlatStyle = FlatStyle.Flat;
            checkBoxShowPass.ForeColor = Color.Tan;
            checkBoxShowPass.Location = new Point(44, 353);
            checkBoxShowPass.Name = "checkBoxShowPass";
            checkBoxShowPass.Size = new Size(152, 23);
            checkBoxShowPass.TabIndex = 7;
            checkBoxShowPass.Text = "Προβολή κωδικού";
            checkBoxShowPass.UseVisualStyleBackColor = true;
            checkBoxShowPass.CheckedChanged += checkBoxShowPass_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(73, 60, 52);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.PapayaWhip;
            button1.Location = new Point(44, 427);
            button1.Name = "button1";
            button1.Size = new Size(243, 39);
            button1.TabIndex = 8;
            button1.Text = "ΕΓΓΡΑΦΗ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PapayaWhip;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(73, 60, 52);
            button2.Location = new Point(44, 485);
            button2.Name = "button2";
            button2.Size = new Size(243, 39);
            button2.TabIndex = 9;
            button2.Text = "ΕΚΚΑΘΑΡΙΣΗ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(90, 549);
            label5.Name = "label5";
            label5.Size = new Size(153, 19);
            label5.TabIndex = 10;
            label5.Text = "Έχω ήδη λογαριασμό";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(73, 60, 52);
            label6.Location = new Point(85, 577);
            label6.Name = "label6";
            label6.Size = new Size(162, 23);
            label6.TabIndex = 11;
            label6.Text = "Πίσω στην ΕΙΣΟΔΟ";
            label6.Click += label6_Click;
            // 
            // textBoxFullName
            // 
            textBoxFullName.BackColor = Color.PapayaWhip;
            textBoxFullName.BorderStyle = BorderStyle.FixedSingle;
            textBoxFullName.Font = new Font("Candara", 14.25F);
            textBoxFullName.Location = new Point(44, 187);
            textBoxFullName.Multiline = true;
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(243, 31);
            textBoxFullName.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(73, 60, 52);
            label7.Location = new Point(42, 165);
            label7.Name = "label7";
            label7.Size = new Size(127, 19);
            label7.TabIndex = 12;
            label7.Text = "Ονοματεπώνυμο";
            label7.Click += label7_Click;
            // 
            // authorCheckBox
            // 
            authorCheckBox.AutoSize = true;
            authorCheckBox.Cursor = Cursors.Hand;
            authorCheckBox.FlatStyle = FlatStyle.Flat;
            authorCheckBox.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            authorCheckBox.ForeColor = Color.FromArgb(73, 60, 52);
            authorCheckBox.Location = new Point(44, 383);
            authorCheckBox.Name = "authorCheckBox";
            authorCheckBox.Size = new Size(152, 23);
            authorCheckBox.TabIndex = 14;
            authorCheckBox.Text = "Είμαι συγγραφέας!";
            authorCheckBox.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.Tan;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Candara", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(73, 60, 52);
            button3.Location = new Point(290, 11);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(40, 40);
            button3.TabIndex = 25;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(341, 638);
            Controls.Add(button3);
            Controls.Add(authorCheckBox);
            Controls.Add(textBoxFullName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBoxShowPass);
            Controls.Add(textBoxConfPassword);
            Controls.Add(label4);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxUserName);
            Controls.Add(user_label);
            Controls.Add(label1);
            Font = new Font("Candara", 12F);
            ForeColor = Color.Tan;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTER";
            Load += FormRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label user_label;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private Label label3;
        private TextBox textBoxConfPassword;
        private Label label4;
        private CheckBox checkBoxShowPass;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private TextBox textBoxFullName;
        private Label label7;
        private CheckBox authorCheckBox;
        private Button button3;
    }
}

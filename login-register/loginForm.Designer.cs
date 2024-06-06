namespace login_register
{
    partial class loginForm
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
            label6 = new Label();
            label5 = new Label();
            buttonClearLOGIN = new Button();
            buttonLOGIN = new Button();
            checkBoxShowPass = new CheckBox();
            textBoxPassword = new TextBox();
            label3 = new Label();
            textBoxUserName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(73, 60, 52);
            label6.Location = new Point(98, 444);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(134, 23);
            label6.TabIndex = 23;
            label6.Text = "Create Account";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 12F);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(87, 414);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(166, 19);
            label5.TabIndex = 22;
            label5.Text = "Don't Have An Account";
            label5.Click += label5_Click;
            // 
            // buttonClearLOGIN
            // 
            buttonClearLOGIN.BackColor = Color.PapayaWhip;
            buttonClearLOGIN.Cursor = Cursors.Hand;
            buttonClearLOGIN.FlatStyle = FlatStyle.Flat;
            buttonClearLOGIN.Font = new Font("Candara", 12F);
            buttonClearLOGIN.ForeColor = Color.FromArgb(73, 60, 52);
            buttonClearLOGIN.Location = new Point(49, 342);
            buttonClearLOGIN.Margin = new Padding(2);
            buttonClearLOGIN.Name = "buttonClearLOGIN";
            buttonClearLOGIN.Size = new Size(243, 39);
            buttonClearLOGIN.TabIndex = 21;
            buttonClearLOGIN.Text = "CLEAR";
            buttonClearLOGIN.UseVisualStyleBackColor = false;
            buttonClearLOGIN.Click += buttonClearLOGIN_Click;
            // 
            // buttonLOGIN
            // 
            buttonLOGIN.BackColor = Color.FromArgb(73, 60, 52);
            buttonLOGIN.Cursor = Cursors.Hand;
            buttonLOGIN.FlatAppearance.BorderSize = 0;
            buttonLOGIN.FlatStyle = FlatStyle.Flat;
            buttonLOGIN.Font = new Font("Candara", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLOGIN.ForeColor = Color.PapayaWhip;
            buttonLOGIN.Location = new Point(49, 289);
            buttonLOGIN.Margin = new Padding(2);
            buttonLOGIN.Name = "buttonLOGIN";
            buttonLOGIN.Size = new Size(243, 39);
            buttonLOGIN.TabIndex = 20;
            buttonLOGIN.Text = "LOGIN";
            buttonLOGIN.UseVisualStyleBackColor = false;
            buttonLOGIN.Click += buttonLOGIN_Click;
            // 
            // checkBoxShowPass
            // 
            checkBoxShowPass.AutoSize = true;
            checkBoxShowPass.Cursor = Cursors.Hand;
            checkBoxShowPass.FlatStyle = FlatStyle.Flat;
            checkBoxShowPass.Font = new Font("Candara", 12F);
            checkBoxShowPass.ForeColor = Color.Tan;
            checkBoxShowPass.Location = new Point(152, 239);
            checkBoxShowPass.Margin = new Padding(2);
            checkBoxShowPass.Name = "checkBoxShowPass";
            checkBoxShowPass.Size = new Size(133, 23);
            checkBoxShowPass.TabIndex = 19;
            checkBoxShowPass.Text = "Show Password";
            checkBoxShowPass.UseVisualStyleBackColor = true;
            checkBoxShowPass.CheckedChanged += checkBoxShowPass_CheckedChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.PapayaWhip;
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(49, 207);
            textBoxPassword.Margin = new Padding(2);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(236, 28);
            textBoxPassword.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(73, 60, 52);
            label3.Location = new Point(46, 186);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 19);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // textBoxUserName
            // 
            textBoxUserName.BackColor = Color.PapayaWhip;
            textBoxUserName.BorderStyle = BorderStyle.FixedSingle;
            textBoxUserName.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUserName.Location = new Point(49, 137);
            textBoxUserName.Margin = new Padding(2);
            textBoxUserName.Multiline = true;
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(236, 29);
            textBoxUserName.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(73, 60, 52);
            label2.Location = new Point(46, 116);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 13;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(73, 60, 52);
            label1.Location = new Point(46, 51);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 33);
            label1.TabIndex = 12;
            label1.Text = "Bookland";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Tan;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Candara", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(290, 11);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 24;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(341, 500);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(buttonClearLOGIN);
            Controls.Add(buttonLOGIN);
            Controls.Add(checkBoxShowPass);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Candara", 8.25F);
            ForeColor = Color.FromArgb(73, 60, 52);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            Load += loginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button buttonClearLOGIN;
        private Button buttonLOGIN;
        private CheckBox checkBoxShowPass;
        private TextBox textBoxPassword;
        private Label label3;
        private TextBox textBoxUserName;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}
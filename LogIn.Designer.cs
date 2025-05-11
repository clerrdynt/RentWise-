namespace RentWise_
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            iconbtnClose = new FontAwesome.Sharp.IconButton();
            iconbtnMinimized = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            iconBtnUnseePassword = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            tbxPassword = new TextBox();
            tbxUsername = new TextBox();
            btnLogIn = new Button();
            btnGoBack = new Button();
            SuspendLayout();
            // 
            // iconbtnClose
            // 
            iconbtnClose.BackColor = Color.White;
            iconbtnClose.FlatAppearance.BorderSize = 0;
            iconbtnClose.FlatStyle = FlatStyle.Flat;
            iconbtnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            iconbtnClose.IconColor = Color.Black;
            iconbtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnClose.IconSize = 25;
            iconbtnClose.Location = new Point(517, 3);
            iconbtnClose.Name = "iconbtnClose";
            iconbtnClose.Size = new Size(46, 40);
            iconbtnClose.TabIndex = 6;
            iconbtnClose.UseVisualStyleBackColor = false;
            iconbtnClose.Click += iconbtnClose_Click;
            // 
            // iconbtnMinimized
            // 
            iconbtnMinimized.BackColor = Color.White;
            iconbtnMinimized.FlatAppearance.BorderSize = 0;
            iconbtnMinimized.FlatStyle = FlatStyle.Flat;
            iconbtnMinimized.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconbtnMinimized.IconColor = Color.Black;
            iconbtnMinimized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnMinimized.IconSize = 25;
            iconbtnMinimized.Location = new Point(480, 3);
            iconbtnMinimized.Name = "iconbtnMinimized";
            iconbtnMinimized.Size = new Size(46, 40);
            iconbtnMinimized.TabIndex = 7;
            iconbtnMinimized.UseVisualStyleBackColor = false;
            iconbtnMinimized.Click += iconbtnMinimized_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 148, 115);
            panel2.Location = new Point(101, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 5);
            panel2.TabIndex = 14;
            // 
            // iconBtnUnseePassword
            // 
            iconBtnUnseePassword.BackColor = Color.FromArgb(0, 148, 115);
            iconBtnUnseePassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            iconBtnUnseePassword.IconColor = Color.White;
            iconBtnUnseePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnUnseePassword.IconSize = 34;
            iconBtnUnseePassword.Location = new Point(393, 190);
            iconBtnUnseePassword.Name = "iconBtnUnseePassword";
            iconBtnUnseePassword.Size = new Size(44, 47);
            iconBtnUnseePassword.TabIndex = 17;
            iconBtnUnseePassword.UseVisualStyleBackColor = false;
            iconBtnUnseePassword.Click += iconBtnUnseePassword_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 128);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 16;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 197);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 15;
            label1.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 148, 115);
            panel1.Location = new Point(101, 163);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 5);
            panel1.TabIndex = 13;
            // 
            // tbxPassword
            // 
            tbxPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPassword.Location = new Point(101, 190);
            tbxPassword.Multiline = true;
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(336, 47);
            tbxPassword.TabIndex = 12;
            tbxPassword.TextAlign = HorizontalAlignment.Center;
            tbxPassword.UseSystemPasswordChar = true;
            tbxPassword.TextChanged += tbxPassword_TextChanged;
            // 
            // tbxUsername
            // 
            tbxUsername.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUsername.ForeColor = Color.Black;
            tbxUsername.Location = new Point(101, 121);
            tbxUsername.Multiline = true;
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(336, 47);
            tbxUsername.TabIndex = 11;
            tbxUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(0, 148, 115);
            btnLogIn.Font = new Font("Century Gothic", 10.8F);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(315, 312);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(122, 48);
            btnLogIn.TabIndex = 19;
            btnLogIn.Text = "LOG IN";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnGoBack
            // 
            btnGoBack.BackColor = Color.FromArgb(0, 148, 115);
            btnGoBack.Font = new Font("Century Gothic", 10.8F);
            btnGoBack.ForeColor = Color.White;
            btnGoBack.Location = new Point(104, 312);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(122, 48);
            btnGoBack.TabIndex = 22;
            btnGoBack.Text = "GO BACK";
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(566, 444);
            Controls.Add(btnGoBack);
            Controls.Add(btnLogIn);
            Controls.Add(panel2);
            Controls.Add(iconBtnUnseePassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUsername);
            Controls.Add(iconbtnMinimized);
            Controls.Add(iconbtnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            Load += LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconbtnClose;
        private FontAwesome.Sharp.IconButton iconbtnMinimized;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconBtnUnseePassword;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private TextBox tbxPassword;
        private TextBox tbxUsername;
        private Button btnLogIn;
        private Button btnGoBack;
    }
}
namespace RentWise_
{
    partial class IntroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroForm));
            iconbtnClose = new FontAwesome.Sharp.IconButton();
            iconbtnMinimized = new FontAwesome.Sharp.IconButton();
            btnLogIn = new Button();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            iconbtnClose.Location = new Point(1045, 12);
            iconbtnClose.Name = "iconbtnClose";
            iconbtnClose.Size = new Size(46, 40);
            iconbtnClose.TabIndex = 5;
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
            iconbtnMinimized.Location = new Point(993, 12);
            iconbtnMinimized.Name = "iconbtnMinimized";
            iconbtnMinimized.Size = new Size(46, 40);
            iconbtnMinimized.TabIndex = 6;
            iconbtnMinimized.UseVisualStyleBackColor = false;
            iconbtnMinimized.Click += iconbtnMinimized_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(0, 148, 115);
            btnLogIn.Font = new Font("Century Gothic", 10.8F);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(197, 447);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(122, 48);
            btnLogIn.TabIndex = 7;
            btnLogIn.Text = "LOG IN";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(0, 148, 115);
            btnRegister.Font = new Font("Century Gothic", 10.8F);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(431, 447);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(122, 48);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1103, 699);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Cooper Black", 19.8000011F);
            label1.ForeColor = Color.FromArgb(0, 148, 115);
            label1.Location = new Point(234, 144);
            label1.Name = "label1";
            label1.Size = new Size(314, 39);
            label1.TabIndex = 10;
            label1.Text = "RentWise: Rental";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Cooper Black", 19.8000011F);
            label2.ForeColor = Color.FromArgb(0, 148, 115);
            label2.Location = new Point(197, 184);
            label2.Name = "label2";
            label2.Size = new Size(371, 39);
            label2.TabIndex = 11;
            label2.Text = "Management System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Century Gothic", 12F);
            label3.Location = new Point(160, 248);
            label3.Name = "label3";
            label3.Size = new Size(426, 23);
            label3.TabIndex = 12;
            label3.Text = "Renting made easy! From chaos to control";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Century Gothic", 12F);
            label4.Location = new Point(188, 280);
            label4.Name = "label4";
            label4.Size = new Size(365, 23);
            label4.TabIndex = 13;
            label4.Text = "manage rentals like a pro. One click";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Century Gothic", 12F);
            label5.Location = new Point(254, 314);
            label5.Name = "label5";
            label5.Size = new Size(215, 23);
            label5.TabIndex = 14;
            label5.Text = "One lease Zero stress";
            // 
            // IntroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 699);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(iconbtnClose);
            Controls.Add(iconbtnMinimized);
            Controls.Add(btnRegister);
            Controls.Add(btnLogIn);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IntroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IntroForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconbtnClose;
        private FontAwesome.Sharp.IconButton iconbtnMinimized;
        private Button btnLogIn;
        private Button btnRegister;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
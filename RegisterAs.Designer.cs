namespace RentWise_
{
    partial class RegisterAs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterAs));
            iconbtnClose = new FontAwesome.Sharp.IconButton();
            iconbtnMinimized = new FontAwesome.Sharp.IconButton();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            btnRegisterAsRenter = new Button();
            btnRegisterAsOwner = new Button();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
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
            iconbtnClose.Location = new Point(312, 1);
            iconbtnClose.Name = "iconbtnClose";
            iconbtnClose.Size = new Size(46, 40);
            iconbtnClose.TabIndex = 7;
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
            iconbtnMinimized.Location = new Point(270, 1);
            iconbtnMinimized.Name = "iconbtnMinimized";
            iconbtnMinimized.Size = new Size(46, 40);
            iconbtnMinimized.TabIndex = 8;
            iconbtnMinimized.UseVisualStyleBackColor = false;
            iconbtnMinimized.Click += iconbtnMinimized_Click;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(0, 148, 115);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 38;
            iconPictureBox2.Location = new Point(96, 46);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(42, 38);
            iconPictureBox2.TabIndex = 36;
            iconPictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(144, 57);
            label3.Name = "label3";
            label3.Size = new Size(117, 21);
            label3.TabIndex = 37;
            label3.Text = "Register As?";
            // 
            // btnRegisterAsRenter
            // 
            btnRegisterAsRenter.BackColor = Color.FromArgb(0, 148, 115);
            btnRegisterAsRenter.Font = new Font("Century Gothic", 10.8F);
            btnRegisterAsRenter.ForeColor = Color.White;
            btnRegisterAsRenter.Location = new Point(118, 108);
            btnRegisterAsRenter.Name = "btnRegisterAsRenter";
            btnRegisterAsRenter.Size = new Size(122, 48);
            btnRegisterAsRenter.TabIndex = 41;
            btnRegisterAsRenter.Text = "RENTER";
            btnRegisterAsRenter.UseVisualStyleBackColor = false;
            btnRegisterAsRenter.Click += btnRegisterAsRenter_Click;
            // 
            // btnRegisterAsOwner
            // 
            btnRegisterAsOwner.BackColor = Color.FromArgb(0, 148, 115);
            btnRegisterAsOwner.Font = new Font("Century Gothic", 10.8F);
            btnRegisterAsOwner.ForeColor = Color.White;
            btnRegisterAsOwner.Location = new Point(118, 162);
            btnRegisterAsOwner.Name = "btnRegisterAsOwner";
            btnRegisterAsOwner.Size = new Size(122, 48);
            btnRegisterAsOwner.TabIndex = 42;
            btnRegisterAsOwner.Text = "OWNER";
            btnRegisterAsOwner.UseVisualStyleBackColor = false;
            btnRegisterAsOwner.Click += btnRegisterAsOwner_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(359, 265);
            Controls.Add(btnRegisterAsOwner);
            Controls.Add(btnRegisterAsRenter);
            Controls.Add(iconPictureBox2);
            Controls.Add(label3);
            Controls.Add(iconbtnMinimized);
            Controls.Add(iconbtnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconbtnClose;
        private FontAwesome.Sharp.IconButton iconbtnMinimized;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label3;
        private Button btnRegisterAsRenter;
        private Button btnRegisterAsOwner;
    }
}
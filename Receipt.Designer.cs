namespace RentWise_
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            iconbtnClose = new FontAwesome.Sharp.IconButton();
            iconbtnMinimized = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblPropertyID = new Label();
            lblRenterID = new Label();
            lblRenterFirstName = new Label();
            lblRenterLastName = new Label();
            label11 = new Label();
            lblPaymentDate = new Label();
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
            iconbtnClose.Location = new Point(401, 12);
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
            iconbtnMinimized.Location = new Point(366, 3);
            iconbtnMinimized.Name = "iconbtnMinimized";
            iconbtnMinimized.Size = new Size(46, 40);
            iconbtnMinimized.TabIndex = 8;
            iconbtnMinimized.UseVisualStyleBackColor = false;
            iconbtnMinimized.Click += iconbtnMinimized_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(177, 43);
            label2.Name = "label2";
            label2.Size = new Size(98, 27);
            label2.TabIndex = 17;
            label2.Text = "Receipt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(98, 200);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 19;
            label3.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(94, 232);
            label4.Name = "label4";
            label4.Size = new Size(105, 21);
            label4.TabIndex = 20;
            label4.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(63, 265);
            label5.Name = "label5";
            label5.Size = new Size(136, 21);
            label5.TabIndex = 21;
            label5.Text = "Payment Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(107, 169);
            label6.Name = "label6";
            label6.Size = new Size(92, 21);
            label6.TabIndex = 22;
            label6.Text = "Renter ID:";
            // 
            // lblPropertyID
            // 
            lblPropertyID.AutoSize = true;
            lblPropertyID.BackColor = Color.FromArgb(0, 148, 115);
            lblPropertyID.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPropertyID.ForeColor = Color.White;
            lblPropertyID.Location = new Point(211, 137);
            lblPropertyID.Name = "lblPropertyID";
            lblPropertyID.Size = new Size(134, 21);
            lblPropertyID.TabIndex = 43;
            lblPropertyID.Text = "AccountName";
            // 
            // lblRenterID
            // 
            lblRenterID.AutoSize = true;
            lblRenterID.BackColor = Color.FromArgb(0, 148, 115);
            lblRenterID.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRenterID.ForeColor = Color.White;
            lblRenterID.Location = new Point(211, 168);
            lblRenterID.Name = "lblRenterID";
            lblRenterID.Size = new Size(134, 21);
            lblRenterID.TabIndex = 44;
            lblRenterID.Text = "AccountName";
            // 
            // lblRenterFirstName
            // 
            lblRenterFirstName.AutoSize = true;
            lblRenterFirstName.BackColor = Color.FromArgb(0, 148, 115);
            lblRenterFirstName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRenterFirstName.ForeColor = Color.White;
            lblRenterFirstName.Location = new Point(211, 200);
            lblRenterFirstName.Name = "lblRenterFirstName";
            lblRenterFirstName.Size = new Size(134, 21);
            lblRenterFirstName.TabIndex = 45;
            lblRenterFirstName.Text = "AccountName";
            // 
            // lblRenterLastName
            // 
            lblRenterLastName.AutoSize = true;
            lblRenterLastName.BackColor = Color.FromArgb(0, 148, 115);
            lblRenterLastName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRenterLastName.ForeColor = Color.White;
            lblRenterLastName.Location = new Point(211, 233);
            lblRenterLastName.Name = "lblRenterLastName";
            lblRenterLastName.Size = new Size(134, 21);
            lblRenterLastName.TabIndex = 46;
            lblRenterLastName.Text = "AccountName";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(92, 137);
            label11.Name = "label11";
            label11.Size = new Size(107, 21);
            label11.TabIndex = 47;
            label11.Text = "Property ID:";
            // 
            // lblPaymentDate
            // 
            lblPaymentDate.AutoSize = true;
            lblPaymentDate.BackColor = Color.FromArgb(0, 148, 115);
            lblPaymentDate.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentDate.ForeColor = Color.White;
            lblPaymentDate.Location = new Point(211, 265);
            lblPaymentDate.Name = "lblPaymentDate";
            lblPaymentDate.Size = new Size(134, 21);
            lblPaymentDate.TabIndex = 48;
            lblPaymentDate.Text = "AccountName";
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(459, 470);
            Controls.Add(lblPaymentDate);
            Controls.Add(label11);
            Controls.Add(lblRenterLastName);
            Controls.Add(lblRenterFirstName);
            Controls.Add(lblRenterID);
            Controls.Add(lblPropertyID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(iconbtnMinimized);
            Controls.Add(iconbtnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Receipt";
            Text = "Receipt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconbtnClose;
        private FontAwesome.Sharp.IconButton iconbtnMinimized;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblPropertyID;
        private Label lblRenterID;
        private Label lblRenterFirstName;
        private Label lblRenterLastName;
        private Label label11;
        private Label lblPaymentDate;
    }
}
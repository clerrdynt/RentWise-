namespace RentWise_
{
    partial class EWallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EWallet));
            iconbtnClose = new FontAwesome.Sharp.IconButton();
            iconbtnMinimized = new FontAwesome.Sharp.IconButton();
            pbxEWalletQR = new PictureBox();
            tbxOwnerName = new TextBox();
            tbxOwnerNumber = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSave = new Button();
            btnUpload = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxEWalletQR).BeginInit();
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
            iconbtnClose.Location = new Point(617, 12);
            iconbtnClose.Name = "iconbtnClose";
            iconbtnClose.Size = new Size(46, 40);
            iconbtnClose.TabIndex = 11;
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
            iconbtnMinimized.Location = new Point(577, 12);
            iconbtnMinimized.Name = "iconbtnMinimized";
            iconbtnMinimized.Size = new Size(46, 40);
            iconbtnMinimized.TabIndex = 12;
            iconbtnMinimized.UseVisualStyleBackColor = false;
            iconbtnMinimized.Click += iconbtnMinimized_Click;
            // 
            // pbxEWalletQR
            // 
            pbxEWalletQR.BackgroundImageLayout = ImageLayout.Stretch;
            pbxEWalletQR.Location = new Point(265, 12);
            pbxEWalletQR.Name = "pbxEWalletQR";
            pbxEWalletQR.Size = new Size(218, 186);
            pbxEWalletQR.SizeMode = PictureBoxSizeMode.Zoom;
            pbxEWalletQR.TabIndex = 13;
            pbxEWalletQR.TabStop = false;
            // 
            // tbxOwnerName
            // 
            tbxOwnerName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxOwnerName.Location = new Point(217, 284);
            tbxOwnerName.Multiline = true;
            tbxOwnerName.Name = "tbxOwnerName";
            tbxOwnerName.Size = new Size(266, 36);
            tbxOwnerName.TabIndex = 15;
            // 
            // tbxOwnerNumber
            // 
            tbxOwnerNumber.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxOwnerNumber.Location = new Point(217, 356);
            tbxOwnerNumber.Multiline = true;
            tbxOwnerNumber.Name = "tbxOwnerNumber";
            tbxOwnerNumber.Size = new Size(266, 40);
            tbxOwnerNumber.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 148, 115);
            panel1.Font = new Font("Century Gothic", 10.2F);
            panel1.Location = new Point(217, 315);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 5);
            panel1.TabIndex = 34;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 148, 115);
            panel2.Font = new Font("Century Gothic", 10.2F);
            panel2.Location = new Point(217, 394);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 5);
            panel2.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 323);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 36;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(318, 411);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 37;
            label2.Text = "Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(95, 21);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 38;
            label3.Text = "Scan Me!";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 148, 115);
            btnSave.Font = new Font("Century Gothic", 10.8F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(527, 400);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 48);
            btnSave.TabIndex = 39;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.FromArgb(0, 148, 115);
            btnUpload.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(318, 204);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(99, 39);
            btnUpload.TabIndex = 40;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // EWallet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(675, 512);
            Controls.Add(btnUpload);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tbxOwnerNumber);
            Controls.Add(tbxOwnerName);
            Controls.Add(pbxEWalletQR);
            Controls.Add(iconbtnMinimized);
            Controls.Add(iconbtnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "EWallet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EWallet";
            ((System.ComponentModel.ISupportInitialize)pbxEWalletQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconbtnClose;
        private FontAwesome.Sharp.IconButton iconbtnMinimized;
        private PictureBox pbxEWalletQR;
        private TextBox tbxOwnerName;
        private TextBox tbxOwnerNumber;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSave;
        private Button btnUpload;
    }
}
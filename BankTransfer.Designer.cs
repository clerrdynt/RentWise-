namespace RentWise_
{
    partial class BankTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankTransfer));
            iconbtnClose = new FontAwesome.Sharp.IconButton();
            iconbtnMinimized = new FontAwesome.Sharp.IconButton();
            tbxOwnerName = new TextBox();
            tbxOwnerNumber = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            btnSave = new Button();
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
            iconbtnClose.Location = new Point(446, 2);
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
            iconbtnMinimized.Location = new Point(377, 2);
            iconbtnMinimized.Name = "iconbtnMinimized";
            iconbtnMinimized.Size = new Size(46, 40);
            iconbtnMinimized.TabIndex = 12;
            iconbtnMinimized.UseVisualStyleBackColor = false;
            iconbtnMinimized.Click += iconbtnMinimized_Click;
            // 
            // tbxOwnerName
            // 
            tbxOwnerName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxOwnerName.Location = new Point(148, 70);
            tbxOwnerName.Multiline = true;
            tbxOwnerName.Name = "tbxOwnerName";
            tbxOwnerName.Size = new Size(266, 36);
            tbxOwnerName.TabIndex = 15;
            // 
            // tbxOwnerNumber
            // 
            tbxOwnerNumber.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxOwnerNumber.Location = new Point(148, 165);
            tbxOwnerNumber.Multiline = true;
            tbxOwnerNumber.Name = "tbxOwnerNumber";
            tbxOwnerNumber.Size = new Size(266, 40);
            tbxOwnerNumber.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 148, 115);
            panel1.Font = new Font("Century Gothic", 10.2F);
            panel1.Location = new Point(148, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 5);
            panel1.TabIndex = 34;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 148, 115);
            panel2.Font = new Font("Century Gothic", 10.2F);
            panel2.Location = new Point(148, 203);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 5);
            panel2.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 122);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 36;
            label1.Text = "Acount Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(249, 220);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 37;
            label2.Text = "Number";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 148, 115);
            btnSave.Font = new Font("Century Gothic", 10.8F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(466, 255);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 48);
            btnSave.TabIndex = 39;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // BankTransfer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(592, 371);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tbxOwnerNumber);
            Controls.Add(tbxOwnerName);
            Controls.Add(iconbtnMinimized);
            Controls.Add(iconbtnClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "BankTransfer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EWallet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconbtnClose;
        private FontAwesome.Sharp.IconButton iconbtnMinimized;
        private TextBox tbxOwnerName;
        private TextBox tbxOwnerNumber;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button btnSave;
    }
}
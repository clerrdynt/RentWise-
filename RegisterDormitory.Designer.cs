namespace RentWise_
{
    partial class RegisterDormitory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterDormitory));
            iconbtnClose = new FontAwesome.Sharp.IconButton();
            iconbtnMinimized = new FontAwesome.Sharp.IconButton();
            btnDormInfoCancel = new Button();
            btnDormInfoRegister = new Button();
            tbxDormPayFreq = new TextBox();
            label9 = new Label();
            grbDormStruct = new GroupBox();
            nUPRoomPerFloor = new NumericUpDown();
            nUPTotFloors = new NumericUpDown();
            label5 = new Label();
            label3 = new Label();
            grbRoomSetUp = new GroupBox();
            rBtnBankTransfer = new RadioButton();
            rBtnEWallet = new RadioButton();
            rBtnCash = new RadioButton();
            label6 = new Label();
            tbxDormPrice = new TextBox();
            label8 = new Label();
            cmbDormType = new ComboBox();
            label7 = new Label();
            grbDormInfo = new GroupBox();
            tbxDormContact = new TextBox();
            tbxDormAddress = new TextBox();
            tbxDormName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            grbDormStruct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUPRoomPerFloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPTotFloors).BeginInit();
            grbRoomSetUp.SuspendLayout();
            grbDormInfo.SuspendLayout();
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
            iconbtnClose.Location = new Point(1027, 12);
            iconbtnClose.Name = "iconbtnClose";
            iconbtnClose.Size = new Size(46, 40);
            iconbtnClose.TabIndex = 8;
            iconbtnClose.UseVisualStyleBackColor = false;
            iconbtnClose.Click += iconbtnClose_Click;
            // 
            // iconbtnMinimized
            // 
            iconbtnMinimized.BackColor = Color.White;
            iconbtnMinimized.BackgroundImage = (Image)resources.GetObject("iconbtnMinimized.BackgroundImage");
            iconbtnMinimized.FlatAppearance.BorderSize = 0;
            iconbtnMinimized.FlatStyle = FlatStyle.Flat;
            iconbtnMinimized.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconbtnMinimized.IconColor = Color.Black;
            iconbtnMinimized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnMinimized.IconSize = 25;
            iconbtnMinimized.Location = new Point(975, 12);
            iconbtnMinimized.Name = "iconbtnMinimized";
            iconbtnMinimized.Size = new Size(46, 40);
            iconbtnMinimized.TabIndex = 9;
            iconbtnMinimized.UseVisualStyleBackColor = false;
            iconbtnMinimized.Click += iconbtnMinimized_Click;
            // 
            // btnDormInfoCancel
            // 
            btnDormInfoCancel.BackColor = Color.FromArgb(0, 148, 115);
            btnDormInfoCancel.Font = new Font("Century Gothic", 10.8F);
            btnDormInfoCancel.ForeColor = Color.White;
            btnDormInfoCancel.Location = new Point(340, 569);
            btnDormInfoCancel.Name = "btnDormInfoCancel";
            btnDormInfoCancel.Size = new Size(111, 48);
            btnDormInfoCancel.TabIndex = 29;
            btnDormInfoCancel.Text = "GO BACK";
            btnDormInfoCancel.UseVisualStyleBackColor = false;
            btnDormInfoCancel.Click += btnDormInfoCancel_Click;
            // 
            // btnDormInfoRegister
            // 
            btnDormInfoRegister.BackColor = Color.FromArgb(0, 148, 115);
            btnDormInfoRegister.Font = new Font("Century Gothic", 10.8F);
            btnDormInfoRegister.ForeColor = Color.White;
            btnDormInfoRegister.Location = new Point(623, 569);
            btnDormInfoRegister.Name = "btnDormInfoRegister";
            btnDormInfoRegister.Size = new Size(111, 48);
            btnDormInfoRegister.TabIndex = 28;
            btnDormInfoRegister.Text = "REGISTER";
            btnDormInfoRegister.UseVisualStyleBackColor = false;
            btnDormInfoRegister.Click += btnDormInfoRegister_Click;
            // 
            // tbxDormPayFreq
            // 
            tbxDormPayFreq.Location = new Point(197, 160);
            tbxDormPayFreq.Name = "tbxDormPayFreq";
            tbxDormPayFreq.Size = new Size(164, 30);
            tbxDormPayFreq.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.8F);
            label9.Location = new Point(6, 164);
            label9.Name = "label9";
            label9.Size = new Size(191, 21);
            label9.TabIndex = 26;
            label9.Text = "Payment Frequency";
            // 
            // grbDormStruct
            // 
            grbDormStruct.BackColor = Color.FromArgb(0, 148, 115);
            grbDormStruct.Controls.Add(nUPRoomPerFloor);
            grbDormStruct.Controls.Add(nUPTotFloors);
            grbDormStruct.Controls.Add(label5);
            grbDormStruct.Controls.Add(label3);
            grbDormStruct.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbDormStruct.ForeColor = Color.White;
            grbDormStruct.Location = new Point(45, 383);
            grbDormStruct.Name = "grbDormStruct";
            grbDormStruct.Size = new Size(371, 180);
            grbDormStruct.TabIndex = 26;
            grbDormStruct.TabStop = false;
            grbDormStruct.Text = "Building Structure";
            // 
            // nUPRoomPerFloor
            // 
            nUPRoomPerFloor.Location = new Point(276, 81);
            nUPRoomPerFloor.Name = "nUPRoomPerFloor";
            nUPRoomPerFloor.Size = new Size(76, 30);
            nUPRoomPerFloor.TabIndex = 5;
            // 
            // nUPTotFloors
            // 
            nUPTotFloors.Location = new Point(276, 40);
            nUPTotFloors.Name = "nUPTotFloors";
            nUPTotFloors.Size = new Size(76, 30);
            nUPTotFloors.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F);
            label5.Location = new Point(6, 81);
            label5.Name = "label5";
            label5.Size = new Size(148, 21);
            label5.TabIndex = 2;
            label5.Text = "Rooms Per Floor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F);
            label3.Location = new Point(6, 42);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 1;
            label3.Text = "Total Floors";
            // 
            // grbRoomSetUp
            // 
            grbRoomSetUp.BackColor = Color.FromArgb(0, 148, 115);
            grbRoomSetUp.Controls.Add(rBtnBankTransfer);
            grbRoomSetUp.Controls.Add(rBtnEWallet);
            grbRoomSetUp.Controls.Add(rBtnCash);
            grbRoomSetUp.Controls.Add(label6);
            grbRoomSetUp.Controls.Add(tbxDormPrice);
            grbRoomSetUp.Controls.Add(label8);
            grbRoomSetUp.Controls.Add(tbxDormPayFreq);
            grbRoomSetUp.Controls.Add(cmbDormType);
            grbRoomSetUp.Controls.Add(label9);
            grbRoomSetUp.Controls.Add(label7);
            grbRoomSetUp.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbRoomSetUp.ForeColor = Color.White;
            grbRoomSetUp.Location = new Point(623, 136);
            grbRoomSetUp.Name = "grbRoomSetUp";
            grbRoomSetUp.Size = new Size(386, 367);
            grbRoomSetUp.TabIndex = 25;
            grbRoomSetUp.TabStop = false;
            grbRoomSetUp.Text = "Room Setup and Pricing";
            // 
            // rBtnBankTransfer
            // 
            rBtnBankTransfer.AutoSize = true;
            rBtnBankTransfer.Location = new Point(51, 311);
            rBtnBankTransfer.Name = "rBtnBankTransfer";
            rBtnBankTransfer.Size = new Size(147, 26);
            rBtnBankTransfer.TabIndex = 34;
            rBtnBankTransfer.TabStop = true;
            rBtnBankTransfer.Text = "Bank Transfer";
            rBtnBankTransfer.UseVisualStyleBackColor = true;
            rBtnBankTransfer.CheckedChanged += rBtnBankTransfer_CheckedChanged;
            // 
            // rBtnEWallet
            // 
            rBtnEWallet.AutoSize = true;
            rBtnEWallet.Location = new Point(51, 279);
            rBtnEWallet.Name = "rBtnEWallet";
            rBtnEWallet.Size = new Size(101, 26);
            rBtnEWallet.TabIndex = 33;
            rBtnEWallet.TabStop = true;
            rBtnEWallet.Text = "E-Wallet";
            rBtnEWallet.UseVisualStyleBackColor = true;
            rBtnEWallet.CheckedChanged += rBtnEWallet_CheckedChanged;
            // 
            // rBtnCash
            // 
            rBtnCash.AutoSize = true;
            rBtnCash.Location = new Point(51, 247);
            rBtnCash.Name = "rBtnCash";
            rBtnCash.Size = new Size(76, 26);
            rBtnCash.TabIndex = 32;
            rBtnCash.TabStop = true;
            rBtnCash.Text = "Cash";
            rBtnCash.UseVisualStyleBackColor = true;
            rBtnCash.CheckedChanged += rBtnCash_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F);
            label6.Location = new Point(6, 211);
            label6.Name = "label6";
            label6.Size = new Size(174, 21);
            label6.TabIndex = 31;
            label6.Text = "Payment Methods";
            // 
            // tbxDormPrice
            // 
            tbxDormPrice.Location = new Point(194, 101);
            tbxDormPrice.Name = "tbxDormPrice";
            tbxDormPrice.Size = new Size(164, 30);
            tbxDormPrice.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.8F);
            label8.Location = new Point(18, 103);
            label8.Name = "label8";
            label8.Size = new Size(149, 21);
            label8.TabIndex = 25;
            label8.Text = "Price Per Month";
            // 
            // cmbDormType
            // 
            cmbDormType.FormattingEnabled = true;
            cmbDormType.Items.AddRange(new object[] { "Single", "Shared" });
            cmbDormType.Location = new Point(225, 40);
            cmbDormType.Name = "cmbDormType";
            cmbDormType.Size = new Size(115, 30);
            cmbDormType.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.8F);
            label7.Location = new Point(18, 43);
            label7.Name = "label7";
            label7.Size = new Size(117, 21);
            label7.TabIndex = 22;
            label7.Text = "Room Types";
            // 
            // grbDormInfo
            // 
            grbDormInfo.BackColor = Color.FromArgb(0, 148, 115);
            grbDormInfo.Controls.Add(tbxDormContact);
            grbDormInfo.Controls.Add(tbxDormAddress);
            grbDormInfo.Controls.Add(tbxDormName);
            grbDormInfo.Controls.Add(label4);
            grbDormInfo.Controls.Add(label2);
            grbDormInfo.Controls.Add(label1);
            grbDormInfo.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbDormInfo.ForeColor = Color.White;
            grbDormInfo.Location = new Point(45, 136);
            grbDormInfo.Name = "grbDormInfo";
            grbDormInfo.Size = new Size(371, 226);
            grbDormInfo.TabIndex = 24;
            grbDormInfo.TabStop = false;
            grbDormInfo.Text = "Dormitory Information";
            // 
            // tbxDormContact
            // 
            tbxDormContact.Location = new Point(166, 165);
            tbxDormContact.Name = "tbxDormContact";
            tbxDormContact.Size = new Size(199, 30);
            tbxDormContact.TabIndex = 7;
            // 
            // tbxDormAddress
            // 
            tbxDormAddress.Location = new Point(166, 103);
            tbxDormAddress.Multiline = true;
            tbxDormAddress.Name = "tbxDormAddress";
            tbxDormAddress.Size = new Size(199, 49);
            tbxDormAddress.TabIndex = 5;
            // 
            // tbxDormName
            // 
            tbxDormName.Location = new Point(166, 43);
            tbxDormName.Multiline = true;
            tbxDormName.Name = "tbxDormName";
            tbxDormName.Size = new Size(199, 54);
            tbxDormName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F);
            label4.Location = new Point(6, 174);
            label4.Name = "label4";
            label4.Size = new Size(116, 21);
            label4.TabIndex = 3;
            label4.Text = "Contact No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F);
            label2.Location = new Point(0, 107);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 1;
            label2.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F);
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 0;
            label1.Text = "Dormitory Name";
            // 
            // RegisterDormitory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1085, 652);
            Controls.Add(btnDormInfoCancel);
            Controls.Add(btnDormInfoRegister);
            Controls.Add(grbDormStruct);
            Controls.Add(grbRoomSetUp);
            Controls.Add(grbDormInfo);
            Controls.Add(iconbtnMinimized);
            Controls.Add(iconbtnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterDormitory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterDormitory";
            grbDormStruct.ResumeLayout(false);
            grbDormStruct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUPRoomPerFloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPTotFloors).EndInit();
            grbRoomSetUp.ResumeLayout(false);
            grbRoomSetUp.PerformLayout();
            grbDormInfo.ResumeLayout(false);
            grbDormInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconbtnClose;
        private FontAwesome.Sharp.IconButton iconbtnMinimized;
        private Button btnDormInfoCancel;
        private Button btnDormInfoRegister;
        private TextBox tbxDormPayFreq;
        private Label label9;
        private GroupBox grbDormStruct;
        private NumericUpDown nUPRoomPerFloor;
        private NumericUpDown nUPTotFloors;
        private Label label5;
        private Label label3;
        private GroupBox grbRoomSetUp;
        private TextBox tbxDormPrice;
        private Label label8;
        private ComboBox cmbDormType;
        private Label label7;
        private GroupBox grbDormInfo;
        private TextBox tbxDormContact;
        private TextBox tbxDormAddress;
        private TextBox tbxDormName;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label6;
        private RadioButton rBtnBankTransfer;
        private RadioButton rBtnEWallet;
        private RadioButton rBtnCash;
    }
}
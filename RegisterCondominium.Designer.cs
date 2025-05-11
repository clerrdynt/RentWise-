namespace RentWise_
{
    partial class RegisterCondominium
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterCondominium));
            iconbtnClose = new FontAwesome.Sharp.IconButton();
            iconbtnMinimized = new FontAwesome.Sharp.IconButton();
            btnCondoInfoRegister = new Button();
            btnCondoInfoCancel = new Button();
            grbCondoSetUp = new GroupBox();
            rBtnBankTransfer = new RadioButton();
            rBtnEWallet = new RadioButton();
            rBtnCash = new RadioButton();
            label9 = new Label();
            cbxCondoPayFreq = new ComboBox();
            label6 = new Label();
            tbxCondoPrice = new TextBox();
            label8 = new Label();
            cmbCondoType = new ComboBox();
            label7 = new Label();
            grbCondoStruct = new GroupBox();
            nUPCondoRoomPerFloor = new NumericUpDown();
            nUPCondoTotFloors = new NumericUpDown();
            label5 = new Label();
            label3 = new Label();
            grbCondoInfo = new GroupBox();
            tbxCondoContact = new TextBox();
            tbxCondoAddress = new TextBox();
            tbxCondoName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cbxGym = new CheckBox();
            cbxUtilities = new CheckBox();
            cbxClubhouse = new CheckBox();
            cbxParking = new CheckBox();
            cbxSecurity = new CheckBox();
            grbCondoSetUp.SuspendLayout();
            grbCondoStruct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUPCondoRoomPerFloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPCondoTotFloors).BeginInit();
            grbCondoInfo.SuspendLayout();
            groupBox1.SuspendLayout();
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
            iconbtnClose.TabIndex = 7;
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
            iconbtnMinimized.TabIndex = 8;
            iconbtnMinimized.UseVisualStyleBackColor = false;
            iconbtnMinimized.Click += iconbtnMinimized_Click;
            // 
            // btnCondoInfoRegister
            // 
            btnCondoInfoRegister.BackColor = Color.FromArgb(0, 148, 115);
            btnCondoInfoRegister.Font = new Font("Century Gothic", 10.8F);
            btnCondoInfoRegister.ForeColor = Color.White;
            btnCondoInfoRegister.Location = new Point(632, 568);
            btnCondoInfoRegister.Name = "btnCondoInfoRegister";
            btnCondoInfoRegister.Size = new Size(111, 48);
            btnCondoInfoRegister.TabIndex = 31;
            btnCondoInfoRegister.Text = "REGISTER";
            btnCondoInfoRegister.UseVisualStyleBackColor = false;
            btnCondoInfoRegister.Click += btnCondoInfoRegister_Click;
            // 
            // btnCondoInfoCancel
            // 
            btnCondoInfoCancel.BackColor = Color.FromArgb(0, 148, 115);
            btnCondoInfoCancel.Font = new Font("Century Gothic", 10.8F);
            btnCondoInfoCancel.ForeColor = Color.White;
            btnCondoInfoCancel.Location = new Point(333, 568);
            btnCondoInfoCancel.Name = "btnCondoInfoCancel";
            btnCondoInfoCancel.Size = new Size(111, 48);
            btnCondoInfoCancel.TabIndex = 30;
            btnCondoInfoCancel.Text = "GO BACK";
            btnCondoInfoCancel.UseVisualStyleBackColor = false;
            btnCondoInfoCancel.Click += btnCondoInfoCancel_Click;
            // 
            // grbCondoSetUp
            // 
            grbCondoSetUp.BackColor = Color.FromArgb(0, 148, 115);
            grbCondoSetUp.Controls.Add(rBtnBankTransfer);
            grbCondoSetUp.Controls.Add(rBtnEWallet);
            grbCondoSetUp.Controls.Add(rBtnCash);
            grbCondoSetUp.Controls.Add(label9);
            grbCondoSetUp.Controls.Add(cbxCondoPayFreq);
            grbCondoSetUp.Controls.Add(label6);
            grbCondoSetUp.Controls.Add(tbxCondoPrice);
            grbCondoSetUp.Controls.Add(label8);
            grbCondoSetUp.Controls.Add(cmbCondoType);
            grbCondoSetUp.Controls.Add(label7);
            grbCondoSetUp.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbCondoSetUp.ForeColor = Color.White;
            grbCondoSetUp.Location = new Point(671, 275);
            grbCondoSetUp.Name = "grbCondoSetUp";
            grbCondoSetUp.Size = new Size(386, 287);
            grbCondoSetUp.TabIndex = 28;
            grbCondoSetUp.TabStop = false;
            grbCondoSetUp.Text = "Room Setup and Pricing";
            // 
            // rBtnBankTransfer
            // 
            rBtnBankTransfer.AutoSize = true;
            rBtnBankTransfer.Location = new Point(195, 213);
            rBtnBankTransfer.Name = "rBtnBankTransfer";
            rBtnBankTransfer.Size = new Size(147, 26);
            rBtnBankTransfer.TabIndex = 38;
            rBtnBankTransfer.TabStop = true;
            rBtnBankTransfer.Text = "Bank Transfer";
            rBtnBankTransfer.UseVisualStyleBackColor = true;
            rBtnBankTransfer.CheckedChanged += rBtnBankTransfer_CheckedChanged;
            // 
            // rBtnEWallet
            // 
            rBtnEWallet.AutoSize = true;
            rBtnEWallet.Location = new Point(64, 232);
            rBtnEWallet.Name = "rBtnEWallet";
            rBtnEWallet.Size = new Size(101, 26);
            rBtnEWallet.TabIndex = 37;
            rBtnEWallet.TabStop = true;
            rBtnEWallet.Text = "E-Wallet";
            rBtnEWallet.UseVisualStyleBackColor = true;
            rBtnEWallet.CheckedChanged += rBtnEWallet_CheckedChanged;
            // 
            // rBtnCash
            // 
            rBtnCash.AutoSize = true;
            rBtnCash.Location = new Point(64, 200);
            rBtnCash.Name = "rBtnCash";
            rBtnCash.Size = new Size(76, 26);
            rBtnCash.TabIndex = 36;
            rBtnCash.TabStop = true;
            rBtnCash.Text = "Cash";
            rBtnCash.UseVisualStyleBackColor = true;
            rBtnCash.CheckedChanged += rBtnCash_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.8F);
            label9.Location = new Point(19, 164);
            label9.Name = "label9";
            label9.Size = new Size(174, 21);
            label9.TabIndex = 35;
            label9.Text = "Payment Methods";
            // 
            // cbxCondoPayFreq
            // 
            cbxCondoPayFreq.FormattingEnabled = true;
            cbxCondoPayFreq.Items.AddRange(new object[] { "Monthly", "Quarterly", "Annually" });
            cbxCondoPayFreq.Location = new Point(225, 127);
            cbxCondoPayFreq.Name = "cbxCondoPayFreq";
            cbxCondoPayFreq.Size = new Size(115, 30);
            cbxCondoPayFreq.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F);
            label6.Location = new Point(18, 131);
            label6.Name = "label6";
            label6.Size = new Size(191, 21);
            label6.TabIndex = 26;
            label6.Text = "Payment Frequency";
            // 
            // tbxCondoPrice
            // 
            tbxCondoPrice.Location = new Point(195, 87);
            tbxCondoPrice.Name = "tbxCondoPrice";
            tbxCondoPrice.Size = new Size(164, 30);
            tbxCondoPrice.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.8F);
            label8.Location = new Point(19, 89);
            label8.Name = "label8";
            label8.Size = new Size(149, 21);
            label8.TabIndex = 25;
            label8.Text = "Price Per Month";
            // 
            // cmbCondoType
            // 
            cmbCondoType.FormattingEnabled = true;
            cmbCondoType.Items.AddRange(new object[] { "Rental", "Owned" });
            cmbCondoType.Location = new Point(225, 40);
            cmbCondoType.Name = "cmbCondoType";
            cmbCondoType.Size = new Size(115, 30);
            cmbCondoType.TabIndex = 23;
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
            // grbCondoStruct
            // 
            grbCondoStruct.BackColor = Color.FromArgb(0, 148, 115);
            grbCondoStruct.Controls.Add(nUPCondoRoomPerFloor);
            grbCondoStruct.Controls.Add(nUPCondoTotFloors);
            grbCondoStruct.Controls.Add(label5);
            grbCondoStruct.Controls.Add(label3);
            grbCondoStruct.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbCondoStruct.ForeColor = Color.White;
            grbCondoStruct.Location = new Point(37, 382);
            grbCondoStruct.Name = "grbCondoStruct";
            grbCondoStruct.Size = new Size(371, 180);
            grbCondoStruct.TabIndex = 27;
            grbCondoStruct.TabStop = false;
            grbCondoStruct.Text = "Building Structure";
            // 
            // nUPCondoRoomPerFloor
            // 
            nUPCondoRoomPerFloor.Location = new Point(276, 81);
            nUPCondoRoomPerFloor.Name = "nUPCondoRoomPerFloor";
            nUPCondoRoomPerFloor.Size = new Size(76, 30);
            nUPCondoRoomPerFloor.TabIndex = 5;
            // 
            // nUPCondoTotFloors
            // 
            nUPCondoTotFloors.Location = new Point(276, 40);
            nUPCondoTotFloors.Name = "nUPCondoTotFloors";
            nUPCondoTotFloors.Size = new Size(76, 30);
            nUPCondoTotFloors.TabIndex = 4;
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
            // grbCondoInfo
            // 
            grbCondoInfo.BackColor = Color.FromArgb(0, 148, 115);
            grbCondoInfo.Controls.Add(tbxCondoContact);
            grbCondoInfo.Controls.Add(tbxCondoAddress);
            grbCondoInfo.Controls.Add(tbxCondoName);
            grbCondoInfo.Controls.Add(label4);
            grbCondoInfo.Controls.Add(label2);
            grbCondoInfo.Controls.Add(label1);
            grbCondoInfo.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbCondoInfo.ForeColor = Color.White;
            grbCondoInfo.Location = new Point(37, 141);
            grbCondoInfo.Name = "grbCondoInfo";
            grbCondoInfo.Size = new Size(371, 226);
            grbCondoInfo.TabIndex = 26;
            grbCondoInfo.TabStop = false;
            grbCondoInfo.Text = "Condominium Information";
            // 
            // tbxCondoContact
            // 
            tbxCondoContact.Location = new Point(166, 165);
            tbxCondoContact.Name = "tbxCondoContact";
            tbxCondoContact.Size = new Size(199, 30);
            tbxCondoContact.TabIndex = 7;
            // 
            // tbxCondoAddress
            // 
            tbxCondoAddress.Location = new Point(166, 103);
            tbxCondoAddress.Multiline = true;
            tbxCondoAddress.Name = "tbxCondoAddress";
            tbxCondoAddress.Size = new Size(199, 49);
            tbxCondoAddress.TabIndex = 5;
            // 
            // tbxCondoName
            // 
            tbxCondoName.Location = new Point(166, 43);
            tbxCondoName.Multiline = true;
            tbxCondoName.Name = "tbxCondoName";
            tbxCondoName.Size = new Size(199, 54);
            tbxCondoName.TabIndex = 4;
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
            label1.Size = new Size(131, 21);
            label1.TabIndex = 0;
            label1.Text = "Condo Name";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(0, 148, 115);
            groupBox1.Controls.Add(cbxGym);
            groupBox1.Controls.Add(cbxUtilities);
            groupBox1.Controls.Add(cbxClubhouse);
            groupBox1.Controls.Add(cbxParking);
            groupBox1.Controls.Add(cbxSecurity);
            groupBox1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(671, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 140);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Amenities";
            // 
            // cbxGym
            // 
            cbxGym.AutoSize = true;
            cbxGym.Location = new Point(285, 55);
            cbxGym.Name = "cbxGym";
            cbxGym.Size = new Size(74, 26);
            cbxGym.TabIndex = 4;
            cbxGym.Text = "Gym";
            cbxGym.UseVisualStyleBackColor = true;
            // 
            // cbxUtilities
            // 
            cbxUtilities.AutoSize = true;
            cbxUtilities.Location = new Point(147, 67);
            cbxUtilities.Name = "cbxUtilities";
            cbxUtilities.Size = new Size(90, 26);
            cbxUtilities.TabIndex = 3;
            cbxUtilities.Text = "Utilities";
            cbxUtilities.UseVisualStyleBackColor = true;
            // 
            // cbxClubhouse
            // 
            cbxClubhouse.AutoSize = true;
            cbxClubhouse.Location = new Point(147, 35);
            cbxClubhouse.Name = "cbxClubhouse";
            cbxClubhouse.Size = new Size(127, 26);
            cbxClubhouse.TabIndex = 2;
            cbxClubhouse.Text = "Clubhouse";
            cbxClubhouse.UseVisualStyleBackColor = true;
            // 
            // cbxParking
            // 
            cbxParking.AutoSize = true;
            cbxParking.Location = new Point(29, 67);
            cbxParking.Name = "cbxParking";
            cbxParking.Size = new Size(97, 26);
            cbxParking.TabIndex = 1;
            cbxParking.Text = "Parking";
            cbxParking.UseVisualStyleBackColor = true;
            // 
            // cbxSecurity
            // 
            cbxSecurity.AutoSize = true;
            cbxSecurity.Location = new Point(29, 35);
            cbxSecurity.Name = "cbxSecurity";
            cbxSecurity.Size = new Size(101, 26);
            cbxSecurity.TabIndex = 0;
            cbxSecurity.Text = "Security";
            cbxSecurity.UseVisualStyleBackColor = true;
            // 
            // RegisterCondominium
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1085, 652);
            Controls.Add(groupBox1);
            Controls.Add(btnCondoInfoRegister);
            Controls.Add(btnCondoInfoCancel);
            Controls.Add(grbCondoSetUp);
            Controls.Add(grbCondoStruct);
            Controls.Add(grbCondoInfo);
            Controls.Add(iconbtnMinimized);
            Controls.Add(iconbtnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterCondominium";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterCondominium";
            grbCondoSetUp.ResumeLayout(false);
            grbCondoSetUp.PerformLayout();
            grbCondoStruct.ResumeLayout(false);
            grbCondoStruct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUPCondoRoomPerFloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPCondoTotFloors).EndInit();
            grbCondoInfo.ResumeLayout(false);
            grbCondoInfo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconbtnClose;
        private FontAwesome.Sharp.IconButton iconbtnMinimized;
        private Button btnCondoInfoRegister;
        private Button btnCondoInfoCancel;
        private GroupBox grbCondoSetUp;
        private TextBox tbxCondoPrice;
        private Label label8;
        private ComboBox cmbCondoType;
        private Label label7;
        private GroupBox grbCondoStruct;
        private NumericUpDown nUPCondoRoomPerFloor;
        private NumericUpDown nUPCondoTotFloors;
        private Label label5;
        private Label label3;
        private GroupBox grbCondoInfo;
        private TextBox tbxCondoContact;
        private TextBox tbxCondoAddress;
        private TextBox tbxCondoName;
        private Label label4;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private CheckBox cbxGym;
        private CheckBox cbxUtilities;
        private CheckBox cbxClubhouse;
        private CheckBox cbxParking;
        private CheckBox cbxSecurity;
        private ComboBox cbxCondoPayFreq;
        private Label label6;
        private RadioButton rBtnBankTransfer;
        private RadioButton rBtnEWallet;
        private RadioButton rBtnCash;
        private Label label9;
    }
}
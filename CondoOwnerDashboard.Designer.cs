namespace RentWise_
{
    partial class CondoOwnerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CondoOwnerDashboard));
            iconbtnClose = new FontAwesome.Sharp.IconButton();
            iconbtnMinimized = new FontAwesome.Sharp.IconButton();
            tbxCondoName = new TextBox();
            label1 = new Label();
            panel7 = new Panel();
            iconCondoAmenities = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            iconbtnOwnerSettings = new FontAwesome.Sharp.IconButton();
            iconbtnPayments = new FontAwesome.Sharp.IconButton();
            iconbtnRooms = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            iconBtnDormer = new FontAwesome.Sharp.IconButton();
            pnlDormer = new Panel();
            iconbtnSearchDormerName = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            dgvDormerTable = new DataGridView();
            iconbtnDormerDelete = new FontAwesome.Sharp.IconButton();
            iconbtnLoad = new FontAwesome.Sharp.IconButton();
            tbxSearchDormerName = new TextBox();
            pnlRooms = new Panel();
            iconBtnOccupancyRate = new FontAwesome.Sharp.IconButton();
            panel6 = new Panel();
            cmbChooseRoom = new ComboBox();
            label2 = new Label();
            iconBtnCondoLoadRoom = new FontAwesome.Sharp.IconButton();
            dgvRoomTable = new DataGridView();
            pnlPayments = new Panel();
            btnCondoConfirmPayment = new Button();
            panel8 = new Panel();
            iconbtnPaymentDormerSearch = new FontAwesome.Sharp.IconButton();
            tbxCondoSearchPayment = new TextBox();
            iconBtnUpdatePayment = new FontAwesome.Sharp.IconButton();
            iconbtnLoadPayment = new FontAwesome.Sharp.IconButton();
            dgvPaymentTable = new DataGridView();
            pnlOwnerSettings = new Panel();
            btnResetPassword = new Button();
            panel14 = new Panel();
            tbxConfirmedPass = new TextBox();
            panel13 = new Panel();
            label10 = new Label();
            tbxNewPass = new TextBox();
            panel12 = new Panel();
            label9 = new Label();
            tbxPrevPass = new TextBox();
            btnUpdate = new Button();
            label8 = new Label();
            panel11 = new Panel();
            tbxLastName = new TextBox();
            panel10 = new Panel();
            tbxUserName = new TextBox();
            panel9 = new Panel();
            tbxFirstName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            label4 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            iconbtnLogOut = new FontAwesome.Sharp.IconButton();
            iconpbxOwnerPP = new FontAwesome.Sharp.IconPictureBox();
            pbxOwnerPP = new PictureBox();
            pnlCondoAmenities = new Panel();
            lblCondoName = new Label();
            pnlDormer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDormerTable).BeginInit();
            pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomTable).BeginInit();
            pnlPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaymentTable).BeginInit();
            pnlOwnerSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconpbxOwnerPP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxOwnerPP).BeginInit();
            pnlCondoAmenities.SuspendLayout();
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
            iconbtnClose.TabIndex = 9;
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
            iconbtnMinimized.TabIndex = 10;
            iconbtnMinimized.UseVisualStyleBackColor = false;
            iconbtnMinimized.Click += iconbtnMinimized_Click;
            // 
            // tbxCondoName
            // 
            tbxCondoName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxCondoName.Location = new Point(58, 155);
            tbxCondoName.Name = "tbxCondoName";
            tbxCondoName.Size = new Size(153, 28);
            tbxCondoName.TabIndex = 25;
            tbxCondoName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 188);
            label1.Name = "label1";
            label1.Size = new Size(68, 22);
            label1.TabIndex = 26;
            label1.Text = "Owner";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 148, 115);
            panel7.Location = new Point(12, 471);
            panel7.Name = "panel7";
            panel7.Size = new Size(182, 5);
            panel7.TabIndex = 43;
            // 
            // iconCondoAmenities
            // 
            iconCondoAmenities.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconCondoAmenities.IconChar = FontAwesome.Sharp.IconChar.Message;
            iconCondoAmenities.IconColor = Color.Black;
            iconCondoAmenities.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCondoAmenities.ImageAlign = ContentAlignment.MiddleLeft;
            iconCondoAmenities.Location = new Point(12, 426);
            iconCondoAmenities.Name = "iconCondoAmenities";
            iconCondoAmenities.Size = new Size(182, 49);
            iconCondoAmenities.TabIndex = 44;
            iconCondoAmenities.Text = "Amenities";
            iconCondoAmenities.UseVisualStyleBackColor = true;
            iconCondoAmenities.Click += iconCondoAmenities_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 148, 115);
            panel5.Location = new Point(12, 543);
            panel5.Name = "panel5";
            panel5.Size = new Size(182, 5);
            panel5.TabIndex = 39;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 148, 115);
            panel4.Location = new Point(12, 396);
            panel4.Name = "panel4";
            panel4.Size = new Size(182, 5);
            panel4.TabIndex = 38;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 148, 115);
            panel3.Location = new Point(12, 322);
            panel3.Name = "panel3";
            panel3.Size = new Size(182, 5);
            panel3.TabIndex = 37;
            // 
            // iconbtnOwnerSettings
            // 
            iconbtnOwnerSettings.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconbtnOwnerSettings.IconChar = FontAwesome.Sharp.IconChar.Bars;
            iconbtnOwnerSettings.IconColor = Color.Black;
            iconbtnOwnerSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnOwnerSettings.ImageAlign = ContentAlignment.MiddleLeft;
            iconbtnOwnerSettings.Location = new Point(12, 498);
            iconbtnOwnerSettings.Name = "iconbtnOwnerSettings";
            iconbtnOwnerSettings.Size = new Size(182, 49);
            iconbtnOwnerSettings.TabIndex = 42;
            iconbtnOwnerSettings.Text = "Settings";
            iconbtnOwnerSettings.UseVisualStyleBackColor = true;
            iconbtnOwnerSettings.Click += iconbtnOwnerSettings_Click;
            // 
            // iconbtnPayments
            // 
            iconbtnPayments.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconbtnPayments.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            iconbtnPayments.IconColor = Color.Black;
            iconbtnPayments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnPayments.ImageAlign = ContentAlignment.MiddleLeft;
            iconbtnPayments.Location = new Point(12, 352);
            iconbtnPayments.Name = "iconbtnPayments";
            iconbtnPayments.Size = new Size(182, 49);
            iconbtnPayments.TabIndex = 41;
            iconbtnPayments.Text = "Payments";
            iconbtnPayments.UseVisualStyleBackColor = true;
            iconbtnPayments.Click += iconbtnPayments_Click;
            // 
            // iconbtnRooms
            // 
            iconbtnRooms.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconbtnRooms.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconbtnRooms.IconColor = Color.Black;
            iconbtnRooms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnRooms.ImageAlign = ContentAlignment.MiddleLeft;
            iconbtnRooms.Location = new Point(12, 278);
            iconbtnRooms.Name = "iconbtnRooms";
            iconbtnRooms.Size = new Size(182, 49);
            iconbtnRooms.TabIndex = 40;
            iconbtnRooms.Text = "Rooms";
            iconbtnRooms.UseVisualStyleBackColor = true;
            iconbtnRooms.Click += iconbtnRooms_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 148, 115);
            panel2.Location = new Point(12, 254);
            panel2.Name = "panel2";
            panel2.Size = new Size(182, 5);
            panel2.TabIndex = 35;
            // 
            // iconBtnDormer
            // 
            iconBtnDormer.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconBtnDormer.IconChar = FontAwesome.Sharp.IconChar.User;
            iconBtnDormer.IconColor = Color.Black;
            iconBtnDormer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnDormer.ImageAlign = ContentAlignment.MiddleLeft;
            iconBtnDormer.Location = new Point(12, 210);
            iconBtnDormer.Name = "iconBtnDormer";
            iconBtnDormer.Size = new Size(182, 49);
            iconBtnDormer.TabIndex = 36;
            iconBtnDormer.Text = "Renter";
            iconBtnDormer.UseVisualStyleBackColor = true;
            iconBtnDormer.Click += iconBtnDormer_Click;
            // 
            // pnlDormer
            // 
            pnlDormer.BackColor = Color.Transparent;
            pnlDormer.Controls.Add(iconbtnSearchDormerName);
            pnlDormer.Controls.Add(panel1);
            pnlDormer.Controls.Add(dgvDormerTable);
            pnlDormer.Controls.Add(iconbtnDormerDelete);
            pnlDormer.Controls.Add(iconbtnLoad);
            pnlDormer.Controls.Add(tbxSearchDormerName);
            pnlDormer.ForeColor = SystemColors.ButtonHighlight;
            pnlDormer.Location = new Point(268, 58);
            pnlDormer.Name = "pnlDormer";
            pnlDormer.Size = new Size(784, 568);
            pnlDormer.TabIndex = 45;
            // 
            // iconbtnSearchDormerName
            // 
            iconbtnSearchDormerName.BackColor = Color.FromArgb(0, 148, 115);
            iconbtnSearchDormerName.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            iconbtnSearchDormerName.IconColor = Color.White;
            iconbtnSearchDormerName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnSearchDormerName.IconSize = 25;
            iconbtnSearchDormerName.Location = new Point(277, 18);
            iconbtnSearchDormerName.Name = "iconbtnSearchDormerName";
            iconbtnSearchDormerName.Size = new Size(34, 34);
            iconbtnSearchDormerName.TabIndex = 6;
            iconbtnSearchDormerName.UseVisualStyleBackColor = false;
            iconbtnSearchDormerName.Click += iconbtnSearchDormerName_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 148, 115);
            panel1.Location = new Point(61, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 5);
            panel1.TabIndex = 1;
            // 
            // dgvDormerTable
            // 
            dgvDormerTable.BackgroundColor = Color.DarkGray;
            dgvDormerTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDormerTable.Location = new Point(61, 111);
            dgvDormerTable.Name = "dgvDormerTable";
            dgvDormerTable.RowHeadersWidth = 51;
            dgvDormerTable.Size = new Size(686, 418);
            dgvDormerTable.TabIndex = 0;
            // 
            // iconbtnDormerDelete
            // 
            iconbtnDormerDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconbtnDormerDelete.IconColor = Color.FromArgb(0, 148, 115);
            iconbtnDormerDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnDormerDelete.IconSize = 34;
            iconbtnDormerDelete.Location = new Point(625, 58);
            iconbtnDormerDelete.Name = "iconbtnDormerDelete";
            iconbtnDormerDelete.Size = new Size(54, 40);
            iconbtnDormerDelete.TabIndex = 3;
            iconbtnDormerDelete.UseVisualStyleBackColor = true;
            iconbtnDormerDelete.Click += iconbtnDormerDelete_Click;
            // 
            // iconbtnLoad
            // 
            iconbtnLoad.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            iconbtnLoad.IconColor = Color.FromArgb(0, 148, 115);
            iconbtnLoad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnLoad.IconSize = 34;
            iconbtnLoad.Location = new Point(693, 58);
            iconbtnLoad.Name = "iconbtnLoad";
            iconbtnLoad.Size = new Size(54, 40);
            iconbtnLoad.TabIndex = 4;
            iconbtnLoad.UseVisualStyleBackColor = true;
            iconbtnLoad.Click += iconbtnLoad_Click;
            // 
            // tbxSearchDormerName
            // 
            tbxSearchDormerName.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSearchDormerName.Location = new Point(61, 20);
            tbxSearchDormerName.Multiline = true;
            tbxSearchDormerName.Name = "tbxSearchDormerName";
            tbxSearchDormerName.Size = new Size(215, 38);
            tbxSearchDormerName.TabIndex = 1;
            tbxSearchDormerName.Text = "Search...";
            tbxSearchDormerName.TextChanged += tbxSearchDormerName_TextChanged;
            // 
            // pnlRooms
            // 
            pnlRooms.BackColor = Color.Transparent;
            pnlRooms.BackgroundImageLayout = ImageLayout.None;
            pnlRooms.Controls.Add(iconBtnOccupancyRate);
            pnlRooms.Controls.Add(panel6);
            pnlRooms.Controls.Add(cmbChooseRoom);
            pnlRooms.Controls.Add(label2);
            pnlRooms.Controls.Add(iconBtnCondoLoadRoom);
            pnlRooms.Controls.Add(dgvRoomTable);
            pnlRooms.Location = new Point(268, 58);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new Size(784, 568);
            pnlRooms.TabIndex = 46;
            // 
            // iconBtnOccupancyRate
            // 
            iconBtnOccupancyRate.BackColor = Color.FromArgb(0, 148, 115);
            iconBtnOccupancyRate.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconBtnOccupancyRate.ForeColor = Color.White;
            iconBtnOccupancyRate.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            iconBtnOccupancyRate.IconColor = Color.White;
            iconBtnOccupancyRate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnOccupancyRate.IconSize = 30;
            iconBtnOccupancyRate.ImageAlign = ContentAlignment.MiddleLeft;
            iconBtnOccupancyRate.Location = new Point(541, 22);
            iconBtnOccupancyRate.Name = "iconBtnOccupancyRate";
            iconBtnOccupancyRate.Size = new Size(206, 40);
            iconBtnOccupancyRate.TabIndex = 33;
            iconBtnOccupancyRate.Text = "Occupancy Rate";
            iconBtnOccupancyRate.TextAlign = ContentAlignment.MiddleRight;
            iconBtnOccupancyRate.UseVisualStyleBackColor = false;
            iconBtnOccupancyRate.Click += iconBtnOccupancyRate_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 148, 115);
            panel6.Location = new Point(198, 56);
            panel6.Name = "panel6";
            panel6.Size = new Size(136, 5);
            panel6.TabIndex = 1;
            // 
            // cmbChooseRoom
            // 
            cmbChooseRoom.FormattingEnabled = true;
            cmbChooseRoom.Location = new Point(198, 30);
            cmbChooseRoom.Name = "cmbChooseRoom";
            cmbChooseRoom.Size = new Size(136, 28);
            cmbChooseRoom.TabIndex = 25;
            cmbChooseRoom.SelectedIndexChanged += cmbChooseRoom_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 37);
            label2.Name = "label2";
            label2.Size = new Size(153, 21);
            label2.TabIndex = 24;
            label2.Text = "Choose a Room";
            // 
            // iconBtnCondoLoadRoom
            // 
            iconBtnCondoLoadRoom.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            iconBtnCondoLoadRoom.IconColor = Color.FromArgb(0, 148, 115);
            iconBtnCondoLoadRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnCondoLoadRoom.IconSize = 34;
            iconBtnCondoLoadRoom.Location = new Point(693, 67);
            iconBtnCondoLoadRoom.Name = "iconBtnCondoLoadRoom";
            iconBtnCondoLoadRoom.Size = new Size(54, 40);
            iconBtnCondoLoadRoom.TabIndex = 5;
            iconBtnCondoLoadRoom.UseVisualStyleBackColor = true;
            iconBtnCondoLoadRoom.Click += iconBtnCondoLoadRoom_Click;
            // 
            // dgvRoomTable
            // 
            dgvRoomTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomTable.Location = new Point(61, 130);
            dgvRoomTable.Name = "dgvRoomTable";
            dgvRoomTable.RowHeadersWidth = 51;
            dgvRoomTable.Size = new Size(686, 418);
            dgvRoomTable.TabIndex = 1;
            // 
            // pnlPayments
            // 
            pnlPayments.BackColor = Color.Transparent;
            pnlPayments.BackgroundImageLayout = ImageLayout.None;
            pnlPayments.Controls.Add(btnCondoConfirmPayment);
            pnlPayments.Controls.Add(panel8);
            pnlPayments.Controls.Add(iconbtnPaymentDormerSearch);
            pnlPayments.Controls.Add(tbxCondoSearchPayment);
            pnlPayments.Controls.Add(iconBtnUpdatePayment);
            pnlPayments.Controls.Add(iconbtnLoadPayment);
            pnlPayments.Controls.Add(dgvPaymentTable);
            pnlPayments.Location = new Point(236, 47);
            pnlPayments.Name = "pnlPayments";
            pnlPayments.Size = new Size(816, 576);
            pnlPayments.TabIndex = 47;
            // 
            // btnCondoConfirmPayment
            // 
            btnCondoConfirmPayment.BackColor = Color.FromArgb(0, 148, 115);
            btnCondoConfirmPayment.Font = new Font("Century Gothic", 10.8F);
            btnCondoConfirmPayment.ForeColor = Color.White;
            btnCondoConfirmPayment.Location = new Point(319, 516);
            btnCondoConfirmPayment.Name = "btnCondoConfirmPayment";
            btnCondoConfirmPayment.Size = new Size(183, 48);
            btnCondoConfirmPayment.TabIndex = 32;
            btnCondoConfirmPayment.Text = "Confirm Payment";
            btnCondoConfirmPayment.UseVisualStyleBackColor = false;
            btnCondoConfirmPayment.Click += btnCondoConfirmPayment_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 148, 115);
            panel8.Location = new Point(63, 47);
            panel8.Name = "panel8";
            panel8.Size = new Size(234, 5);
            panel8.TabIndex = 1;
            // 
            // iconbtnPaymentDormerSearch
            // 
            iconbtnPaymentDormerSearch.BackColor = Color.FromArgb(0, 148, 115);
            iconbtnPaymentDormerSearch.ForeColor = SystemColors.ControlText;
            iconbtnPaymentDormerSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            iconbtnPaymentDormerSearch.IconColor = Color.White;
            iconbtnPaymentDormerSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnPaymentDormerSearch.IconSize = 34;
            iconbtnPaymentDormerSearch.Location = new Point(245, 12);
            iconbtnPaymentDormerSearch.Name = "iconbtnPaymentDormerSearch";
            iconbtnPaymentDormerSearch.Size = new Size(54, 40);
            iconbtnPaymentDormerSearch.TabIndex = 30;
            iconbtnPaymentDormerSearch.UseVisualStyleBackColor = false;
            iconbtnPaymentDormerSearch.Click += iconbtnPaymentDormerSearch_Click;
            // 
            // tbxCondoSearchPayment
            // 
            tbxCondoSearchPayment.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxCondoSearchPayment.Location = new Point(61, 14);
            tbxCondoSearchPayment.Multiline = true;
            tbxCondoSearchPayment.Name = "tbxCondoSearchPayment";
            tbxCondoSearchPayment.Size = new Size(236, 38);
            tbxCondoSearchPayment.TabIndex = 29;
            tbxCondoSearchPayment.Text = "Search...";
            // 
            // iconBtnUpdatePayment
            // 
            iconBtnUpdatePayment.IconChar = FontAwesome.Sharp.IconChar.Pen;
            iconBtnUpdatePayment.IconColor = Color.FromArgb(0, 148, 115);
            iconBtnUpdatePayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnUpdatePayment.IconSize = 34;
            iconBtnUpdatePayment.Location = new Point(335, 45);
            iconBtnUpdatePayment.Name = "iconBtnUpdatePayment";
            iconBtnUpdatePayment.Size = new Size(54, 40);
            iconBtnUpdatePayment.TabIndex = 28;
            iconBtnUpdatePayment.UseVisualStyleBackColor = true;
            iconBtnUpdatePayment.Click += iconBtnUpdatePayment_Click;
            // 
            // iconbtnLoadPayment
            // 
            iconbtnLoadPayment.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            iconbtnLoadPayment.IconColor = Color.FromArgb(0, 148, 115);
            iconbtnLoadPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnLoadPayment.IconSize = 34;
            iconbtnLoadPayment.Location = new Point(434, 45);
            iconbtnLoadPayment.Name = "iconbtnLoadPayment";
            iconbtnLoadPayment.Size = new Size(54, 40);
            iconbtnLoadPayment.TabIndex = 5;
            iconbtnLoadPayment.UseVisualStyleBackColor = true;
            iconbtnLoadPayment.Click += iconbtnLoadPayment_Click;
            // 
            // dgvPaymentTable
            // 
            dgvPaymentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaymentTable.Location = new Point(61, 89);
            dgvPaymentTable.Name = "dgvPaymentTable";
            dgvPaymentTable.RowHeadersWidth = 51;
            dgvPaymentTable.Size = new Size(686, 418);
            dgvPaymentTable.TabIndex = 1;
            dgvPaymentTable.CellContentClick += dgvPaymentRenter_CellContentClick;
            // 
            // pnlOwnerSettings
            // 
            pnlOwnerSettings.BackColor = Color.Transparent;
            pnlOwnerSettings.BackgroundImageLayout = ImageLayout.None;
            pnlOwnerSettings.Controls.Add(btnResetPassword);
            pnlOwnerSettings.Controls.Add(panel14);
            pnlOwnerSettings.Controls.Add(tbxConfirmedPass);
            pnlOwnerSettings.Controls.Add(panel13);
            pnlOwnerSettings.Controls.Add(label10);
            pnlOwnerSettings.Controls.Add(tbxNewPass);
            pnlOwnerSettings.Controls.Add(panel12);
            pnlOwnerSettings.Controls.Add(label9);
            pnlOwnerSettings.Controls.Add(tbxPrevPass);
            pnlOwnerSettings.Controls.Add(btnUpdate);
            pnlOwnerSettings.Controls.Add(label8);
            pnlOwnerSettings.Controls.Add(panel11);
            pnlOwnerSettings.Controls.Add(tbxLastName);
            pnlOwnerSettings.Controls.Add(panel10);
            pnlOwnerSettings.Controls.Add(tbxUserName);
            pnlOwnerSettings.Controls.Add(panel9);
            pnlOwnerSettings.Controls.Add(tbxFirstName);
            pnlOwnerSettings.Controls.Add(label7);
            pnlOwnerSettings.Controls.Add(label6);
            pnlOwnerSettings.Controls.Add(label5);
            pnlOwnerSettings.Controls.Add(iconPictureBox3);
            pnlOwnerSettings.Controls.Add(label4);
            pnlOwnerSettings.Controls.Add(iconPictureBox2);
            pnlOwnerSettings.Controls.Add(label3);
            pnlOwnerSettings.Location = new Point(268, 55);
            pnlOwnerSettings.Name = "pnlOwnerSettings";
            pnlOwnerSettings.Size = new Size(784, 568);
            pnlOwnerSettings.TabIndex = 33;
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = Color.FromArgb(0, 148, 115);
            btnResetPassword.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResetPassword.ForeColor = Color.White;
            btnResetPassword.Location = new Point(513, 409);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(103, 52);
            btnResetPassword.TabIndex = 45;
            btnResetPassword.Text = "Reset";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(0, 148, 115);
            panel14.Location = new Point(239, 497);
            panel14.Name = "panel14";
            panel14.Size = new Size(190, 5);
            panel14.TabIndex = 43;
            // 
            // tbxConfirmedPass
            // 
            tbxConfirmedPass.Location = new Point(239, 464);
            tbxConfirmedPass.Multiline = true;
            tbxConfirmedPass.Name = "tbxConfirmedPass";
            tbxConfirmedPass.Size = new Size(190, 38);
            tbxConfirmedPass.TabIndex = 44;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(0, 148, 115);
            panel13.Location = new Point(239, 442);
            panel13.Name = "panel13";
            panel13.Size = new Size(190, 5);
            panel13.TabIndex = 43;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(61, 480);
            label10.Name = "label10";
            label10.Size = new Size(169, 21);
            label10.TabIndex = 42;
            label10.Text = "Confirm Password:";
            // 
            // tbxNewPass
            // 
            tbxNewPass.Location = new Point(239, 409);
            tbxNewPass.Multiline = true;
            tbxNewPass.Name = "tbxNewPass";
            tbxNewPass.Size = new Size(190, 38);
            tbxNewPass.TabIndex = 44;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(0, 148, 115);
            panel12.Location = new Point(239, 394);
            panel12.Name = "panel12";
            panel12.Size = new Size(190, 5);
            panel12.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(61, 425);
            label9.Name = "label9";
            label9.Size = new Size(139, 21);
            label9.TabIndex = 42;
            label9.Text = "New Password:";
            // 
            // tbxPrevPass
            // 
            tbxPrevPass.Location = new Point(239, 361);
            tbxPrevPass.Multiline = true;
            tbxPrevPass.Name = "tbxPrevPass";
            tbxPrevPass.Size = new Size(190, 38);
            tbxPrevPass.TabIndex = 44;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 148, 115);
            btnUpdate.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(513, 200);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(103, 52);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(61, 370);
            label8.Name = "label8";
            label8.Size = new Size(172, 21);
            label8.TabIndex = 42;
            label8.Text = "Previous Password:";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(0, 148, 115);
            panel11.Location = new Point(528, 133);
            panel11.Name = "panel11";
            panel11.Size = new Size(190, 5);
            panel11.TabIndex = 42;
            // 
            // tbxLastName
            // 
            tbxLastName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxLastName.Location = new Point(528, 100);
            tbxLastName.Multiline = true;
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(190, 38);
            tbxLastName.TabIndex = 43;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(0, 148, 115);
            panel10.Location = new Point(167, 232);
            panel10.Name = "panel10";
            panel10.Size = new Size(190, 5);
            panel10.TabIndex = 40;
            // 
            // tbxUserName
            // 
            tbxUserName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUserName.Location = new Point(167, 199);
            tbxUserName.Multiline = true;
            tbxUserName.Name = "tbxUserName";
            tbxUserName.Size = new Size(190, 38);
            tbxUserName.TabIndex = 41;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(0, 148, 115);
            panel9.Location = new Point(167, 133);
            panel9.Name = "panel9";
            panel9.Size = new Size(190, 5);
            panel9.TabIndex = 1;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxFirstName.Location = new Point(167, 100);
            tbxFirstName.Multiline = true;
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(190, 38);
            tbxFirstName.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(61, 208);
            label7.Name = "label7";
            label7.Size = new Size(110, 21);
            label7.TabIndex = 38;
            label7.Text = "User Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(402, 117);
            label6.Name = "label6";
            label6.Size = new Size(108, 21);
            label6.TabIndex = 37;
            label6.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(56, 111);
            label5.Name = "label5";
            label5.Size = new Size(105, 21);
            label5.TabIndex = 36;
            label5.Text = "First Name:";
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.FromArgb(0, 148, 115);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconPictureBox3.IconColor = Color.White;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 38;
            iconPictureBox3.Location = new Point(56, 306);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(42, 38);
            iconPictureBox3.TabIndex = 34;
            iconPictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(104, 317);
            label4.Name = "label4";
            label4.Size = new Size(156, 21);
            label4.TabIndex = 35;
            label4.Text = "Password Setting";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(0, 148, 115);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 38;
            iconPictureBox2.Location = new Point(56, 26);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(42, 38);
            iconPictureBox2.TabIndex = 33;
            iconPictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(104, 37);
            label3.Name = "label3";
            label3.Size = new Size(156, 21);
            label3.TabIndex = 33;
            label3.Text = "Account Setting";
            // 
            // iconbtnLogOut
            // 
            iconbtnLogOut.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconbtnLogOut.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            iconbtnLogOut.IconColor = Color.FromArgb(0, 148, 115);
            iconbtnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            iconbtnLogOut.Location = new Point(12, 574);
            iconbtnLogOut.Name = "iconbtnLogOut";
            iconbtnLogOut.Size = new Size(182, 49);
            iconbtnLogOut.TabIndex = 48;
            iconbtnLogOut.Text = "Log Out";
            iconbtnLogOut.UseVisualStyleBackColor = true;
            iconbtnLogOut.Click += iconbtnLogOut_Click;
            // 
            // iconpbxOwnerPP
            // 
            iconpbxOwnerPP.BackColor = SystemColors.Control;
            iconpbxOwnerPP.ForeColor = SystemColors.ControlText;
            iconpbxOwnerPP.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            iconpbxOwnerPP.IconColor = SystemColors.ControlText;
            iconpbxOwnerPP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconpbxOwnerPP.IconSize = 122;
            iconpbxOwnerPP.Location = new Point(58, 27);
            iconpbxOwnerPP.Name = "iconpbxOwnerPP";
            iconpbxOwnerPP.Size = new Size(153, 122);
            iconpbxOwnerPP.SizeMode = PictureBoxSizeMode.StretchImage;
            iconpbxOwnerPP.TabIndex = 32;
            iconpbxOwnerPP.TabStop = false;
            // 
            // pbxOwnerPP
            // 
            pbxOwnerPP.Location = new Point(58, 27);
            pbxOwnerPP.Name = "pbxOwnerPP";
            pbxOwnerPP.Size = new Size(153, 122);
            pbxOwnerPP.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxOwnerPP.TabIndex = 32;
            pbxOwnerPP.TabStop = false;
            // 
            // pnlCondoAmenities
            // 
            pnlCondoAmenities.BackColor = Color.Transparent;
            pnlCondoAmenities.Controls.Add(lblCondoName);
            pnlCondoAmenities.Location = new Point(256, 58);
            pnlCondoAmenities.Name = "pnlCondoAmenities";
            pnlCondoAmenities.Size = new Size(793, 565);
            pnlCondoAmenities.TabIndex = 49;
            // 
            // lblCondoName
            // 
            lblCondoName.AutoSize = true;
            lblCondoName.BackColor = Color.FromArgb(0, 148, 115);
            lblCondoName.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCondoName.ForeColor = Color.White;
            lblCondoName.Location = new Point(349, 18);
            lblCondoName.Name = "lblCondoName";
            lblCondoName.Size = new Size(125, 27);
            lblCondoName.TabIndex = 1;
            lblCondoName.Text = "AMENITIES";
            // 
            // CondoOwnerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1085, 652);
            Controls.Add(iconbtnLogOut);
            Controls.Add(panel7);
            Controls.Add(iconCondoAmenities);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(iconbtnOwnerSettings);
            Controls.Add(iconbtnPayments);
            Controls.Add(iconbtnRooms);
            Controls.Add(panel2);
            Controls.Add(iconBtnDormer);
            Controls.Add(tbxCondoName);
            Controls.Add(label1);
            Controls.Add(iconbtnMinimized);
            Controls.Add(iconbtnClose);
            Controls.Add(pbxOwnerPP);
            Controls.Add(iconpbxOwnerPP);
            Controls.Add(pnlPayments);
            Controls.Add(pnlRooms);
            Controls.Add(pnlDormer);
            Controls.Add(pnlCondoAmenities);
            Controls.Add(pnlOwnerSettings);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CondoOwnerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OwnerDashboard";
            Load += OwnerDashboard_Load;
            pnlDormer.ResumeLayout(false);
            pnlDormer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDormerTable).EndInit();
            pnlRooms.ResumeLayout(false);
            pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomTable).EndInit();
            pnlPayments.ResumeLayout(false);
            pnlPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaymentTable).EndInit();
            pnlOwnerSettings.ResumeLayout(false);
            pnlOwnerSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconpbxOwnerPP).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxOwnerPP).EndInit();
            pnlCondoAmenities.ResumeLayout(false);
            pnlCondoAmenities.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconbtnClose;
        private FontAwesome.Sharp.IconButton iconbtnMinimized;
        private TextBox tbxCondoName;
        private Label label1;
        private Panel panel7;
        private FontAwesome.Sharp.IconButton iconCondoAmenities;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconbtnOwnerSettings;
        private FontAwesome.Sharp.IconButton iconbtnPayments;
        private FontAwesome.Sharp.IconButton iconbtnRooms;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconBtnDormer;
        private Panel pnlDormer;
        private Panel panel1;
        private DataGridView dgvDormerTable;
        private FontAwesome.Sharp.IconButton iconbtnDormerDelete;
        private FontAwesome.Sharp.IconButton iconbtnLoad;
        private TextBox tbxSearchDormerName;
        private Panel pnlRooms;
        private FontAwesome.Sharp.IconButton iconbtnRoomDormerEdit;
        private FontAwesome.Sharp.IconButton iconbtnRoomDormerAdd;
        private FontAwesome.Sharp.IconButton iconbtnRoomDormerDel;
        private Panel panel6;
        private ComboBox cmbChooseRoom;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconBtnCondoLoadRoom;
        private DataGridView dgvRoomTable;
        private Panel pnlPayments;
        private Panel panel8;
        private FontAwesome.Sharp.IconButton iconbtnPaymentDormerSearch;
        private TextBox tbxCondoSearchPayment;
        private FontAwesome.Sharp.IconButton iconBtnUpdatePayment;
        private FontAwesome.Sharp.IconButton iconbtnLoadPayment;
        private DataGridView dgvPaymentTable;
        private Panel pnlOwnerSettings;
        private Button btnResetPassword;
        private Panel panel14;
        private TextBox tbxConfirmedPass;
        private Panel panel13;
        private Label label10;
        private TextBox tbxNewPass;
        private Panel panel12;
        private Label label9;
        private TextBox tbxPrevPass;
        private Button btnUpdate;
        private Label label8;
        private Panel panel11;
        private TextBox tbxLastName;
        private Panel panel10;
        private TextBox tbxUserName;
        private Panel panel9;
        private TextBox tbxFirstName;
        private Label label7;
        private Label label6;
        private Label label5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconbtnLogOut;
        private FontAwesome.Sharp.IconButton iconbtnSearchDormerName;
        private FontAwesome.Sharp.IconPictureBox iconpbxOwnerPP;
        private PictureBox pbxOwnerPP;
        private Button btnCondoConfirmPayment;
        private Panel pnlCondoAmenities;
        private Label lblCondoName;
        private FontAwesome.Sharp.IconButton iconBtnOccupancyRate;
    }
}
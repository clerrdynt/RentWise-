using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using RentWise_.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Controls;
using System.DirectoryServices.ActiveDirectory;

namespace RentWise_
{
    public partial class RegisterRenter : Form
    {
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\RentWise!\RentWise.accdb;";
        private decimal currentRent = 0;
        private byte[] profilepicture;

        //decimal initialRent; Newly edited
        public RegisterRenter()
        {
            InitializeComponent();
            //initialRent = price;
            LoadProperties();
            tbxRegisterRenterPassword.PasswordChar = '*'; // Hide password by default
            tbxRegisterRenterPassword.UseSystemPasswordChar = false;
        }
        private void LoadProperties()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string loadDormitoryQuery = @"
                        SELECT Property.PropertyID, Dormitory.DormitoryName AS PropertyName
                        FROM Dormitory 
                        INNER JOIN Property ON Dormitory.OwnerID = Property.OwnerID
                        WHERE Property.PropertyType = 'Dormitory'";

                    using (OleDbCommand cmd = new OleDbCommand(loadDormitoryQuery, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            cmbSelectProperty.Items.Clear();
                            while (reader.Read())
                            {
                                int propertyID = Convert.ToInt32(reader["PropertyID"]); // Ensure it's an integer
                                string propertyName = reader["PropertyName"].ToString();
                                cmbSelectProperty.Items.Add(new ComboBoxItem(propertyName, propertyID));
                                //cmbSelectProperty.Items.Add(new ComboBoxItem(reader["PropertyName"].ToString(), Convert.ToInt32(reader["PropertyID"])));
                            }
                        }
                    }

                    string loadCondoQuery = @"
                        SELECT Property.PropertyID, Condominium.CondoName AS PropertyName
                        FROM Condominium
                        INNER JOIN Property ON Condominium.OwnerID = Property.OwnerID
                        WHERE Property.PropertyType = 'Condominium'";

                    using (OleDbCommand cmd = new OleDbCommand(loadCondoQuery, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int propertyID = Convert.ToInt32(reader["PropertyID"]); // Ensure it's an integer
                                string propertyName = reader["PropertyName"].ToString();
                                cmbSelectProperty.Items.Add(new ComboBoxItem(propertyName, propertyID));
                                //cmbSelectProperty.Items.Add(new ComboBoxItem(reader["PropertyName"].ToString(), Convert.ToInt32(reader["PropertyID"])));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading properties: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadRooms(int propertyID)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string propertyType = GetPropertyType(propertyID); // Get property type based on PropertyID
                    if (propertyType == "Unknown")
                    {
                        MessageBox.Show("Unknown property type for the selected property.");
                        return;
                    }

                    if (propertyType == "Dormitory")
                    {
                        string query = "SELECT RoomNumber FROM Room WHERE PropertyID = @PropertyID AND Status = 'Vacant'";

                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@PropertyID", propertyID);
                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                cmbSelectRoomNo.Items.Clear();
                                if (!reader.HasRows)  // Check if there are any rooms returned
                                {
                                    MessageBox.Show("No vacant rooms available for this property.", "No Rooms Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                while (reader.Read())
                                {
                                    cmbSelectRoomNo.Items.Add(reader["RoomNumber"].ToString());
                                }
                            }
                        }

                    }
                    else if (propertyType == "Condominium")
                    {
                        string query = "SELECT UnitNumber FROM CondoRoom WHERE PropertyID = @PropertyID AND Status = 'Vacant'";

                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@PropertyID", propertyID);
                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                cmbSelectRoomNo.Items.Clear();
                                if (!reader.HasRows)  // Check if there are any rooms returned
                                {
                                    MessageBox.Show("No vacant rooms available for this property.", "No Rooms Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                while (reader.Read())
                                {
                                    cmbSelectRoomNo.Items.Add(reader["UnitNumber"].ToString());
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unknown property type.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT RoomNumber FROM Room WHERE PropertyID = @PropertyID AND Status = 'Vacant'";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PropertyID", propertyID);
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            cmbSelectRoomNo.Items.Clear();
                            if (!reader.HasRows)  // Check if there are any rooms returned
                            {
                                MessageBox.Show("No vacant rooms available for this property.", "No Rooms Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            while (reader.Read())
                            {
                                cmbSelectRoomNo.Items.Add(reader["RoomNumber"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        private string GetPropertyType(int propertyID)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();

                string query = "SELECT PropertyType FROM Property WHERE PropertyID = @PropertyID";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PropertyID", propertyID);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                        return result.ToString();
                    else
                        return "Unknown";
                }
            }
        }
        public class ComboBoxItem
        {
            public string Text { get; }
            public int Value { get; }

            public ComboBoxItem(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text; // Display Property Name in ComboBox
            }
        }
        public class RenterRegistration : UserAuthentication
        {
            public string SelectedRoomNumber { get; set; }
            private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\RentWise!\RentWise.accdb;";

            public override bool Register()
            {
                try
                {
                    using (OleDbConnection conn = new OleDbConnection(connString))
                    {
                        conn.Open();
                        string query = "INSERT INTO Renter ([FirstName], [LastName], [UserName], [Password], [PhoneNumber], [Email], [PropertyID], [Birthday], [RenterPic]) " +
                                       "VALUES (@FirstName, @LastName, @Username, @Password, @PhoneNumber, @Email, @PropertyID, @Birthday, @RenterPic)";

                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@FirstName", FirstName);
                            cmd.Parameters.AddWithValue("@LastName", LastName);
                            cmd.Parameters.AddWithValue("@Username", Username);
                            cmd.Parameters.AddWithValue("@Password", Password);
                            cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                            cmd.Parameters.AddWithValue("@Email", Email);
                            cmd.Parameters.Add("@PropertyID", OleDbType.Integer).Value = PropertyID; // Ensure PropertyID is an integer
                            cmd.Parameters.Add("@Birthday", OleDbType.Date).Value = Birthday;
                            if (ProfilePicture == null || ProfilePicture.Length == 0)
                            {
                                cmd.Parameters.Add("@RenterPic", OleDbType.Binary).Value = DBNull.Value;
                            }
                            else
                            {
                                cmd.Parameters.Add("@RenterPic", OleDbType.Binary).Value = ProfilePicture;
                            }

                            cmd.ExecuteNonQuery();
                            return true; // Registration successful
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while registering: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Registration failed
                }
            }
        }
        private void iconbtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
        private void iconbtnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRenterInfoRegister_Click(object sender, EventArgs e)
        {
            if (profilepicture != null && profilepicture.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(profilepicture))
                {
                    Bitmap selectedImage = new Bitmap(ms);
                    pbxRenterPP.Image = selectedImage;
                }
            }

            RenterRegistration renter = new RenterRegistration
            {
                FirstName = tbxRegisterRenterFirstName.Text.Trim(),
                LastName = tbxRegisterRenterLastName.Text.Trim(),
                Username = tbxRegisterRenterUsername.Text.Trim(),
                Password = tbxRegisterRenterPassword.Text.Trim(),
                PhoneNumber = tbxRegisterRenterPhoneNo.Text.Trim(),
                Email = tbxRegisterRenterEmail.Text.Trim(),
                Birthday = dTPRenterBirthday.Value,
                ProfilePicture = profilepicture // Store the byte[] representation of the image
            };

            // Validation
            if (string.IsNullOrEmpty(renter.FirstName) || string.IsNullOrEmpty(renter.LastName) ||
                string.IsNullOrEmpty(renter.Username) || string.IsNullOrEmpty(renter.Password) ||
                string.IsNullOrEmpty(renter.Email) || string.IsNullOrEmpty(renter.PhoneNumber) ||
                renter.Birthday == DateTime.MinValue)
            {
                MessageBox.Show("Please fill out all fields before registering.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSelectProperty.SelectedItem is ComboBoxItem selectedProperty)
            {
                renter.PropertyID = selectedProperty.Value;
            }
            else
            {
                MessageBox.Show("Please select a property before registering.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSelectRoomNo.SelectedItem != null)
            {
                renter.SelectedRoomNumber = cmbSelectRoomNo.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select a room before registering.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int renterID;
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    //  Step 1: Ensure Property Exists
                    string checkPropertyQuery = "SELECT COUNT(*) FROM Property WHERE PropertyID = @PropertyID";
                    using (OleDbCommand checkPropertyCmd = new OleDbCommand(checkPropertyQuery, conn))
                    {
                        checkPropertyCmd.Parameters.AddWithValue("@PropertyID", renter.PropertyID);
                        int propertyExists = Convert.ToInt32(checkPropertyCmd.ExecuteScalar());

                        if (propertyExists == 0)
                        {
                            MessageBox.Show("The selected property does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    // Step 2: Ensure Room/Unit Exists and is Available
                    string propertyType = "";
                    string typeQuery = "SELECT PropertyType FROM Property WHERE PropertyID = @PropertyID";
                    using (OleDbCommand typeCmd = new OleDbCommand(typeQuery, conn))
                    {
                        typeCmd.Parameters.AddWithValue("@PropertyID", renter.PropertyID);
                        object result = typeCmd.ExecuteScalar();
                        if (result != null)
                            propertyType = result.ToString();
                        else
                        {
                            MessageBox.Show("Property type could not be determined.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    bool roomAvailable = false;

                    if (propertyType == "Dormitory")
                    {
                        string checkRoomQuery = "SELECT COUNT(*) FROM Room WHERE PropertyID = @PropertyID AND RoomNumber = @RoomNumber AND RenterID IS NULL AND Status = 'Vacant'";
                        using (OleDbCommand checkCmd = new OleDbCommand(checkRoomQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@PropertyID", renter.PropertyID);
                            checkCmd.Parameters.AddWithValue("@RoomNumber", renter.SelectedRoomNumber);
                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                            roomAvailable = count > 0;
                        }
                    }
                    else if (propertyType == "Condominium")
                    {
                        string checkUnitQuery = "SELECT COUNT(*) FROM CondoRoom WHERE PropertyID = @PropertyID AND UnitNumber = @UnitNumber AND RenterID IS NULL AND Status = 'Vacant'";
                        using (OleDbCommand checkCmd = new OleDbCommand(checkUnitQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@PropertyID", renter.PropertyID);
                            checkCmd.Parameters.AddWithValue("@UnitNumber", renter.SelectedRoomNumber);
                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                            roomAvailable = count > 0;
                        }
                    }

                    if (!roomAvailable)
                    {
                        MessageBox.Show("The selected room/unit does not exist or is already occupied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Step 3: Insert Renter
                    string registerQuery = "INSERT INTO Renter ([FirstName], [LastName], [UserName], [Password], [PhoneNumber], [Email], [Birthday], [RenterPic]) " +
                                           "VALUES (@FirstName, @LastName, @Username, @Password, @PhoneNumber, @Email, @Birthday, @RenterPic)";

                    using (OleDbCommand cmd = new OleDbCommand(registerQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", renter.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", renter.LastName);
                        cmd.Parameters.AddWithValue("@Username", renter.Username);
                        cmd.Parameters.AddWithValue("@Password", renter.Password);
                        cmd.Parameters.AddWithValue("@PhoneNumber", renter.PhoneNumber);
                        cmd.Parameters.AddWithValue("@Email", renter.Email);
                        cmd.Parameters.AddWithValue("@Birthday", renter.Birthday.ToShortDateString());
                        if (renter.ProfilePicture == null || renter.ProfilePicture.Length == 0)
                        {
                            cmd.Parameters.Add("@RenterPic", OleDbType.Binary).Value = DBNull.Value;
                        }
                        else
                        {
                            cmd.Parameters.Add("@RenterPic", OleDbType.Binary).Value = renter.ProfilePicture;
                        }
                        //cmd.Parameters.AddWithValue("@PropertyID", renter.PropertyID);
                        cmd.ExecuteNonQuery();
                    }

                    // Step 4: Retrieve Last Inserted RenterID
                    //int renterID;
                    string getLastRenterIDQuery = "SELECT MAX(RenterID) FROM Renter"; // FIXED: More reliable than @@IDENTITY
                    using (OleDbCommand cmd = new OleDbCommand(getLastRenterIDQuery, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        renterID = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    }

                    // Debugging: Ensure RenterID is correctly retrieved
                    //MessageBox.Show("DEBUG: Assigned RenterID = " + renterID);

                    if (renterID > 0)
                    {
                        // Step 5: Assign RenterID to Room
                        System.Threading.Thread.Sleep(100); // Small delay to allow database commit
                        if (propertyType == "Dormitory")
                        {
                            string updateRoomQuery = "UPDATE Room SET Status = 'Occupied', RenterID = @RenterID " +
                                                     "WHERE PropertyID = @PropertyID AND RoomNumber = @RoomNumber AND RenterID IS NULL";

                            using (OleDbCommand cmd = new OleDbCommand(updateRoomQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@RenterID", renterID);
                                cmd.Parameters.AddWithValue("@PropertyID", renter.PropertyID);
                                cmd.Parameters.AddWithValue("@RoomNumber", renter.SelectedRoomNumber);
                                int rowsUpdated = cmd.ExecuteNonQuery();

                                if (rowsUpdated > 0)
                                {
                                    MessageBox.Show("DEBUG: initialRent = " + currentRent);
                                    if (currentRent <= 0)
                                    {
                                        MessageBox.Show("Unable to determine monthly rent. Please make sure a valid property is selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }

                                    //Step 6: Insert Payment Table
                                    string insertPaymentQuery = "INSERT INTO Payment (RenterID, PropertyID, [Remaining Balance], PaymentDate, DueDate, Status) " +
                                                                "VALUES (@RenterID, @PropertyID, @Balance, @PayDate, @DueDate, @Status)";

                                    using (OleDbCommand paymentCmd = new OleDbCommand(insertPaymentQuery, conn))
                                    {
                                        paymentCmd.Parameters.Add("@RenterID", OleDbType.Integer).Value = renterID;
                                        paymentCmd.Parameters.Add("@PropertyID", OleDbType.Integer).Value = renter.PropertyID;
                                        paymentCmd.Parameters.Add("@Balance", OleDbType.Currency).Value = currentRent;
                                        paymentCmd.Parameters.Add("@PayDate", OleDbType.Date).Value = DateTime.Now;
                                        paymentCmd.Parameters.Add("@DueDate", OleDbType.Date).Value = DateTime.Now.AddMonths(1);
                                        paymentCmd.Parameters.Add("@Status", OleDbType.VarChar).Value = "Pending";

                                        //MessageBox.Show($"Inserting Payment:\nRenterID: {renterID}\nPropertyID: {renter.PropertyID}\nBalance: {initialRent}\nPayDate: {DateTime.Now}\nDueDate: {DateTime.Now.AddMonths(1)}\nStatus: Pending");

                                        paymentCmd.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update room. Please check if the selected room exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else if (propertyType == "Condominium")
                        {
                            string updateUnitQuery = "UPDATE CondoRoom SET Status = 'Occupied', RenterID = @RenterID " +
                                                     "WHERE PropertyID = @PropertyID AND UnitNumber = @UnitNumber AND RenterID IS NULL";

                            using (OleDbCommand cmd = new OleDbCommand(updateUnitQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@RenterID", renterID);
                                cmd.Parameters.AddWithValue("@PropertyID", renter.PropertyID);
                                cmd.Parameters.AddWithValue("@UnitNumber", renter.SelectedRoomNumber);
                                int rowsUpdated = cmd.ExecuteNonQuery();

                                if (rowsUpdated > 0)
                                {
                                    //MessageBox.Show("DEBUG: initialRent = " + currentRent);
                                    if (currentRent <= 0)
                                    {
                                        MessageBox.Show("Unable to determine monthly rent. Please make sure a valid property is selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }

                                    //Step 6: Insert Payment Table
                                    string insertPaymentQuery = "INSERT INTO Payment (RenterID, PropertyID, [Remaining Balance], PaymentDate, DueDate, Status) " +
                                                                "VALUES (@RenterID, @PropertyID, @Balance, @PayDate, @DueDate, @Status)";

                                    using (OleDbCommand paymentCmd = new OleDbCommand(insertPaymentQuery, conn))
                                    {
                                        paymentCmd.Parameters.Add("@RenterID", OleDbType.Integer).Value = renterID;
                                        paymentCmd.Parameters.Add("@PropertyID", OleDbType.Integer).Value = renter.PropertyID;
                                        paymentCmd.Parameters.Add("@Balance", OleDbType.Currency).Value = currentRent;
                                        paymentCmd.Parameters.Add("@PayDate", OleDbType.Date).Value = DateTime.Now;
                                        paymentCmd.Parameters.Add("@DueDate", OleDbType.Date).Value = DateTime.Now.AddMonths(1);
                                        paymentCmd.Parameters.Add("@Status", OleDbType.VarChar).Value = "Pending";

                                        //MessageBox.Show($"Inserting Payment:\nRenterID: {renterID}\nPropertyID: {renter.PropertyID}\nBalance: {initialRent}\nPayDate: {DateTime.Now}\nDueDate: {DateTime.Now.AddMonths(1)}\nStatus: Pending");

                                        paymentCmd.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update room. Please check if the selected room exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve RenterID.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while registering renter: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tbxRegisterRenterFirstName.Clear();
            tbxRegisterRenterLastName.Clear();
            tbxRegisterRenterUsername.Clear();
            tbxRegisterRenterPassword.Clear();
            tbxRegisterRenterEmail.Clear();
            tbxRegisterRenterPhoneNo.Clear();
            cmbSelectProperty.SelectedIndex = -1;
            cmbSelectRoomNo.SelectedIndex = -1;
            dTPRenterBirthday.Value = DateTime.Today;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void cmbSelectProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectProperty.SelectedItem is ComboBoxItem selectedProperty)
            {
                //MessageBox.Show("Selected PropertyID: " + selectedProperty.Value);  // Debugging step
                LoadRooms(selectedProperty.Value);
                //Newly added
                FetchRent(selectedProperty.Value); // Fetch rent based on selected property
            }
            foreach (var item in cmbSelectProperty.Items)
            {
                if (item is ComboBoxItem cbItem)
                {
                    //MessageBox.Show($"Stored Property: {cbItem.Text}, ID: {cbItem.Value}");
                }
            }
        }
        private void cmbSelectRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectRoomNo.SelectedItem != null)
            {
                string selectedRoom = cmbSelectRoomNo.SelectedItem.ToString();
                //MessageBox.Show("You selected Room: " + selectedRoom);
            }
        }

        private void RegisterRenter_Load(object sender, EventArgs e)
        {
            tbxRegisterRenterPassword.PasswordChar = '*'; // Hide password by default
            tbxRegisterRenterPassword.UseSystemPasswordChar = false;
        }

        //NewlyAdded
        private void FetchRent(int propertyID)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    // First, determine property type
                    string propertyTypeQuery = "SELECT PropertyType FROM Property WHERE PropertyID = @PropertyID";
                    string propertyType = "";

                    using (OleDbCommand cmd = new OleDbCommand(propertyTypeQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@PropertyID", propertyID);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                            propertyType = result.ToString();
                    }

                    decimal rent = 0;

                    if (propertyType == "Dormitory")
                    {
                        string rentQuery = @"
                    SELECT Dormitory.PricePerMonth 
                    FROM Dormitory 
                    INNER JOIN Property ON Dormitory.OwnerID = Property.OwnerID
                    WHERE Property.PropertyID = @PropertyID";

                        using (OleDbCommand cmd = new OleDbCommand(rentQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@PropertyID", propertyID);
                            object result = cmd.ExecuteScalar();
                            if (result != null)
                                rent = Convert.ToDecimal(result);
                        }
                    }
                    else if (propertyType == "Condominium")
                    {
                        string rentQuery = @"
                    SELECT Condominium.PricePerMonth 
                    FROM Condominium 
                    INNER JOIN Property ON Condominium.OwnerID = Property.OwnerID
                    WHERE Property.PropertyID = @PropertyID";

                        using (OleDbCommand cmd = new OleDbCommand(rentQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@PropertyID", propertyID);
                            object result = cmd.ExecuteScalar();
                            if (result != null)
                                rent = Convert.ToDecimal(result);
                        }
                    }
                    currentRent = rent;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching rent: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRegisterGoBack_Click(object sender, EventArgs e)
        {
            IntroForm introForm = new IntroForm();
            introForm.Show();
            this.Close();
        }

        private void iconBtnUnseePassword_Click(object sender, EventArgs e)
        {
            if (tbxRegisterRenterPassword.PasswordChar == '*')
            {
                tbxRegisterRenterPassword.PasswordChar = '\0'; // Show password
                iconBtnUnseePassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                tbxRegisterRenterPassword.PasswordChar = '*'; // Hide password
                iconBtnUnseePassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void btnUploadRenterPP_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Store the file path temporarily
                    string profilePicPath = openFileDialog.FileName;
                    Bitmap selectedImage = new Bitmap(profilePicPath);
                    pbxRenterPP.Image = selectedImage; // Display the image in PictureBox

                    // Convert selected image to byte[] for saving to database
                    using (MemoryStream ms = new MemoryStream())
                    {
                        selectedImage.Save(ms, selectedImage.RawFormat); // Save image to memory stream
                        profilepicture = ms.ToArray(); // Store byte[] representation of the image
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

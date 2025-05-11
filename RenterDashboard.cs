using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentWise_
{
    public partial class RenterDashboard : Form
    {
        private int renterID;

        public RenterDashboard(int id)
        {
            InitializeComponent();
            renterID = id;
            tbxPrevPass.PasswordChar = '*'; // Ensure password is hidden on form load
            tbxNewPass.PasswordChar = '*'; // Ensure password is hidden on form load
            tbxConfirmedPass.PasswordChar = '*'; // Ensure password is hidden on form load
        }
        public RenterDashboard()
        {
            InitializeComponent();
        }
        private void iconbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void iconbtnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconbtnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            IntroForm introForm = new IntroForm();
            introForm.Show();
            this.Hide();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> updateFields = new List<string>();
            List<object> parameters = new List<object>();

            if (!string.IsNullOrWhiteSpace(tbxFirstName.Text))
            {
                updateFields.Add("FirstName = ?");
                parameters.Add(tbxFirstName.Text.Trim());
            }
            if (!string.IsNullOrWhiteSpace(tbxLastName.Text))
            {
                updateFields.Add("LastName = ?");
                parameters.Add(tbxLastName.Text.Trim());
            }
            if (!string.IsNullOrWhiteSpace(tbxUserName.Text))
            {
                updateFields.Add("UserName = ?");
                parameters.Add(tbxUserName.Text.Trim());
            }

            if (updateFields.Count == 0)
            {
                MessageBox.Show("Please enter at least one field to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\RentWise!\RentWise.accdb;"))
                {
                    conn.Open();

                    // Build query dynamically
                    string updateQuery = "UPDATE Renter SET " + string.Join(", ", updateFields) + " WHERE RenterID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(updateQuery, conn))
                    {
                        // Add the collected parameters
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue("?", param);
                        }

                        // Add RenterID parameter at the end
                        cmd.Parameters.AddWithValue("?", renterID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Please check your details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating renter information: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadRenterName(); // Refresh the name after update
        }

        private void RenterDashboard_Load(object sender, EventArgs e)
        {
            LoadRenterProfilePicture();
            LoadRenterName();
            tbxPrevPass.PasswordChar = '*'; // Ensure password is hidden on form load
            tbxNewPass.PasswordChar = '*'; // Ensure password is hidden on form load
            tbxConfirmedPass.PasswordChar = '*'; // Ensure password is hidden on form load
        }
        private void LoadRenterProfilePicture()
        {
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\RentWise!\RentWise.accdb;";
            try
            {
                byte[] imageData = null;
                //MessageBox.Show("Owner ID: " + ownerID + "\nImage length: " + imageData?.Length, "Debug");

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT RenterPic FROM Renter WHERE RenterID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", renterID);
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            imageData = (byte[])result;
                        }
                    }
                }

                if (imageData != null && imageData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        //Image profileImage = Image.FromStream(ms);
                        pbxRenterPP.Image = Image.FromStream(ms);

                        iconpbxRenterPP.SendToBack();
                        pbxRenterPP.BringToFront();
                    }
                }
                else
                {
                    //MessageBox.Show("No profile picture found. Using default icon.", "Profile Picture", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Show default icon if no profile picture is available
                    iconpbxRenterPP.BringToFront();
                    iconpbxRenterPP.IconChar = IconChar.User;
                    iconpbxRenterPP.IconColor = Color.Gray;
                    iconpbxRenterPP.SizeMode = PictureBoxSizeMode.StretchImage;
                    iconpbxRenterPP.IconSize = 122;
                    pbxRenterPP.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile picture: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRenterResetPass_Click(object sender, EventArgs e)
        {
            string prevPassword = tbxPrevPass.Text.Trim();
            string newPassword = tbxNewPass.Text.Trim();
            string confirmPassword = tbxConfirmedPass.Text.Trim();

            // Validate inputs
            if (string.IsNullOrWhiteSpace(prevPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\RentWise!\RentWise.accdb;"))
                {
                    conn.Open();

                    // Step 1: Verify old password
                    string checkPasswordQuery = "SELECT COUNT(*) FROM Renter WHERE RenterID = ? AND Password = ?";
                    using (OleDbCommand checkCmd = new OleDbCommand(checkPasswordQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("?", renterID);
                        checkCmd.Parameters.AddWithValue("?", prevPassword);

                        int userExists = (int)checkCmd.ExecuteScalar();

                        if (userExists == 0)
                        {
                            MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Step 2: Update new password
                    string updateQuery = "UPDATE Renter SET [Password] = ? WHERE RenterID = ?";
                    using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("?", newPassword);
                        updateCmd.Parameters.AddWithValue("?", renterID);

                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbxPrevPass.Clear();
                            tbxNewPass.Clear();
                            tbxConfirmedPass.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Password update failed. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating password: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconbtnRenterPayments_Click(object sender, EventArgs e)
        {
            pnlRenterPayment.BringToFront();
            CustomizeDataGridViewRenterPayment();
            LoadPaymentDataForRenter(renterID);
        }
        private void LoadPaymentDataForRenter(int renterID)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\RentWise!\RentWise.accdb;"))
                {
                    conn.Open();

                    string query = @"
                        SELECT Room.PropertyID, Renter.FirstName, Renter.LastName, 
                               Payment.[Remaining Balance], Payment.DueDate, Payment.PaymentDate, Payment.Status
                        FROM (((Renter 
                        LEFT JOIN Room ON Renter.RenterID = Room.RenterID)
                        LEFT JOIN Property ON Room.PropertyID = Property.PropertyID)
                        LEFT JOIN Payment ON Renter.RenterID = Payment.RenterID)
                        WHERE Renter.RenterID = ?
                        ORDER BY Payment.[Remaining Balance]";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", renterID);

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable paymentTable = new DataTable();
                        adapter.Fill(paymentTable);

                        dgvPaymentRenter.DataSource = paymentTable;
                        dgvPaymentRenter.Columns["PaymentDate"].Visible = false;

                        if (!dgvPaymentRenter.Columns.Contains("ProofColumn"))
                        {
                            DataGridViewButtonColumn proofBtnColumn = new DataGridViewButtonColumn();
                            proofBtnColumn.Name = "ProofColumn";
                            proofBtnColumn.HeaderText = "Proof";
                            proofBtnColumn.Text = "View";
                            proofBtnColumn.UseColumnTextForButtonValue = true;
                            dgvPaymentRenter.Columns.Add(proofBtnColumn);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CustomizeDataGridViewRenterPayment()
        {
            dgvPaymentRenter.EnableHeadersVisualStyles = false;
            dgvPaymentRenter.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 148, 115);
            dgvPaymentRenter.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPaymentRenter.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            dgvPaymentRenter.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPaymentRenter.RowsDefaultCellStyle.BackColor = Color.FromArgb(200, 255, 200); // Light green
            dgvPaymentRenter.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(150, 255, 150); // Lighter green

            dgvPaymentRenter.GridColor = Color.DarkGreen;
            dgvPaymentRenter.BorderStyle = BorderStyle.None;
            dgvPaymentRenter.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvPaymentRenter.DefaultCellStyle.SelectionBackColor = Color.DarkGreen;
            dgvPaymentRenter.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvPaymentRenter.DefaultCellStyle.ForeColor = Color.Black; // Ensures text remains black ✅
            dgvPaymentRenter.DefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Regular);

            dgvPaymentRenter.RowTemplate.Height = 30;
            dgvPaymentRenter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void iconbtnRenterSettings_Click(object sender, EventArgs e)
        {
            pnlRenterSettings.BringToFront();
        }
        private void iconbtnAddPayment_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;

            UpdatePaymentForm updatePaymentForm = new UpdatePaymentForm(renterID);
            updatePaymentForm.StartPosition = FormStartPosition.CenterParent;

            updatePaymentForm.ShowDialog();

            this.Opacity = 1;
        }

        private void dgvPaymentRenter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewAs viewAsForm = new ViewAs();
            viewAsForm.StartPosition = FormStartPosition.CenterParent;
            viewAsForm.ShowDialog();

            if (viewAsForm.SelectedOption == ViewAs.ViewOption.None)
            {
                return; // If user closes without picking, do nothing
            }

            this.Opacity = 0.5;

            if (viewAsForm.SelectedOption == ViewAs.ViewOption.ProofPicture)
            {
                ProofPicture proofPicture = new ProofPicture(renterID);
                proofPicture.StartPosition = FormStartPosition.CenterParent;
                proofPicture.ShowDialog();
            }
            else if (viewAsForm.SelectedOption == ViewAs.ViewOption.Receipt)
            {
                string propertyID = "";
                string renterIdStr = renterID.ToString();
                string firstName = "";
                string lastName = "";
                DateTime paymentDate = DateTime.MinValue;
                bool isPaid = false;

                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\RentWise!\RentWise.accdb;";
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // Check Payment Status
                    string statusQuery = "SELECT Status FROM Payment WHERE RenterID = ?";
                    using (OleDbCommand statusCmd = new OleDbCommand(statusQuery, conn))
                    {
                        statusCmd.Parameters.AddWithValue("?", renterID);
                        object statusResult = statusCmd.ExecuteScalar();
                        if (statusResult != null && statusResult.ToString().ToLower() == "paid")
                        {
                            isPaid = true;
                        }
                    }

                    // If Paid, fetch the receipt data
                    if (isPaid)
                    {
                        string query = @"
                SELECT TOP 1 PropertyID, RenterID, FirstName, LastName, PaymentDate 
                FROM Receipt 
                WHERE RenterID = ?
                ORDER BY PaymentDate DESC";

                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("?", renterID);
                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    propertyID = reader["PropertyID"].ToString();
                                    firstName = reader["FirstName"].ToString();
                                    lastName = reader["LastName"].ToString();
                                    paymentDate = Convert.ToDateTime(reader["PaymentDate"]);
                                }
                            }
                        }

                        // Open Receipt with actual data
                        Receipt receiptForm = new Receipt(propertyID, renterIdStr, firstName, lastName, paymentDate);
                        receiptForm.StartPosition = FormStartPosition.CenterParent;
                        receiptForm.ShowDialog();
                    }
                    else
                    {
                        // Not paid, open blank receipt
                        Receipt emptyReceipt = new Receipt(); // Default constructor
                        emptyReceipt.StartPosition = FormStartPosition.CenterParent;
                        emptyReceipt.ShowDialog();
                    }
                }
            }

            this.Opacity = 1;
        }

        private void iconbtnRenterEvents_Click(object sender, EventArgs e)
        {
            pnlRenterEvents.BringToFront();
            LoadOwnerEvents();
        }
        private void LoadOwnerEvents()
        {
            flowPnlRenterEvents.Controls.Clear();

            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\RentWise!\RentWise.accdb;";
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();

                // 1. Get the PropertyID first (either from Room or CondoRoom)
                string getOwnerQuery = @"
            SELECT Property.OwnerID
            FROM Property
            WHERE PropertyID = (
                SELECT PropertyID FROM Room WHERE RenterID = ?
            )
        ";

                OleDbCommand getOwnerCmd = new OleDbCommand(getOwnerQuery, conn);
                getOwnerCmd.Parameters.AddWithValue("?", renterID);

                object ownerResult = getOwnerCmd.ExecuteScalar();

                if (ownerResult == null)
                {
                    MessageBox.Show("No property or owner found for this renter.");
                    return;
                }

                int ownerID = Convert.ToInt32(ownerResult);

                // 2. Get all events posted by this OwnerID
                string eventQuery = "SELECT EventName, EventWhen, EventWhere FROM EventPostings WHERE OwnerID = ?";
                OleDbCommand eventCmd = new OleDbCommand(eventQuery, conn);
                eventCmd.Parameters.AddWithValue("?", ownerID);

                OleDbDataReader reader = eventCmd.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader["EventName"].ToString();
                    string dateStr = reader["EventWhen"].ToString();
                    string location = reader["EventWhere"].ToString();

                    EventCard card = new EventCard();
                    card.EventName = name;
                    card.EventWhen = dateStr;
                    card.EventWhere = location;

                    card.Click += (s, e) =>
                    {
                        MessageBox.Show($"Event: {name}\nWhen: {dateStr}\nWhere: {location}", "Event Info");
                    };

                    foreach (Control control in card.Controls)
                    {
                        control.Click += (s, e) =>
                        {
                            MessageBox.Show($"Event: {name}\nWhen: {dateStr}\nWhere: {location}", "Event Info");
                        };
                    }

                    flowPnlRenterEvents.Controls.Add(card);
                }

                conn.Close();
            }
        }
        private void LoadRenterName()
        {
            try
            {
                string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\RentWise!\RentWise.accdb;";
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT FirstName, LastName FROM Renter WHERE RenterID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", renterID); // renterID should be passed when RenterDashboard is created

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string fullName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                                tbxRenterName.Text = fullName;
                            }
                            else
                            {
                                tbxRenterName.Text = "Renter not found";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading renter name: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

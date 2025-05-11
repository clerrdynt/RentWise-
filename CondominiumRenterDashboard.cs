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
    public partial class CondominiumRenterDashboard : Form
    {
        private int renterID;
        public CondominiumRenterDashboard()
        {
            InitializeComponent();
        }
        public CondominiumRenterDashboard(int id)
        {
            InitializeComponent();
            renterID = id;
            tbxPrevPass.PasswordChar = '*'; // Ensure password is hidden on form load
            tbxNewPass.PasswordChar = '*'; // Ensure password is hidden on form load
            tbxConfirmedPass.PasswordChar = '*'; // Ensure password is hidden on form load
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
            LoadCondoRenterProfilePicture();
            LoadRenterName();
            tbxPrevPass.PasswordChar = '*'; // Ensure password is hidden on form load
            tbxNewPass.PasswordChar = '*'; // Ensure password is hidden on form load
            tbxConfirmedPass.PasswordChar = '*'; // Ensure password is hidden on form load
        }
        private void LoadCondoRenterProfilePicture()
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
                        pbxCondoRenterPP.Image = Image.FromStream(ms);

                        iconpbxCondoRenterPP.SendToBack();
                        pbxCondoRenterPP.BringToFront();
                    }
                }
                else
                {
                    //MessageBox.Show("No profile picture found. Using default icon.", "Profile Picture", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Show default icon if no profile picture is available
                    iconpbxCondoRenterPP.BringToFront();
                    iconpbxCondoRenterPP.IconChar = IconChar.User;
                    iconpbxCondoRenterPP.IconColor = Color.Gray;
                    iconpbxCondoRenterPP.SizeMode = PictureBoxSizeMode.StretchImage;
                    iconpbxCondoRenterPP.IconSize = 122;
                    pbxCondoRenterPP.Image = null;
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
                        SELECT CondoRoom.PropertyID, Renter.FirstName, Renter.LastName, 
                               Payment.[Remaining Balance], Payment.DueDate, Payment.PaymentDate, Payment.Status
                        FROM (((Renter 
                        LEFT JOIN CondoRoom ON Renter.RenterID = CondoRoom.RenterID)
                        LEFT JOIN Property ON CondoRoom.PropertyID = Property.PropertyID)
                        LEFT JOIN Payment ON Renter.RenterID = Payment.RenterID)
                        WHERE Renter.RenterID = ?
                        ORDER BY Payment.[Remaining Balance]";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", renterID);

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable paymentTable = new DataTable();
                        adapter.Fill(paymentTable);

                        dgvCondoPaymentRenter.DataSource = paymentTable;
                        dgvCondoPaymentRenter.Columns["PaymentDate"].Visible = false;
                        if (!dgvCondoPaymentRenter.Columns.Contains("ProofColumn"))
                        {
                            DataGridViewButtonColumn proofBtnColumn = new DataGridViewButtonColumn();
                            proofBtnColumn.Name = "ProofColumn";
                            proofBtnColumn.HeaderText = "Proof";
                            proofBtnColumn.Text = "View";
                            proofBtnColumn.UseColumnTextForButtonValue = true;
                            dgvCondoPaymentRenter.Columns.Add(proofBtnColumn);
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
            dgvCondoPaymentRenter.EnableHeadersVisualStyles = false;
            dgvCondoPaymentRenter.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 148, 115);
            dgvCondoPaymentRenter.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCondoPaymentRenter.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            dgvCondoPaymentRenter.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCondoPaymentRenter.RowsDefaultCellStyle.BackColor = Color.FromArgb(200, 255, 200); // Light green
            dgvCondoPaymentRenter.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(150, 255, 150); // Lighter green

            dgvCondoPaymentRenter.GridColor = Color.DarkGreen;
            dgvCondoPaymentRenter.BorderStyle = BorderStyle.None;
            dgvCondoPaymentRenter.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvCondoPaymentRenter.DefaultCellStyle.SelectionBackColor = Color.DarkGreen;
            dgvCondoPaymentRenter.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvCondoPaymentRenter.DefaultCellStyle.ForeColor = Color.Black; // Ensures text remains black ✅
            dgvCondoPaymentRenter.DefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Regular);

            dgvCondoPaymentRenter.RowTemplate.Height = 30;
            dgvCondoPaymentRenter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void iconbtnRenterSettings_Click(object sender, EventArgs e)
        {
            pnlRenterSettings.BringToFront();
        }
        private void dgvCondoPaymentRenter_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                CondoProofPicture condoproofPicture = new CondoProofPicture(renterID);
                condoproofPicture.StartPosition = FormStartPosition.CenterParent;
                condoproofPicture.ShowDialog();
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

        private void iconbtnAddPayment_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;

            CondoUpdatePaymentForm condoupdatePaymentForm = new CondoUpdatePaymentForm(renterID);
            condoupdatePaymentForm.StartPosition = FormStartPosition.CenterParent;

            condoupdatePaymentForm.ShowDialog();
            this.Opacity = 1;

        }

        private void iconbtnRenterAmmenities_Click(object sender, EventArgs e)
        {
            pnlCondoAmmenities.Controls.Clear();
            pnlCondoAmmenities.BringToFront();

            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\RentWise!\RentWise.accdb;";
            int propertyID = -1;
            using (var conn = new OleDbConnection(connString))
            {
                conn.Open();
                var cmd = new OleDbCommand("SELECT PropertyID FROM CondoRoom WHERE RenterID = ?", conn);
                cmd.Parameters.AddWithValue("?", renterID); // You should have renterID available
                var result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    propertyID = Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("No assigned property found for this renter.");
                    return;
                }
            }

            using (var conn = new OleDbConnection(connString))
            {
                conn.Open();
                var cmd = new OleDbCommand("SELECT Parking, Gym, Security, Clubhouse, Utilities FROM Condominium WHERE PropertyID = ?", conn);
                cmd.Parameters.AddWithValue("?", propertyID);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var amenities = new Dictionary<string, bool>
                {
                    { "Parking", reader.GetBoolean(0) },
                    { "Gym", reader.GetBoolean(1) },
                    { "Security", reader.GetBoolean(2) },
                    { "Clubhouse", reader.GetBoolean(3) },
                    { "Utilities", reader.GetBoolean(4) }
                };

                        int y = 10;
                        foreach (var amenity in amenities)
                        {
                            if (amenity.Value)
                            {
                                string amenityName = amenity.Key;

                                // Label
                                var label = new Label
                                {
                                    Text = "✔ " + amenityName,
                                    AutoSize = true,
                                    Font = new Font("Century Gothic", 10, FontStyle.Bold),
                                    ForeColor = Color.FromArgb(0, 148, 115),
                                    Location = new Point(10, y)
                                };
                                pnlCondoAmmenities.Controls.Add(label);

                                y += 25;
                                // PictureBox
                                var pictureBox = new PictureBox
                                {
                                    Width = 150,
                                    Height = 100,
                                    SizeMode = PictureBoxSizeMode.StretchImage,
                                    Location = new Point(150, y - 5),
                                    BorderStyle = BorderStyle.FixedSingle,
                                };

                                // Load picture if exists
                                using (var picConn = new OleDbConnection(connString))
                                {
                                    picConn.Open();
                                    var picCmd = new OleDbCommand("SELECT AmenityPicture FROM CondoAmenity WHERE PropertyID = ? AND AmenityName = ?", picConn);
                                    picCmd.Parameters.AddWithValue("?", propertyID);
                                    picCmd.Parameters.AddWithValue("?", amenityName);

                                    var picResult = picCmd.ExecuteScalar();
                                    if (picResult != null && picResult != DBNull.Value)
                                    {
                                        byte[] imgBytes = (byte[])picResult;
                                        using (MemoryStream ms = new MemoryStream(imgBytes))
                                        {
                                            pictureBox.Image = Image.FromStream(ms);
                                        }
                                    }
                                }

                                pnlCondoAmmenities.Controls.Add(pictureBox);

                                y += pictureBox.Height + 10;
                            }
                        }
                    }
                }
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
                                tbxCondoRenterName.Text = fullName;
                            }
                            else
                            {
                                tbxCondoRenterName.Text = "Renter not found";
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

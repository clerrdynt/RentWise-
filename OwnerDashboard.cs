﻿using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Controls;
using System.Windows.Forms;

namespace RentWise_
{
    public partial class OwnerDashboard : Form
    {
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\RentWise!\RentWise.accdb;";
        private int ownerID; // Store logged-in owner's ID
        //string backtoStatus = "Pending";
        //private string profilePicturePath;
        private EventCard selectEventCard = null;
        public OwnerDashboard(int loggedInOwnerID)
        {
            InitializeComponent();
            ownerID = loggedInOwnerID;
            LoadOwnerProfilePicture(); // ← this uses the parameter
            tbxPrevPass.PasswordChar = '*'; // Ensure password is hidden on form load
            tbxNewPass.PasswordChar = '*'; // Ensure password is hidden on form load
            tbxConfirmedPass.PasswordChar = '*'; // Ensure password is hidden on form load
            tbxPrevPass.UseSystemPasswordChar = false;
            tbxNewPass.UseSystemPasswordChar = false;
            tbxConfirmedPass.UseSystemPasswordChar = false;
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
        private void iconBtnDormer_Click(object sender, EventArgs e)
        {
            pnlDormer.BringToFront();
            //MessageBox.Show("Logged-in Owner ID: " + ownerID.ToString(), "Owner Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CustomizeDataGridViewDormer();
            LoadRentersData();
        }
        private void CustomizeDataGridViewDormer()
        {
            dgvDormerTable.EnableHeadersVisualStyles = false;
            dgvDormerTable.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 148, 115);
            dgvDormerTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDormerTable.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            dgvDormerTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDormerTable.RowsDefaultCellStyle.BackColor = Color.FromArgb(200, 255, 200); // Light green
            dgvDormerTable.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(150, 255, 150); // Lighter green

            dgvDormerTable.GridColor = Color.DarkGreen;
            dgvDormerTable.BorderStyle = BorderStyle.None;
            dgvDormerTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvDormerTable.DefaultCellStyle.SelectionBackColor = Color.DarkGreen;
            dgvDormerTable.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvDormerTable.DefaultCellStyle.ForeColor = Color.Black; // Ensures text remains black ✅
            dgvDormerTable.DefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Regular);

            dgvDormerTable.RowTemplate.Height = 30;
            dgvDormerTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void CustomizeDataGridViewRoom()
        {
            dgvRoomTable.EnableHeadersVisualStyles = false;
            dgvRoomTable.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 148, 115);
            dgvRoomTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRoomTable.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            dgvRoomTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvRoomTable.RowsDefaultCellStyle.BackColor = Color.FromArgb(200, 255, 200); // Light green
            dgvRoomTable.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(150, 255, 150); // Lighter green

            dgvRoomTable.GridColor = Color.DarkGreen;
            dgvRoomTable.BorderStyle = BorderStyle.None;
            dgvRoomTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvRoomTable.DefaultCellStyle.SelectionBackColor = Color.DarkGreen;
            dgvRoomTable.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvRoomTable.DefaultCellStyle.ForeColor = Color.Black; // Ensures text remains black ✅
            dgvRoomTable.DefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Regular);

            dgvRoomTable.RowTemplate.Height = 30;
            dgvRoomTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void CustomizeDataGridViewPayment()
        {
            dgvPaymentTable.EnableHeadersVisualStyles = false;
            dgvPaymentTable.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 148, 115);
            dgvPaymentTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPaymentTable.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            dgvPaymentTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPaymentTable.RowsDefaultCellStyle.BackColor = Color.FromArgb(200, 255, 200); // Light green
            dgvPaymentTable.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(150, 255, 150); // Lighter green

            dgvPaymentTable.GridColor = Color.DarkGreen;
            dgvPaymentTable.BorderStyle = BorderStyle.None;
            dgvPaymentTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvPaymentTable.DefaultCellStyle.SelectionBackColor = Color.DarkGreen;
            dgvPaymentTable.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvPaymentTable.DefaultCellStyle.ForeColor = Color.Black; // Ensures text remains black ✅
            dgvPaymentTable.DefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Regular);

            dgvPaymentTable.RowTemplate.Height = 30;
            dgvPaymentTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void iconbtnRooms_Click(object sender, EventArgs e)
        {
            pnlRooms.BringToFront();
            CustomizeDataGridViewRoom();
            LoadRoomsData();
        }
        private void iconbtnPayments_Click(object sender, EventArgs e)
        {
            pnlPayments.BringToFront();
            CustomizeDataGridViewPayment();
            LoadPaymentData();
        }
        private void iconbtnOwnerSettings_Click(object sender, EventArgs e)
        {
            pnlOwnerSettings.BringToFront();
        }
        private void LoadRentersData()
        {
            string query = @"SELECT RenterID, FirstName, LastName, 
                            Birthday, PhoneNumber, Email, PropertyID, OwnerID 
                     FROM DormitoryRentersQuery 
                     WHERE OwnerID = ?";
            //string query = "SELECT * FROM DormitoryRentersQuery WHERE OwnerID = ?";

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", ownerID); // Use parameterized query

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvDormerTable.DataSource = dt;
                        dgvDormerTable.Columns["PhoneNumber"].Visible = false;
                        dgvDormerTable.Columns["PropertyID"].Visible = false;
                        dgvDormerTable.Columns["OwnerID"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load dormitory renters: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadRoomsData()
        {
            string query = "SELECT * FROM RenterPerRoomTable WHERE OwnerID = ?";

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", ownerID); // Use parameterized query

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvRoomTable.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load renters per table: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadPaymentData()
        {
            string query = @"SELECT RenterID, OwnerID, PropertyID, FirstName, LastName, 
                            [Remaining Balance], DueDate, PaymentDate, Status 
                     FROM DormitoryPaymentTable 
                     WHERE OwnerID = ?";

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", ownerID); // Use parameterized query

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvPaymentTable.DataSource = dt;

                        dgvPaymentTable.Columns["RenterID"].Visible = false;
                        dgvPaymentTable.Columns["OwnerID"].Visible = false;
                        dgvPaymentTable.Columns["PropertyID"].Visible = false;
                        dgvPaymentTable.Columns["PaymentDate"].Visible = false;

                        if (!dgvPaymentTable.Columns.Contains("ProofColumn"))
                        {
                            DataGridViewButtonColumn proofBtnColumn = new DataGridViewButtonColumn();
                            proofBtnColumn.Name = "ProofColumn";
                            proofBtnColumn.HeaderText = "Proof";
                            proofBtnColumn.Text = "View";
                            proofBtnColumn.UseColumnTextForButtonValue = true;
                            dgvPaymentTable.Columns.Add(proofBtnColumn);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load dormitory renters: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void LoadOwnerProfilePicture()
        {
            try
            {
                byte[] imageData = null;
                //MessageBox.Show("Owner ID: " + ownerID + "\nImage length: " + imageData?.Length, "Debug");

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT ProfilePicture FROM Owner WHERE ID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", ownerID);
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
                        pbxOwnerPP.Image = Image.FromStream(ms);

                        iconpbxOwnerPP.SendToBack();
                        pbxOwnerPP.BringToFront();
                    }
                }
                else
                {
                    MessageBox.Show("No profile picture found. Using default icon.", "Profile Picture", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Show default icon if no profile picture is available
                    iconpbxOwnerPP.BringToFront();
                    iconpbxOwnerPP.IconChar = IconChar.User;
                    iconpbxOwnerPP.IconColor = Color.Gray;
                    iconpbxOwnerPP.SizeMode = PictureBoxSizeMode.StretchImage;
                    iconpbxOwnerPP.IconSize = 122;
                    pbxOwnerPP.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile picture: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                    string updateQuery = "UPDATE Owner SET " + string.Join(", ", updateFields) + " WHERE ID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(updateQuery, conn))
                    {
                        // Add the collected parameters
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue("?", param);
                        }

                        // Add RenterID parameter at the end
                        cmd.Parameters.AddWithValue("?", ownerID);

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
        }
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string prevPassword = tbxPrevPass.Text.Trim();
            string newPassword = tbxNewPass.Text.Trim();
            string confirmPassword = tbxConfirmedPass.Text.Trim();

            // 1. Check if any field is empty
            if (string.IsNullOrEmpty(prevPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Check if new password matches confirm password
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirmation do not match.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    // 3. Verify current password
                    string checkQuery = "SELECT Password FROM Owner WHERE ID = ?";
                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("?", ownerID);
                        object result = checkCmd.ExecuteScalar();

                        if (result == null || result.ToString() != prevPassword)
                        {
                            MessageBox.Show("Previous password is incorrect.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // 4. Update password
                    string updateQuery = "UPDATE Owner SET [Password] = ? WHERE ID = ?";
                    using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("?", newPassword);
                        updateCmd.Parameters.AddWithValue("?", ownerID);

                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbxPrevPass.Clear();
                            tbxNewPass.Clear();
                            tbxConfirmedPass.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Password update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tbxSearchDormerName_TextChanged(object sender, EventArgs e)
        {

        }
        private void iconbtnSearchDormerName_Click(object sender, EventArgs e)
        {
            string searchText = tbxSearchDormerName.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a name to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = @"
                        SELECT * FROM DormitoryRentersQuery
                        WHERE FirstName LIKE @search OR LastName LIKE @search OR (FirstName + ' ' + LastName) LIKE @search";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            DataTable searchResults = new DataTable();
                            adapter.Fill(searchResults);
                            dgvDormerTable.DataSource = searchResults;

                            if (searchResults.Rows.Count == 0)
                            {
                                MessageBox.Show("No results found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show($"{searchResults.Rows.Count} result(s) found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for renters: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void iconbtnDormerDelete_Click(object sender, EventArgs e)
        {
            if (dgvDormerTable.SelectedRows.Count > 0)
            {
                int renterID = Convert.ToInt32(dgvDormerTable.SelectedRows[0].Cells[0].Value);
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this renter?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    using (OleDbConnection conn = new OleDbConnection(connString))
                    {
                        conn.Open();

                        OleDbTransaction transaction = conn.BeginTransaction();

                        try
                        {
                            // Delete from Payment table
                            string deletePayments = "DELETE FROM Payment WHERE RenterID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(deletePayments, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("?", renterID);
                                cmd.ExecuteNonQuery();
                            }

                            //update Room Table
                            string updateRoom = "UPDATE Room SET RenterID = NULL, Status = 'Vacant' WHERE RenterID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(updateRoom, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("?", renterID);
                                cmd.ExecuteNonQuery();
                            }

                            // Delete from Renter table
                            string deleteRenter = "DELETE FROM Renter WHERE RenterID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(deleteRenter, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("?", renterID);
                                cmd.ExecuteNonQuery();
                            }
                            transaction.Commit();
                            MessageBox.Show("Renter deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error deleting renter: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a renter to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cmbChooseRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRoomNo = cmbChooseRoom.SelectedItem.ToString();
            LoadRenterByRoom(selectedRoomNo);
        }
        private void LoadRoomNumbers()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = @"
                SELECT Room.RoomNumber 
                FROM Room 
                INNER JOIN Property ON Room.PropertyID = Property.PropertyID 
                WHERE Property.OwnerID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", ownerID); // Ensure ownerID is defined and holds the logged-in owner's ID

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            cmbChooseRoom.Items.Clear(); // Optional: clear old items before loading new ones

                            while (reader.Read())
                            {
                                cmbChooseRoom.Items.Add(reader["RoomNumber"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading room numbers: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void LoadRenterByRoom(string roomNo)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = @"
                        SELECT Renter.RenterID, Renter.FirstName, Renter.LastName, Renter.PhoneNumber
                        FROM ((Owner 
                        INNER JOIN Property ON Owner.ID = Property.OwnerID) 
                        INNER JOIN Room ON Property.PropertyID = Room.PropertyID) 
                        INNER JOIN Renter ON Room.RenterID = Renter.RenterID
                        WHERE Owner.ID = ? AND Room.RoomNumber = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", ownerID);
                        cmd.Parameters.AddWithValue("?", roomNo);

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvRoomTable.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading renters by room: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void OwnerDashboard_Load(object sender, EventArgs e)
        {
            LoadPropertyName();
            LoadRoomNumbers();
        }
        private void dgvPaymentRenter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPaymentTable.Columns[e.ColumnIndex].Name == "ProofColumn")
            {
                DataGridViewRow selectedRow = dgvPaymentTable.Rows[e.RowIndex];

                // Show the selection dialog
                ViewAs viewAsForm = new ViewAs();
                viewAsForm.StartPosition = FormStartPosition.CenterParent;
                viewAsForm.ShowDialog();

                // No selection made, just exit
                if (viewAsForm.SelectedOption == ViewAs.ViewOption.None)
                    return;

                // Common data
                string propertyID = selectedRow.Cells["PropertyID"].Value?.ToString();
                string renterID = selectedRow.Cells["RenterID"].Value?.ToString();
                string firstName = selectedRow.Cells["FirstName"].Value?.ToString();
                string lastName = selectedRow.Cells["LastName"].Value?.ToString();
                int renterIDInt = Convert.ToInt32(renterID);

                if (viewAsForm.SelectedOption == ViewAs.ViewOption.Receipt)
                {
                    bool isPaid = false;
                    DateTime paymentDate = DateTime.Now;

                    using (OleDbConnection conn = new OleDbConnection(connString))
                    {
                        conn.Open();

                        // Check status first
                        string statusQuery = "SELECT Status FROM Payment WHERE RenterID = ?";
                        using (OleDbCommand statusCmd = new OleDbCommand(statusQuery, conn))
                        {
                            statusCmd.Parameters.AddWithValue("?", renterIDInt);
                            object statusResult = statusCmd.ExecuteScalar();
                            if (statusResult != null && statusResult.ToString().ToLower() == "paid")
                                isPaid = true;
                        }

                        if (isPaid)
                        {
                            // Fetch latest receipt date
                            string receiptQuery = "SELECT TOP 1 PaymentDate FROM Receipt WHERE RenterID = ? ORDER BY ReceiptID DESC";
                            using (OleDbCommand cmd = new OleDbCommand(receiptQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("?", renterIDInt);
                                object result = cmd.ExecuteScalar();
                                if (result != null && result != DBNull.Value)
                                    paymentDate = Convert.ToDateTime(result);
                            }

                            Receipt receiptForm = new Receipt(propertyID, renterID, firstName, lastName, paymentDate);
                            receiptForm.StartPosition = FormStartPosition.CenterParent;
                            receiptForm.ShowDialog();
                        }
                        else
                        {
                            // Not paid: show receipt with no content
                            Receipt emptyReceipt = new Receipt();
                            emptyReceipt.StartPosition = FormStartPosition.CenterParent;
                            emptyReceipt.ShowDialog();
                        }
                    }
                }
                else if (viewAsForm.SelectedOption == ViewAs.ViewOption.ProofPicture)
                {
                    this.Opacity = 0.5;
                    ProofPicture proofPicture = new ProofPicture(renterIDInt);
                    proofPicture.StartPosition = FormStartPosition.CenterParent;
                    proofPicture.ShowDialog();
                    this.Opacity = 1;
                }
            }
        }
        private int GetRenterIDByPropertyID(int propertyID)
        {
            int renterID = -1; // Default to -1 if no result is found

            string query = "SELECT RenterID FROM DormitoryRentersQuery WHERE OwnerID = ?"; // Adjust the table name and column as needed

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", ownerID);

                    object result = cmd.ExecuteScalar(); // Executes the query and returns the first column of the first row
                    if (result != null)
                    {
                        renterID = Convert.ToInt32(result);  // Convert result to RenterID
                    }
                }
            }

            return renterID;  // Return the RenterID, or -1 if not found
        }
        private int GetRenterID()
        {
            int renterID = -1; // Default to -1 if no result is found

            string query = "SELECT RenterID FROM DormitoryRentersQuery WHERE OwnerID = ?"; // Adjust the table name and column as needed

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", ownerID);

                    object result = cmd.ExecuteScalar(); // Executes the query and returns the first column of the first row
                    if (result != null)
                    {
                        renterID = Convert.ToInt32(result);  // Convert result to RenterID
                    }
                }
            }
            return renterID;  // Return the RenterID, or -1 if not found
        }
        private void btnDormConfirmPayment_Click(object sender, EventArgs e)
        {
            try
            {
                // Assume we have the RenterID available for this payment
                int renterID = GetRenterID();  // You can replace this with your logic for fetching RenterID (either passed as a parameter or fetched from the form)
                string newStatus = "Paid"; // Set the new status
                decimal newRemainingBalance = 0;
                DateTime paymentDate = DateTime.Now; // Set the payment date to now

                string query = "UPDATE Payment SET Status = ?, [Remaining Balance] = ?, DueDate = ? WHERE RenterID = ?";
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", newStatus);
                        cmd.Parameters.AddWithValue("?", newRemainingBalance);
                        cmd.Parameters.AddWithValue("?", DBNull.Value);
                        cmd.Parameters.AddWithValue("?", renterID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // 2. Retrieve PropertyID, FirstName, and LastName for this Renter
                            string selectQuery = "SELECT PropertyID, FirstName, LastName FROM DormitoryPaymentTable WHERE RenterID = ?";
                            using (OleDbCommand selectCmd = new OleDbCommand(selectQuery, conn))
                            {
                                selectCmd.Parameters.AddWithValue("?", renterID);
                                using (OleDbDataReader reader = selectCmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        int propertyID = Convert.ToInt32(reader["PropertyID"]);
                                        string firstName = reader["FirstName"].ToString();
                                        string lastName = reader["LastName"].ToString();

                                        // 3. Insert into Receipt table
                                        string insertReceiptQuery = "INSERT INTO Receipt ([PropertyID], [RenterID], [FirstName], [LastName], [PaymentDate]) VALUES (?, ?, ?, ?, ?)";
                                        using (OleDbCommand insertCmd = new OleDbCommand(insertReceiptQuery, conn))
                                        {
                                            insertCmd.Parameters.Add("PropertyID", OleDbType.Integer).Value = propertyID;
                                            insertCmd.Parameters.AddWithValue("?", renterID);
                                            insertCmd.Parameters.Add("FirstName", OleDbType.VarChar).Value = firstName;
                                            insertCmd.Parameters.Add("LastName", OleDbType.VarChar).Value = lastName;
                                            insertCmd.Parameters.Add("PaymentDate", OleDbType.Date).Value = paymentDate;


                                            insertCmd.ExecuteNonQuery();
                                        }

                                        // 4. Show Receipt form
                                        Receipt receiptForm = new Receipt(propertyID.ToString(), renterID.ToString(), firstName, lastName, paymentDate);
                                        receiptForm.StartPosition = FormStartPosition.CenterParent;
                                        receiptForm.ShowDialog();
                                    }
                                }
                            }

                            MessageBox.Show("Payment status updated to 'Paid' and receipt saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //MessageBox.Show("Payment status updated to 'Paid' and Remaining Balance set to 0 successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No payment found for this renter.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                MessageBox.Show("Payment status updated to 'Paid' successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating payment status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void iconBtnRemainingBalance_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPaymentTable.EndEdit(); // Ensure all edits are committed before updating
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    foreach (DataGridViewRow row in dgvPaymentTable.Rows)
                    {
                        // Skip new row placeholder
                        if (row.IsNewRow) continue;

                        // Retrieve updated values
                        int renterID = Convert.ToInt32(row.Cells["RenterID"].Value);
                        decimal remainingBalance = Convert.ToDecimal(row.Cells["Remaining Balance"].Value);
                        DateTime dueDate;
                        var dueDateCellValue = row.Cells["DueDate"].Value;

                        if (dueDateCellValue == DBNull.Value || string.IsNullOrWhiteSpace(dueDateCellValue?.ToString()))
                        {
                            dueDate = DateTime.Now.AddMonths(1); // Auto-set DueDate to one month from now
                        }
                        else
                        {
                            dueDate = Convert.ToDateTime(dueDateCellValue); // Use manually entered DueDate
                        }
                        string backtoStatus = "Pending";
                        if (dueDate < DateTime.Now.Date && remainingBalance > 0)
                        {
                            backtoStatus = "Late";
                        }


                        string query = "UPDATE Payment SET [Remaining Balance] = ?, DueDate = ?, Status = ? WHERE RenterID = ?";

                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("?", remainingBalance);
                            cmd.Parameters.Add("?", OleDbType.Date).Value = dueDate;
                            //cmd.Parameters.AddWithValue("?", dueDate);
                            cmd.Parameters.AddWithValue("?", backtoStatus);
                            cmd.Parameters.AddWithValue("?", renterID);

                            cmd.ExecuteNonQuery(); // We don't need to check rowsAffected here, we assume each row is valid
                        }
                    }

                    MessageBox.Show("Updated all edited Remaining Balances and Due Dates.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating payment data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void iconbtnLoadPayment_Click(object sender, EventArgs e)
        {
            CustomizeDataGridViewPayment();
            LoadPaymentData();
        }

        private void iconEvents_Click(object sender, EventArgs e)
        {
            pnlEvents.BringToFront();
            LoadEvents();
        }
        private void iconBtAddEvent_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Enter event name:", "Add Event", "");
            string dateStr = Microsoft.VisualBasic.Interaction.InputBox("Enter event date:", "Add Event", "");
            //string dateStr = Microsoft.VisualBasic.Interaction.InputBox("Enter event date (yyyy-MM-dd):", "Add Event", "");
            string location = Microsoft.VisualBasic.Interaction.InputBox("Enter event location:", "Add Event", "");


            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                string query = "INSERT INTO EventPostings (OwnerID, EventName, EventWhen, EventWhere) VALUES (?, ?, ?, ?)";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", ownerID); // Use the ownerID from the constructor
                cmd.Parameters.AddWithValue("?", name);
                cmd.Parameters.AddWithValue("?", dateStr);
                cmd.Parameters.AddWithValue("?", location);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Event added successfully!");
            LoadEvents(); // Refresh
        }
        private void iconBtnDeleteEvent_Click(object sender, EventArgs e)
        {
            if (selectEventCard != null)
            {
                string name = selectEventCard.EventName;
                string when = selectEventCard.EventWhen;

                var confirm = MessageBox.Show($"Are you sure you want to delete event '{name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    using (OleDbConnection conn = new OleDbConnection(connString))
                    {
                        conn.Open();
                        string query = "DELETE FROM EventPostings WHERE OwnerID = ? AND EventName = ? AND EventWhen = ?";
                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("?", ownerID);
                            cmd.Parameters.AddWithValue("?", name);
                            cmd.Parameters.AddWithValue("?", when);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    flowPnlEvent.Controls.Remove(selectEventCard);
                    selectEventCard = null;
                    MessageBox.Show("Event deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select an event to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void iconBtnLoadEvent_Click(object sender, EventArgs e)
        {
            LoadEvents();
        }
        private void LoadEvents()
        {
            flowPnlEvent.Controls.Clear(); // Optional: clear old ones

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                string query = "SELECT EventName, EventWhen, EventWhere FROM EventPostings WHERE OwnerID = ?"; // Adjust table/column names
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", ownerID); // Use the ownerID from the constructor
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader["EventName"].ToString();
                    string dateStr = reader["EventWhen"].ToString();
                    string location = reader["EventWhere"].ToString();

                    EventCard card = new EventCard();
                    card.EventName = name;
                    card.EventWhen = dateStr;
                    card.EventWhere = location;

                    card.Tag = new { name, dateStr, location }; // Store data in the card's Tag property

                    // Optionally handle click:
                    card.Click += (s, e) =>
                    {
                        selectEventCard = card;
                        HighlightCard(card);
                        //MessageBox.Show($"Event: {name}\nWhen: {dateStr}\nWhere: {location}", "Event Details");
                    };

                    // Make the inner labels clickable too
                    foreach (Control control in card.Controls)
                    {
                        control.Click += (s, e) =>
                        {
                            selectEventCard = card;
                            HighlightCard(card);
                            //MessageBox.Show($"Event: {name}\nWhen: {dateStr}\nWhere: {location}", "Event Details");
                        };
                    }

                    flowPnlEvent.Controls.Add(card);
                }

                conn.Close();
            }
        }
        private void HighlightCard(EventCard selected)
        {
            foreach (EventCard card in flowPnlEvent.Controls)
            {
                card.BackColor = Color.FromArgb(0, 148, 115); // default color
            }
            selected.BackColor = Color.FromArgb(0, 148, 115); // highlight
        }
        private void iconBtnOccupancyRate_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;

            OccupancyRate occupancyRate = new OccupancyRate(ownerID);
            occupancyRate.StartPosition = FormStartPosition.CenterParent;
            occupancyRate.ShowDialog();

            this.Opacity = 1;
        }
        private void iconbtnLoad_Click(object sender, EventArgs e)
        {
            LoadRentersData();
        }

        private void iconBtnLoadRooms_Click(object sender, EventArgs e)
        {
            LoadRoomsData();
        }

        private void iconBtnEditEvent_Click(object sender, EventArgs e)
        {
            if (selectEventCard != null)
            {
                string oldName = selectEventCard.EventName;
                string oldWhen = selectEventCard.EventWhen;
                string oldWhere = selectEventCard.EventWhere;

                string newName = Microsoft.VisualBasic.Interaction.InputBox("Enter event name:", "Edit Event", oldName);
                string newWhen = Microsoft.VisualBasic.Interaction.InputBox("Enter event date:", "Edit Event", oldWhen);
                string newWhere = Microsoft.VisualBasic.Interaction.InputBox("Enter event location:", "Edit Event", oldWhere);

                if (!string.IsNullOrWhiteSpace(newName) && !string.IsNullOrWhiteSpace(newWhen) && !string.IsNullOrWhiteSpace(newWhere))
                {
                    using (OleDbConnection conn = new OleDbConnection(connString))
                    {
                        conn.Open();
                        string query = @"
                    UPDATE EventPostings 
                    SET EventName = ?, EventWhen = ?, EventWhere = ? 
                    WHERE OwnerID = ? AND EventName = ? AND EventWhen = ?";
                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("?", newName);
                            cmd.Parameters.AddWithValue("?", newWhen);
                            cmd.Parameters.AddWithValue("?", newWhere);
                            cmd.Parameters.AddWithValue("?", ownerID);
                            cmd.Parameters.AddWithValue("?", oldName);
                            cmd.Parameters.AddWithValue("?", oldWhen);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Update UI
                    selectEventCard.EventName = newName;
                    selectEventCard.EventWhen = newWhen;
                    selectEventCard.EventWhere = newWhere;

                    MessageBox.Show("Event updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select an event to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadPropertyName()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT DormitoryName FROM Dormitory WHERE OwnerID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", ownerID); // ownerID should be set during login

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tbxDormName.Text = reader["DormitoryName"].ToString();
                            }
                            else
                            {
                                tbxDormName.Text = "No property found";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading property name: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconbtnPaymentDormerSearch_Click(object sender, EventArgs e)
        {
            string searchText = tbxSearchPayment.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter a renter's name to search.", "Search Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = @"
        SELECT RenterID, OwnerID, PropertyID, FirstName, LastName, 
               [Remaining Balance], DueDate, PaymentDate, Status 
        FROM DormitoryPaymentTable 
        WHERE OwnerID = ? AND 
              (FirstName LIKE ? OR LastName LIKE ? OR 
               (FirstName + ' ' + LastName) LIKE ?)";

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", ownerID);
                        cmd.Parameters.AddWithValue("?", "%" + searchText + "%");
                        cmd.Parameters.AddWithValue("?", "%" + searchText + "%");
                        cmd.Parameters.AddWithValue("?", "%" + searchText + "%");

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvPaymentTable.DataSource = dt;

                        dgvPaymentTable.Columns["RenterID"].Visible = false;
                        dgvPaymentTable.Columns["OwnerID"].Visible = false;
                        dgvPaymentTable.Columns["PropertyID"].Visible = false;
                        dgvPaymentTable.Columns["PaymentDate"].Visible = false;

                        // Re-add the button column if not present
                        if (!dgvPaymentTable.Columns.Contains("ProofColumn"))
                        {
                            DataGridViewButtonColumn proofBtnColumn = new DataGridViewButtonColumn();
                            proofBtnColumn.Name = "ProofColumn";
                            proofBtnColumn.HeaderText = "Proof";
                            proofBtnColumn.Text = "View";
                            proofBtnColumn.UseColumnTextForButtonValue = true;
                            dgvPaymentTable.Columns.Add(proofBtnColumn);
                        }

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No renters found with that name.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching for renter: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

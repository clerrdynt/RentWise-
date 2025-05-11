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
    public partial class CondoUpdatePaymentForm : Form
    {
        public byte[] proofpayment;
        private int renterID;
        //public byte[] Picture { get; set; }
        public CondoUpdatePaymentForm(int renterID)
        {
            InitializeComponent();
            this.renterID = renterID;
        }

        private void btnUpdateProofPayment_Click(object sender, EventArgs e)
        {
            if (proofpayment == null)
            {
                MessageBox.Show("Please upload a proof of payment.");
                return;
            }

            int propertyID = -1;
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\RentWise!\RentWise.accdb;";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Step 1: Get PropertyID based on RenterID
                    using (OleDbCommand getPropCmd = new OleDbCommand("SELECT PropertyID FROM CondoRoom WHERE RenterID = ?", conn))
                    {
                        getPropCmd.Parameters.AddWithValue("?", renterID);
                        object result = getPropCmd.ExecuteScalar();
                        if (result != null)
                        {
                            propertyID = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Could not find associated PropertyID.");
                            return;
                        }
                    }

                    // Step 2: Insert into PaymentProof table without PaymentID
                    string updateQuery = "UPDATE ProofPayment SET ProofPic = ? WHERE RenterID = ?";
                    using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.Add("?", OleDbType.Binary, proofpayment.Length).Value = proofpayment;
                        updateCmd.Parameters.AddWithValue("?", renterID);

                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Proof of payment updated successfully!");
                        }
                        else
                        {
                            // No existing record to update, insert new one
                            string insertQuery = "INSERT INTO ProofPayment (PropertyID, RenterID, ProofPic) VALUES (?, ?, ?)";
                            using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("?", propertyID);
                                insertCmd.Parameters.AddWithValue("?", renterID);
                                insertCmd.Parameters.Add("?", OleDbType.Binary, proofpayment.Length).Value = proofpayment;

                                int insertRows = insertCmd.ExecuteNonQuery();
                                if (insertRows > 0)
                                {
                                    MessageBox.Show("Proof of payment uploaded successfully!");
                                }
                                else
                                {
                                    MessageBox.Show("Upload failed. No rows affected.");
                                }
                            }
                        }
                    }
                    // Optional: Navigate to renter dashboard
                    CondominiumRenterDashboard condominiumrenterDashboard = new CondominiumRenterDashboard();
                    condominiumrenterDashboard.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting payment proof: " + ex.Message);
                }
            }
            //RenterDashboard renterDashboard = new RenterDashboard();
            //renterDashboard.Show();

            this.Close();
        }

        private void UpdatePaymentForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDormitoryPaymentDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment details: " + ex.Message);
            }
        }
        //Cash is working
        private void LoadDormitoryPaymentDetails()
        {
            int propertyID = -1;
            string paymentMethod = "";

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\RentWise!\RentWise.accdb;";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();

                // Step 1: Get PropertyID from Room table using RenterID
                using (OleDbCommand cmd = new OleDbCommand("SELECT PropertyID FROM CondoRoom WHERE RenterID = ?", conn))
                {
                    cmd.Parameters.AddWithValue("?", renterID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        propertyID = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("No room found for this renter.");
                        return;
                    }
                }

                // Step 2: Check if it's a Dormitory and get PaymentMethod
                using (OleDbCommand cmd = new OleDbCommand("SELECT PaymentMethod FROM Condominium WHERE PropertyID = ?", conn))
                {
                    cmd.Parameters.AddWithValue("?", propertyID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        paymentMethod = result.ToString();
                        lblPayMethod.Text = paymentMethod;
                    }
                    else
                    {
                        MessageBox.Show("This form is only for Condominium renters.");
                        return;
                    }
                }

                // Step 3: Fetch info depending on the payment method
                if (paymentMethod == "E-Wallet" || paymentMethod == "Bank Transfer")
                {
                    try
                    {
                        using (OleDbCommand cmd = new OleDbCommand("SELECT AccountName, AccountNumber, Picture FROM PaymentMethod WHERE PropertyID = ?", conn))
                        {
                            cmd.Parameters.AddWithValue("?", propertyID);
                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    lblAccountName.Text = reader["AccountName"].ToString();
                                    lblAccountNumber.Text = reader["AccountNumber"].ToString();

                                    if (!reader.IsDBNull(reader.GetOrdinal("Picture")))
                                    {
                                        byte[] imageData = (byte[])reader["Picture"];
                                        using (MemoryStream ms = new MemoryStream(imageData))
                                        {
                                            pbxPayMethodPic.Image = Image.FromStream(ms);
                                            pbxPayMethodPic.BringToFront();
                                            pbxPayMethodPic.SizeMode = PictureBoxSizeMode.StretchImage;
                                        }
                                    }
                                    else
                                    {
                                        //MessageBox.Show("No image found for this payment method.");
                                        iconpbxPayMethodPic.BringToFront();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No payment method found for this property.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading payment details: " + ex.Message);
                    }

                }
                else if (paymentMethod == "Cash")
                {
                    try
                    {
                        //MessageBox.Show("PropertyID: " + propertyID.ToString());
                        using (OleDbCommand cmd = new OleDbCommand(@"
                            SELECT FirstName, LastName, PhoneNumber 
                            FROM PaymentMethodCash 
                            WHERE PropertyID = ?", conn))
                        {
                            cmd.Parameters.Add("?", OleDbType.Integer).Value = propertyID;

                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string fullName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                                    lblAccountName.Text = fullName;
                                    lblAccountNumber.Text = reader["PhoneNumber"].ToString();
                                    iconpbxCash.BringToFront();
                                }
                                else
                                {
                                    MessageBox.Show("No cash payment info found for this PropertyID.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading payment details in Cash Gikapoy nakooo huhu: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Unsupported payment method.");
                }
            }
        }
        private void iconbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconbtnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUploadProof_Click(object sender, EventArgs e)
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
                    pbxProofPayment.Image = selectedImage; // Display the image in PictureBox

                    // Convert selected image to byte[] for saving to database
                    using (MemoryStream ms = new MemoryStream())
                    {
                        selectedImage.Save(ms, selectedImage.RawFormat); // Save image to memory stream
                        proofpayment = ms.ToArray(); // Store byte[] representation of the image
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

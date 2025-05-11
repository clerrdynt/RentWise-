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
    public partial class LogIn : Form
    {
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\RentWise!\RentWise.accdb;";
        public LogIn()
        {
            InitializeComponent();
            tbxPassword.PasswordChar = '*'; // Hide password by default
            tbxPassword.UseSystemPasswordChar = false;
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

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text.Trim();
            string password = tbxPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    string ownerQuery = "SELECT TOP 1 Owner.ID, Property.PropertyType " +
                    "FROM Owner " +
                    "INNER JOIN Property ON Owner.ID = Property.OwnerID " +
                    "WHERE Owner.Username = @Username AND Owner.Password = @Password";

                    using (OleDbCommand ownerCmd = new OleDbCommand(ownerQuery, conn))
                    {
                        ownerCmd.Parameters.AddWithValue("@Username", username);
                        ownerCmd.Parameters.AddWithValue("@Password", password);

                        using (OleDbDataReader reader = ownerCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int ownerID = reader.GetInt32(0);
                                string propertyType = reader.GetString(1);

                                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (propertyType == "Dormitory")
                                {
                                    //MessageBox.Show("Welcome to the Dormitory Owner Dashboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // Show dormitory-specific owner form
                                    OwnerDashboard ownerdashboard = new OwnerDashboard(ownerID);
                                    ownerdashboard.Show();
                                }
                                else
                                {
                                    //MessageBox.Show("Welcome to the Condominium Owner Dashboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // Show regular owner dashboard
                                    CondoOwnerDashboard dormDashboard = new CondoOwnerDashboard(ownerID);
                                    dormDashboard.Show();
                                }

                                this.Hide();
                                return;
                            }
                        }
                    }
                    /*string renterQuery = "SELECT TOP 1 Renter.RenterID, Property.PropertyType " +
                         "FROM Renter " +
                         "INNER JOIN Property ON Renter.RenterID = Property.renterID " +
                         "WHERE Renter.UserName = @UserName AND Renter.Password = @Password";
                    using (OleDbCommand renterCmd = new OleDbCommand(renterQuery, conn))
                    {
                        renterCmd.Parameters.AddWithValue("@Username", username);
                        renterCmd.Parameters.AddWithValue("@Password", password);

                        using (OleDbDataReader reader = renterCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int renterID = reader.GetInt32(0);
                                string propertyType = reader.GetString(1);

                                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (propertyType == "Dormitory")
                                {
                                    RenterDashboard renterDashboard = new RenterDashboard(renterID);
                                    renterDashboard.Show();
                                }
                                else
                                {
                                    CondominiumRenterDashboard condoDashboard = new CondominiumRenterDashboard(renterID);
                                    condoDashboard.Show();
                                }

                                this.Hide();
                                return;
                            }
                        }
                    }*/
                    
                    /*string renterQuery = "SELECT RenterID FROM Renter WHERE UserName = @Username AND Password = @Password";
                    using (OleDbCommand renterCmd = new OleDbCommand(renterQuery, conn))
                    {
                        renterCmd.Parameters.AddWithValue("@UserName", username);
                        renterCmd.Parameters.AddWithValue("@Password", password);

                        object renterResult = renterCmd.ExecuteScalar();

                        if (renterResult != null)
                        {
                            int renterID = Convert.ToInt32(renterResult);
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RenterDashboard renterdashboard = new RenterDashboard(renterID);
                            renterdashboard.Show();
                            this.Hide();
                            return;
                        }
                    }*/

                    // Step 1: Authenticate and get RenterID
                    string renterQuery = "SELECT RenterID FROM Renter WHERE UserName = @Username AND Password = @Password";
                    using (OleDbCommand renterCmd = new OleDbCommand(renterQuery, conn))
                    {
                        renterCmd.Parameters.AddWithValue("@UserName", username);
                        renterCmd.Parameters.AddWithValue("@Password", password);

                        object renterResult = renterCmd.ExecuteScalar();

                        if (renterResult != null)
                        {
                            int renterID = Convert.ToInt32(renterResult);

                            string propertyType = "";

                            // Check Dormitory first
                            string dormQuery = @"
                                SELECT Property.PropertyType
                                FROM Room
                                INNER JOIN Property ON Room.PropertyID = Property.PropertyID
                                WHERE Room.RenterID = @RenterID";

                            using (OleDbCommand dormCmd = new OleDbCommand(dormQuery, conn))
                            {
                                dormCmd.Parameters.AddWithValue("@RenterID", renterID);
                                object dormResult = dormCmd.ExecuteScalar();
                                if (dormResult != null)
                                {
                                    propertyType = dormResult.ToString();
                                }
                                RenterDashboard renterDashboard = new RenterDashboard(renterID);
                                renterDashboard.Show(); 
                                
                                this.Hide();
                            }

                            // If not Dormitory, check Condominium
                            if (string.IsNullOrEmpty(propertyType))
                            {
                                string condoQuery = @"
                                    SELECT Property.PropertyType
                                    FROM CondoRoom
                                    INNER JOIN Property ON CondoRoom.PropertyID = Property.PropertyID
                                    WHERE CondoRoom.RenterID = @RenterID";

                                using (OleDbCommand condoCmd = new OleDbCommand(condoQuery, conn))
                                {
                                    condoCmd.Parameters.AddWithValue("@RenterID", renterID);
                                    object condoResult = condoCmd.ExecuteScalar();
                                    if (condoResult != null)
                                    {
                                        propertyType = condoResult.ToString();
                                    }
                                }
                                CondominiumRenterDashboard condoDashboard = new CondominiumRenterDashboard(renterID);
                                condoDashboard.Show();
                                
                                this.Hide();
                            }
                            this.Hide();
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            /*if (propertyType == "Dormitory")
                            {
                                RenterDashboard renterDashboard = new RenterDashboard(renterID);
                                renterDashboard.Show();
                            }
                            else if (propertyType == "Condominium")
                            {
                                CondominiumRenterDashboard condoDashboard = new CondominiumRenterDashboard(renterID);
                                condoDashboard.Show();
                            }
                            else
                            {
                                // fallback if no property type is linked yet
                                RenterDashboard fallbackDashboard = new RenterDashboard(renterID);
                                fallbackDashboard.Show();
                            }*/

                            this.Hide();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during login: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconBtnUnseePassword_Click(object sender, EventArgs e)
        {
            if (tbxPassword.PasswordChar == '*')
            {
                tbxPassword.PasswordChar = '\0'; // Show password
                iconBtnUnseePassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                tbxPassword.PasswordChar = '*'; // Hide password
                iconBtnUnseePassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            tbxPassword.PasswordChar = '*'; // Ensure password is hidden on form load
            tbxPassword.UseSystemPasswordChar = false;
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            IntroForm introForm = new IntroForm();
            introForm.Show();
            this.Close();
        }
    }
}

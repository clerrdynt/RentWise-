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
using System.DirectoryServices.ActiveDirectory;

namespace RentWise_
{
    public partial class Register : Form
    {
        private byte[] profilepicture;
        public Register()
        {
            InitializeComponent();
            tbxRegisterPassword.PasswordChar = '*'; // Hide password by default
            tbxRegisterPassword.UseSystemPasswordChar = false;
        }

        private void iconbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconbtnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private OwnerRegistration owner;

        private void btnRegisterDormitory_Click(object sender, EventArgs e)
        {
            if (ValidateOwnerDetails())
            {
                if (profilepicture != null && profilepicture.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(profilepicture))
                    {
                        Bitmap selectedImage = new Bitmap(ms);
                        pbxOwnerPP.Image = selectedImage;
                    }
                }
                OwnerRegistration ownerDetails = new OwnerRegistration
                {
                    FirstName = tbxRegisterFirstName.Text,
                    LastName = tbxRegisterLastName.Text,
                    Username = tbxRegisterUsername.Text,
                    Password = tbxRegisterPassword.Text,
                    PhoneNumber = tbxRegisterPhoneNo.Text,
                    Email = tbxRegisterEmail.Text,
                    PropertyType = "Dormitory",
                    ProfilePicture = profilepicture
                };

                if (ownerDetails.Register()) // Register dormitory
                {
                    MessageBox.Show("Dormitory Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RegisterRenter registerRenter = new RegisterRenter();
                    registerRenter.Show();

                    this.Close();
                    IntroForm newintroForm = new IntroForm();
                    newintroForm.Show();
                }
                else
                {
                    MessageBox.Show("Register Dormitory: Failed to register dormitory. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                RegisterDormitory registerDormitory = new RegisterDormitory(ownerDetails);
                registerDormitory.Show();
                this.Close();
            }
        }
        private void btnRegisterCondo_Click(object sender, EventArgs e)
        {
            if (ValidateOwnerDetails())
            {
                if (profilepicture != null && profilepicture.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(profilepicture))
                    {
                        Bitmap selectedImage = new Bitmap(ms);
                        pbxOwnerPP.Image = selectedImage;
                    }
                }
                OwnerRegistration ownerDetails = new OwnerRegistration
                {
                    FirstName = tbxRegisterFirstName.Text,
                    LastName = tbxRegisterLastName.Text,
                    Username = tbxRegisterUsername.Text,
                    Password = tbxRegisterPassword.Text,
                    PhoneNumber = tbxRegisterPhoneNo.Text,
                    Email = tbxRegisterEmail.Text,
                    PropertyType = "Condominium",
                    ProfilePicture = profilepicture
                };
                if (ownerDetails.Register()) // Register dormitory
                {
                    MessageBox.Show("Condominium Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RegisterRenter registerRenter = new RegisterRenter();
                    registerRenter.Show();

                    this.Close();
                    IntroForm newintroForm = new IntroForm();
                    newintroForm.Show();
                }
                else
                {
                    MessageBox.Show("Register Condominium: Failed to register dormitory. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                RegisterCondominium registerCondo = new RegisterCondominium(ownerDetails);
                registerCondo.Show();
                this.Close();
            }
        }
        private bool ValidateOwnerDetails()
        {
            if (string.IsNullOrWhiteSpace(tbxRegisterFirstName.Text) ||
                string.IsNullOrWhiteSpace(tbxRegisterLastName.Text) ||
                string.IsNullOrWhiteSpace(tbxRegisterUsername.Text) ||
                string.IsNullOrWhiteSpace(tbxRegisterPassword.Text) ||
                string.IsNullOrWhiteSpace(tbxRegisterPhoneNo.Text) ||
                string.IsNullOrWhiteSpace(tbxRegisterEmail.Text))
            {
                MessageBox.Show("Please fill in all owner details before proceeding.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnUploadPP_Click(object sender, EventArgs e)
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
                    pbxOwnerPP.Image = selectedImage; // Display the image in PictureBox

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

        private void iconBtnUnseePassword_Click(object sender, EventArgs e)
        {
            if (tbxRegisterPassword.PasswordChar == '*')
            {
                tbxRegisterPassword.PasswordChar = '\0'; // Show password
                iconBtnUnseePassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                tbxRegisterPassword.PasswordChar = '*'; // Hide password
                iconBtnUnseePassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            tbxRegisterPassword.PasswordChar = '*'; // Ensure password is hidden on form load
            tbxRegisterPassword.UseSystemPasswordChar = false;
        }
    }
}

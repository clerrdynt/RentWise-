using RentWise_.Classes;
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

    public partial class EWallet : Form
    {
        private byte[] image;
        private Dormitory dorm;
        private int dormID;
        public int selectedPaymentMethod { get; private set; } // 0 = E-Wallet, 1 = Cash, 2 = Bank Transfer


        public EWallet(int dormID)
        {
            InitializeComponent();
            this.dormID = dormID;

            dorm = new Dormitory();
        }
        Dormitory dormitory = new Dormitory();

        private void iconbtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
        private void iconbtnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate the E-wallet details first
                if (ValidateEWalletDetails())
                {
                    // Check if the image file exists
                    if (image != null && image.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(image))
                        {
                            Bitmap selectedImage = new Bitmap(ms);
                            pbxEWalletQR.Image = selectedImage;
                        }
                    }
                    // Register the payment method by creating a new Dormitory object
                    Dormitory paymentMethodDormitory = new Dormitory()
                    {
                        PropertyID = dormID,
                        AccountName = tbxOwnerName.Text,
                        AccountNumber = tbxOwnerNumber.Text,
                        PaymentMethod = "E-Wallet",
                        Picture = image
                    };

                    if (paymentMethodDormitory.RegisterPaymentMethod())
                    {
                        MessageBox.Show("Payment Method Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.selectedPaymentMethod = 0;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to register payment method. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // If E-wallet details are not valid
                    MessageBox.Show("Please complete all property details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateEWalletDetails()
        {
            if (string.IsNullOrWhiteSpace(tbxOwnerName.Text) || string.IsNullOrWhiteSpace(tbxOwnerNumber.Text))
            {
                MessageBox.Show("Please complete all property details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Convert selected image file to byte[]
                    Bitmap selectedImage = new Bitmap(openFileDialog.FileName);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        selectedImage.Save(ms, selectedImage.RawFormat);
                        image = ms.ToArray();
                    }

                    // Display image in PictureBox
                    pbxEWalletQR.Image = selectedImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

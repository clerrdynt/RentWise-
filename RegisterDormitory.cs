using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentWise_.Classes;

namespace RentWise_
{
    public partial class RegisterDormitory : Form
    {
        private OwnerRegistration? owner;
        private int ownerID;
        private int selectedPaymentMethod = 0;

        public RegisterDormitory(OwnerRegistration ownerDetails)
        {
            InitializeComponent();
            owner = ownerDetails;
        }
        public RegisterDormitory()
        {
            InitializeComponent();

            //rBtnEWallet.Checked = true;
        }

        private void iconbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconbtnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDormInfoCancel_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }

        private void btnDormInfoRegister_Click(object sender, EventArgs e)
        {
            if (ValidatePropertyDetails()) // Check if all property details are filled
            {
                // Insert both Owner and Property details
                ownerID = owner.ownerId;

                string paymentMethod;

                if (rBtnCash.Checked)
                    paymentMethod = "Cash";
                else if (rBtnEWallet.Checked)
                    paymentMethod = "E-Wallet";
                else if (rBtnBankTransfer.Checked)
                    paymentMethod = "Bank Transfer";
                else
                {
                    MessageBox.Show("Please select a payment method.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Dormitory dormitory = new Dormitory()
                {
                    OwnerID = ownerID,
                    DormitoryName = tbxDormName.Text.Trim(),
                    Address = tbxDormAddress.Text.Trim(),
                    ContactNo = tbxDormContact.Text,
                    TotalFloors = Convert.ToInt32(nUPTotFloors.Text),
                    RoomsPerFloor = Convert.ToInt32(nUPRoomPerFloor.Text),
                    RoomTypes = cmbDormType.Text,
                    PricePerMonth = Convert.ToDecimal(tbxDormPrice.Text),
                    PaymentFrequency = Convert.ToInt32(tbxDormPayFreq.Text),
                    PaymentMethod = paymentMethod
                };

                if (dormitory.Register()) // Register dormitory
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
            }
            IntroForm introForm = new IntroForm();
            introForm.Show();
            this.Close();
        }
        private bool ValidatePropertyDetails()
        {
            // Ensure property-specific fields are filled (e.g., Address, Number of Rooms, etc.)
            if (string.IsNullOrWhiteSpace(tbxDormName.Text) ||
                string.IsNullOrWhiteSpace(tbxDormAddress.Text) ||
                string.IsNullOrWhiteSpace(tbxDormContact.Text) ||
                string.IsNullOrWhiteSpace(nUPTotFloors.Text) ||
                string.IsNullOrWhiteSpace(nUPRoomPerFloor.Text) ||
                string.IsNullOrWhiteSpace(cmbDormType.Text) ||
                string.IsNullOrWhiteSpace(tbxDormPrice.Text) ||
                string.IsNullOrWhiteSpace(tbxDormPayFreq.Text))
            {
                MessageBox.Show("Please complete all property details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void rBtnEWallet_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnEWallet.Checked)
            {
                EWallet eWallet = new EWallet(ownerID);
                if (eWallet.ShowDialog() == DialogResult.OK)
                {
                    selectedPaymentMethod = eWallet.selectedPaymentMethod;
                    rBtnEWallet.Checked = true;
                }
            }
        }
        private void rBtnCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnCash.Checked)
            {
                rBtnCash.Checked = true;
            }
        }
        private void rBtnBankTransfer_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnBankTransfer.Checked)
            {
                BankTransfer banktransfer = new BankTransfer(ownerID);
                if (banktransfer.ShowDialog() == DialogResult.OK)
                {
                    selectedPaymentMethod = banktransfer.selectedPaymentMethod;
                    rBtnBankTransfer.Checked = true;
                }
            }
        }
    }
}

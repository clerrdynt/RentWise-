using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentWise_.Classes;

namespace RentWise_
{
    public partial class RegisterCondominium : Form
    {
        private OwnerRegistration? owner;
        private int ownerID;
        private int selectedPaymentMethod = 0;
        public RegisterCondominium(OwnerRegistration ownerDetails)
        {
            InitializeComponent();
            owner = ownerDetails;
        }

        private void iconbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconbtnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCondoInfoCancel_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void btnCondoInfoRegister_Click(object sender, EventArgs e)
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
                Condominium condominium = new Condominium
                {
                    OwnerID = ownerID,
                    CondoName = tbxCondoName.Text,
                    Address = tbxCondoAddress.Text,
                    ContactNo = tbxCondoContact.Text,
                    TotalFloors = Convert.ToInt32(nUPCondoTotFloors.Text),
                    UnitPerFloor = Convert.ToInt32(nUPCondoRoomPerFloor.Text),
                    RoomTypes = cmbCondoType.Text,
                    PricePerMonth = Convert.ToDecimal(tbxCondoPrice.Text),
                    PaymentFrequency = cbxCondoPayFreq.Text,
                    Parking = cbxParking.Checked,
                    Security = cbxSecurity.Checked,
                    Clubhouse = cbxClubhouse.Checked,
                    Utilities = cbxUtilities.Checked,
                    Gym = cbxGym.Checked,
                    PaymentMethod = paymentMethod,
                };

                if (condominium.Register()) // Register dormitory
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
            if (string.IsNullOrWhiteSpace(tbxCondoName.Text) ||
                string.IsNullOrWhiteSpace(tbxCondoAddress.Text) ||
                string.IsNullOrWhiteSpace(tbxCondoContact.Text) ||
                string.IsNullOrWhiteSpace(nUPCondoTotFloors.Text) ||
                string.IsNullOrWhiteSpace(nUPCondoRoomPerFloor.Text) ||
                string.IsNullOrWhiteSpace(cmbCondoType.Text) ||
                string.IsNullOrWhiteSpace(tbxCondoPrice.Text) ||
                string.IsNullOrWhiteSpace(cbxCondoPayFreq.Text))
            {
                MessageBox.Show("Please complete all property details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void rBtnCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnCash.Checked)
            {
                rBtnCash.Checked = true;
            }
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

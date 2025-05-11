using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentWise_
{
    public partial class Receipt : Form
    {
        public Receipt(string propertyID, string renterID, string firstName, string lastName, DateTime paymentDate)
        {
            InitializeComponent();

            // Set the labels with the received values
            lblPropertyID.Text = propertyID;
            lblRenterID.Text = renterID;
            lblRenterFirstName.Text = firstName;
            lblRenterLastName.Text = lastName;
            lblPaymentDate.Text = paymentDate.ToString("MMMM dd, yyyy");
        }
        public Receipt()
        {
            InitializeComponent();
        }
        private void iconbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconbtnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

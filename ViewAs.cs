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
    public partial class ViewAs : Form
    {
        public enum ViewOption
        {
            None,
            ProofPicture,
            Receipt
        }

        public ViewOption SelectedOption { get; private set; } = ViewOption.None;

        public ViewAs()
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

        private void btnRegisterAsRenter_Click(object sender, EventArgs e)
        {
            //Proof Payment
            SelectedOption = ViewOption.ProofPicture;
            this.Close();
        }

        private void btnRegisterAsOwner_Click(object sender, EventArgs e)
        {
            //Receipt
            SelectedOption = ViewOption.Receipt;
            this.Close();
        }
    }
}

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
    public partial class RegisterAs : Form
    {
        public RegisterAs()
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
            RegisterRenter registerRenter = new RegisterRenter();
            registerRenter.Show();
            this.Close();
        }

        private void btnRegisterAsOwner_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }
    }
}

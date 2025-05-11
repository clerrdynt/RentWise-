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
    public partial class CondoProofPicture : Form
    {
        private int renterID;
        public CondoProofPicture()
        {
           InitializeComponent();
        }
        public CondoProofPicture(int renterID)
        {
            InitializeComponent();
            this.renterID = renterID;
        }

        private void iconbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconbtnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ProofPicture_Load(object sender, EventArgs e)
        {
            LoadProofPicture();
        }
        private void LoadProofPicture()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\RentWise!\RentWise.accdb;";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    //string query =
                    //string query = "SELECT TOP 1 ProofPic FROM ProofPayment WHERE RenterID = ? ORDER BY ID DESC";
                    string query = "SELECT ProofPic FROM ProofPayment WHERE RenterID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", renterID);

                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            byte[] imageData = (byte[])result;
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                iconpbxProofPayment.Image = Image.FromStream(ms);
                                iconpbxProofPayment.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No proof of payment found for this renter.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading proof picture: " + ex.Message);
                }
            }
        }

        private void iconpbxProofPayment_Click(object sender, EventArgs e)
        {
            if (iconpbxProofPayment.Image != null)
            {
                Form preview = new Form
                {
                    Text = "Proof of Payment Preview",
                    Size = new Size(600, 600)
                };
                PictureBox pic = new PictureBox
                {
                    Dock = DockStyle.Fill,
                    Image = iconpbxProofPayment.Image,
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                preview.Controls.Add(pic);
                preview.ShowDialog();
            }
        }
    }
}

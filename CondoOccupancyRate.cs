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
    public partial class CondoOccupancyRate : Form
    {
        int ownerID;
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\RentWise!\RentWise.accdb;";
        public CondoOccupancyRate(int ownerID)
        {
            InitializeComponent();
            this.ownerID = ownerID;
        }

        private void iconbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconbtnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void LoadOccupancyRate()
        {
            int totalCondoRooms = 0;
            int occupiedCondoRooms = 0;

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();

                // Rooms (Dormitory)
                using(OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM CondoRoom WHERE PropertyID IN (SELECT PropertyID FROM Condominium WHERE OwnerID = ?)", conn))
                {
                    cmd.Parameters.AddWithValue("?", ownerID);
                    totalCondoRooms = (int)cmd.ExecuteScalar();
                }

                using (OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM CondoRoom WHERE RenterID IS NOT NULL AND PropertyID IN (SELECT PropertyID FROM Condominium WHERE OwnerID = ?)", conn))
                {
                    cmd.Parameters.AddWithValue("?", ownerID);
                    occupiedCondoRooms = (int)cmd.ExecuteScalar();
                }
                int condoPercent = (totalCondoRooms == 0) ? 0 : (int)((double)occupiedCondoRooms / totalCondoRooms * 100);
                //int condoPercent = (totalCondoRooms == 0) ? 0 : (int)((double)occupiedCondoRooms / totalCondoRooms * 100);

                // Update progress bars
                pBCondoOccupancyRate.Value = condoPercent;
                //progressBarCondo.Value = condoPercent;
                lblCondoRatePercentage.Text = $"{condoPercent}%";
            }
        }

        private void OccupancyRate_Load(object sender, EventArgs e)
        {
            LoadOccupancyRate();
        }
    }
}

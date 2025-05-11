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
    public partial class OccupancyRate : Form
    {
        int ownerID;
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\RentWise!\RentWise.accdb;";
        public OccupancyRate(int ownerID)
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
            int totalDormRooms = 0;
            int occupiedDormRooms = 0;

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();

                // Rooms (Dormitory)
                using (OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM Room WHERE PropertyID IN (SELECT PropertyID FROM Dormitory WHERE OwnerID = ?)", conn))
                {
                    cmd.Parameters.AddWithValue("?", ownerID);
                    totalDormRooms = (int)cmd.ExecuteScalar();
                }

                using (OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM Room WHERE RenterID IS NOT NULL AND PropertyID IN (SELECT PropertyID FROM Dormitory WHERE OwnerID = ?)", conn))
                {
                    cmd.Parameters.AddWithValue("?", ownerID);
                    occupiedDormRooms = (int)cmd.ExecuteScalar();
                }
                int dormPercent = (totalDormRooms == 0) ? 0 : (int)((double)occupiedDormRooms / totalDormRooms * 100);
                //int condoPercent = (totalCondoRooms == 0) ? 0 : (int)((double)occupiedCondoRooms / totalCondoRooms * 100);

                // Update progress bars
                pBDormOccupancyRate.Value = dormPercent;
                //progressBarCondo.Value = condoPercent;
                lblRatePercentage.Text = $"{dormPercent}%";
            }
        }

        private void OccupancyRate_Load(object sender, EventArgs e)
        {
            LoadOccupancyRate();
        }
    }
}

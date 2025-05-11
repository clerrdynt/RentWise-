using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace RentWise_.Classes
{
    public abstract class UserAuthentication
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int PropertyID { get; set; } 
        public DateTime Birthday { get; set; }
        public byte[] ProfilePicture { get; set; }
        public abstract bool Register();
    }
    public class OwnerRegistration : UserAuthentication
    { 
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\RentWise!\RentWise.accdb;";
        public int ownerId { get;  set; } // was once private set
        public string PropertyType { get; set; }

        public override bool Register()
        {
            if (string.IsNullOrWhiteSpace(FirstName?.Trim()) ||
                string.IsNullOrWhiteSpace(LastName?.Trim()) ||
                string.IsNullOrWhiteSpace(Username?.Trim()) ||
                string.IsNullOrWhiteSpace(Password?.Trim()) ||
                string.IsNullOrWhiteSpace(PhoneNumber?.Trim()) ||
                string.IsNullOrWhiteSpace(Email?.Trim()))
            {
                MessageBox.Show("Please ensure all fields are filled in.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            bool isRegistered = false;
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string OwnerQuery = "INSERT INTO Owner ([FirstName], [LastName], [UserName], [Password], [PhoneNumber], [Email], [ProfilePicture]) " +
                                   "VALUES (@FirstName, @LastName, @Username, @Password, @PhoneNumber, @Email, @ProfilePicture)";

                    using (OleDbCommand ownercmd = new OleDbCommand(OwnerQuery, conn))
                    {
                        ownercmd.Parameters.AddWithValue("@FirstName", FirstName);
                        ownercmd.Parameters.AddWithValue("@LastName", LastName);
                        ownercmd.Parameters.AddWithValue("@Username", Username);
                        ownercmd.Parameters.AddWithValue("@Password", Password);
                        ownercmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        ownercmd.Parameters.AddWithValue("@Email", Email);
                        if (ProfilePicture == null || ProfilePicture.Length == 0)
                        {
                            ownercmd.Parameters.Add("@ProfilePicture", OleDbType.Binary).Value = DBNull.Value;
                        }
                        else
                        {
                            ownercmd.Parameters.Add("@ProfilePicture", OleDbType.Binary).Value = ProfilePicture;
                        }

                        ownercmd.ExecuteNonQuery();
                    }
                    string getOwnerIdQuery = "SELECT @@IDENTITY";
                    //int ownerId;
                    using (OleDbCommand getIdCmd = new OleDbCommand(getOwnerIdQuery, conn))
                    {
                        object result = getIdCmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            this.ownerId = id;
                        }
                        else
                        {
                            MessageBox.Show("Failed to retrieve OwnerID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    // Step 3: Insert Property into Property table
                    string propertyQuery = "INSERT INTO Property ([OwnerID], [PropertyType]) VALUES (@OwnerID, @PropertyType)";

                    using (OleDbCommand propertyCmd = new OleDbCommand(propertyQuery, conn))
                    {
                        propertyCmd.Parameters.AddWithValue("@OwnerID", ownerId);
                        propertyCmd.Parameters.AddWithValue("@PropertyType", PropertyType);
                        propertyCmd.ExecuteNonQuery();
                    }

                    return true; // Registration successful
                }
                isRegistered = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while registering: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Registration failed
            }
            return isRegistered;
        }
    }
    public class Dormitory : UserAuthentication
    {
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\RentWise!\RentWise.accdb;";
        public int PropertyID { get; set; } 
        public int OwnerID { get; set; }  // Foreign Key to Owner
        public string DormitoryName { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }  // Large Number
        public int TotalFloors { get; set; }
        public int RoomsPerFloor { get; set; }
        public string RoomTypes { get; set; }
        public decimal PricePerMonth { get; set; }
        public int PaymentFrequency { get; set; }  // Number
        public string PaymentMethod { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public byte[]? Picture { get; set; } // Placeholder for image, if needed

        public bool RegisterPaymentMethod()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    //int dormId;
                    using (OleDbCommand getIdCmd = new OleDbCommand("SELECT MAX(PropertyID) FROM [Property]", conn))
                    {

                        int  result = Convert.ToInt32(getIdCmd.ExecuteScalar());
                        //getIdCmd.ExecuteScalar();
                        if (result != null)
                        {
                            this.PropertyID = result;
                        }
                        else
                        {
                            MessageBox.Show("Failed to retrieve DormID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    string query = "INSERT INTO PaymentMethod ([PropertyID], [Picture], [AccountName], [AccountNumber]) " +
                                   "VALUES (@PropertyID, @Picture, @AccountName, @AccountNumber)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PropertyID", this.PropertyID);
                        if (Picture == null || Picture.Length == 0)
                        {
                            cmd.Parameters.Add("@Picture", OleDbType.Binary).Value = DBNull.Value;
                        }
                        else
                        {
                            cmd.Parameters.Add("@Picture", OleDbType.Binary).Value = Picture;
                        }

                        cmd.Parameters.AddWithValue("@AccountName", AccountName);
                        cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving payment method: " + ex.Message);
                return false;
            }
        }

        public override bool Register()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    //int dormId;
                    using (OleDbCommand getIdCmd = new OleDbCommand("SELECT MAX(PropertyID) FROM Property", conn))
                    {
                        object result = getIdCmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int propertyId))
                        {
                            this.PropertyID = propertyId;
                        }
                        else
                        {
                            MessageBox.Show("Failed to retrieve DormID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    InsertRooms(conn, PropertyID, TotalFloors, RoomsPerFloor);

                    string dormQuery = "INSERT INTO Dormitory ([PropertyID], [OwnerID], [DormitoryName], [Address], [ContactNo], [TotalFloors], [RoomsPerFloor], [RoomTypes], [PricePerMonth], [PaymentFrequency], [PaymentMethod]) " +
                                      "VALUES (@PropertyID, @OwnerID, @DormitoryName, @Address, @ContactNo, @TotalFloors, @RoomsPerFloor, @RoomTypes, @PricePerMonth, @PaymentFrequency, @PaymentMethod)";

                    using (OleDbCommand dormCmd = new OleDbCommand(dormQuery, conn))
                    {
                        dormCmd.Parameters.AddWithValue("@PropertyID", PropertyID);
                        dormCmd.Parameters.AddWithValue("@OwnerID", OwnerID);
                        dormCmd.Parameters.AddWithValue("@DormitoryName", DormitoryName);
                        dormCmd.Parameters.AddWithValue("@Address", Address);
                        dormCmd.Parameters.AddWithValue("@ContactNo", ContactNo);
                        dormCmd.Parameters.AddWithValue("@TotalFloors", TotalFloors);
                        dormCmd.Parameters.AddWithValue("@RoomsPerFloor", RoomsPerFloor);
                        dormCmd.Parameters.AddWithValue("@RoomTypes", RoomTypes);
                        dormCmd.Parameters.AddWithValue("@PricePerMonth", PricePerMonth);
                        dormCmd.Parameters.AddWithValue("@PaymentFrequency", PaymentFrequency);
                        dormCmd.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);

                        dormCmd.ExecuteNonQuery();
                    }
                    
                    //InsertPaymentMethod(conn, DormID, Picture, AccountName, AccountNumber);
                    return true; // Dormitory registration successful
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while registering dormitory: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } 
        }
        private void InsertRooms(OleDbConnection conn, int propertyId, int totalFloors, int roomsPerFloor)
        {
            string roomQuery = "INSERT INTO Room ([PropertyID], [FloorNumber], [RoomNumber], [RenterID], [Status]) " +
                               "VALUES (@PropertyID, @FloorNumber, @RoomNumber, NULL, 'Vacant')";

            using (OleDbCommand roomCmd = new OleDbCommand(roomQuery, conn))
            {
                for (int floor = 1; floor <= totalFloors; floor++)
                {
                    for (int room = 1; room <= roomsPerFloor; room++)
                    {
                        string formattedRoomNumber = $"{floor}{room:D2}"; // Formats as 101, 102, 201, 202, etc.

                        roomCmd.Parameters.Clear();
                        roomCmd.Parameters.AddWithValue("@PropertyID", propertyId);
                        roomCmd.Parameters.AddWithValue("@FloorNumber", floor);
                        roomCmd.Parameters.AddWithValue("@RoomNumber", formattedRoomNumber);
                        roomCmd.Parameters.AddWithValue("@RenterID", DBNull.Value); // Initially no renter

                        //MessageBox.Show("Room PropertyID: " + propertyId);
                        roomCmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
    public class Condominium : UserAuthentication
    {
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\RentWise!\RentWise.accdb;";
        public int PropertyID { get; set; } 
        public int OwnerID { get; set; }  // Foreign Key to Owner
        public string CondoName { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }  // Large Number
        public int TotalFloors { get; set; }
        public int UnitPerFloor { get; set; }
        public string RoomTypes { get; set; }
        public decimal PricePerMonth { get; set; }
        public string PaymentFrequency { get; set; }  // Number
        public bool Parking { get; set; }
        public bool Security { get; set; }
        public bool Clubhouse { get; set; }
        public bool Utilities { get; set; }
        public bool Gym { get; set; }
        public byte[]? Picture { get; set; } // Placeholder for image, if needed
        public string PaymentMethod { get; set; }
        public string CondoAccountName { get; set; }
        public string CondoAccountNumber { get; set; }
        public bool RegisterCondoPaymentMethod()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    //int dormId;
                    using (OleDbCommand getIdCmd = new OleDbCommand("SELECT MAX(PropertyID) FROM [Property]", conn))
                    {

                        int result = Convert.ToInt32(getIdCmd.ExecuteScalar());
                        //getIdCmd.ExecuteScalar();
                        if (result != null)
                        {
                            this.PropertyID = result;
                        }
                        else
                        {
                            MessageBox.Show("Failed to retrieve DormID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    string query = "INSERT INTO PaymentMethod ([PropertyID], [Picture], [AccountName], [AccountNumber]) " +
                                   "VALUES (@PropertyID, @Picture, @AccountName, @AccountNumber)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PropertyID", this.PropertyID);
                        if (Picture == null || Picture.Length == 0)
                        {
                            cmd.Parameters.Add("@Picture", OleDbType.Binary).Value = DBNull.Value;
                        }
                        else
                        {
                            cmd.Parameters.Add("@Picture", OleDbType.Binary).Value = ProfilePicture;
                        }
                        cmd.Parameters.AddWithValue("@AccountName", CondoAccountName);
                        cmd.Parameters.AddWithValue("@AccountNumber", CondoAccountNumber);
                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving payment method: " + ex.Message);
                return false;
            }
        }

        public override bool Register()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    using (OleDbCommand getIdCmd = new OleDbCommand("SELECT MAX(PropertyID) FROM Property", conn))
                    {
                        object result = getIdCmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int propertyId))
                        {
                            this.PropertyID = propertyId;
                        }
                        else
                        {
                            MessageBox.Show("Failed to retrieve DormID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    InsertCondoRooms(conn, PropertyID, TotalFloors, UnitPerFloor);
                    // Step 3: Insert Property into Property table
                    string condoQuery = "INSERT INTO Condominium ([PropertyID], [OwnerID], [CondoName], [Address], [ContactNo], [TotalFloors], [UnitPerFloor], [RoomTypes], [PricePerMonth], [PaymentFrequency],[Parking], [Security], [Clubhouse], [Utilities], [Gym],[PaymentMethod]) " +
                                       "VALUES (@PropertyID, @OwnerID, @CondoName, @Address, @ContactNo, @TotalFloors, @UnitPerFloor, @RoomTypes, @PricePerMonth, @PaymentFrequency, @Parking, @Security, @Clubhouse, @Utilities, @Gym, @PaymentMethod)";

                    using (OleDbCommand condoCmd = new OleDbCommand(condoQuery, conn))
                    {
                        condoCmd.Parameters.AddWithValue("@PropertyID", PropertyID);
                        condoCmd.Parameters.AddWithValue("@OwnerID", OwnerID);
                        condoCmd.Parameters.AddWithValue("@CondoName", CondoName);
                        condoCmd.Parameters.AddWithValue("@Address", Address);
                        condoCmd.Parameters.AddWithValue("@ContactNo", ContactNo);
                        condoCmd.Parameters.AddWithValue("@TotalFloors", TotalFloors);
                        condoCmd.Parameters.AddWithValue("@UnitPerFloor", UnitPerFloor);
                        condoCmd.Parameters.AddWithValue("@RoomTypes", RoomTypes);
                        condoCmd.Parameters.AddWithValue("@PricePerMonth", PricePerMonth);
                        condoCmd.Parameters.AddWithValue("@PaymentFrequency", PaymentFrequency);
                        condoCmd.Parameters.AddWithValue("@Parking", Parking);
                        condoCmd.Parameters.AddWithValue("@Security", Security);
                        condoCmd.Parameters.AddWithValue("@Clubhouse", Clubhouse);
                        condoCmd.Parameters.AddWithValue("@Utilities", Utilities);
                        condoCmd.Parameters.AddWithValue("@Gym", Gym);
                        condoCmd.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);

                        condoCmd.ExecuteNonQuery();
                    }
                    
                    return true; // Dormitory registration successful
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while registering dormitory: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void InsertCondoRooms(OleDbConnection conn, int propertyId, int totalFloors, int roomsPerFloor)
        {
            string roomQuery = "INSERT INTO CondoRoom ([PropertyID], [FloorNumber], [UnitNumber], [RenterID], [Status]) " +
                               "VALUES (@PropertyID, @FloorNumber, @UnitNumber, NULL, 'Vacant')";

            using (OleDbCommand roomCmd = new OleDbCommand(roomQuery, conn))
            {
                for (int floor = 1; floor <= totalFloors; floor++)
                {
                    for (int room = 1; room <= roomsPerFloor; room++)
                    {
                        string formattedRoomNumber = $"{floor}{room:D2}"; // Formats as 101, 102, 201, 202, etc.

                        roomCmd.Parameters.Clear();
                        roomCmd.Parameters.AddWithValue("@PropertyID", propertyId);
                        roomCmd.Parameters.AddWithValue("@FloorNumber", floor);
                        roomCmd.Parameters.AddWithValue("@RoomNumber", formattedRoomNumber);
                        roomCmd.Parameters.AddWithValue("@RenterID", DBNull.Value); // Initially no renter

                        //MessageBox.Show("Room PropertyID: " + propertyId);
                        roomCmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
    

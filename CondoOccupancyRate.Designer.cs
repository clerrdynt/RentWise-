namespace RentWise_
{
    partial class CondoOccupancyRate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CondoOccupancyRate));
            iconbtnClose = new FontAwesome.Sharp.IconButton();
            iconbtnMinimized = new FontAwesome.Sharp.IconButton();
            pBCondoOccupancyRate = new ProgressBar();
            lblDormRoom = new Label();
            lblCondoRatePercentage = new Label();
            SuspendLayout();
            // 
            // iconbtnClose
            // 
            iconbtnClose.BackColor = Color.White;
            iconbtnClose.FlatAppearance.BorderSize = 0;
            iconbtnClose.FlatStyle = FlatStyle.Flat;
            iconbtnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            iconbtnClose.IconColor = Color.Black;
            iconbtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnClose.IconSize = 25;
            iconbtnClose.Location = new Point(556, 12);
            iconbtnClose.Name = "iconbtnClose";
            iconbtnClose.Size = new Size(46, 40);
            iconbtnClose.TabIndex = 7;
            iconbtnClose.UseVisualStyleBackColor = false;
            iconbtnClose.Click += iconbtnClose_Click;
            // 
            // iconbtnMinimized
            // 
            iconbtnMinimized.BackColor = Color.White;
            iconbtnMinimized.FlatAppearance.BorderSize = 0;
            iconbtnMinimized.FlatStyle = FlatStyle.Flat;
            iconbtnMinimized.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconbtnMinimized.IconColor = Color.Black;
            iconbtnMinimized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnMinimized.IconSize = 25;
            iconbtnMinimized.Location = new Point(521, 12);
            iconbtnMinimized.Name = "iconbtnMinimized";
            iconbtnMinimized.Size = new Size(46, 40);
            iconbtnMinimized.TabIndex = 8;
            iconbtnMinimized.UseVisualStyleBackColor = false;
            iconbtnMinimized.Click += iconbtnMinimized_Click;
            // 
            // pBCondoOccupancyRate
            // 
            pBCondoOccupancyRate.Location = new Point(117, 126);
            pBCondoOccupancyRate.Name = "pBCondoOccupancyRate";
            pBCondoOccupancyRate.Size = new Size(368, 57);
            pBCondoOccupancyRate.TabIndex = 9;
            // 
            // lblDormRoom
            // 
            lblDormRoom.AutoSize = true;
            lblDormRoom.BackColor = Color.Transparent;
            lblDormRoom.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDormRoom.Location = new Point(208, 236);
            lblDormRoom.Name = "lblDormRoom";
            lblDormRoom.Size = new Size(174, 23);
            lblDormRoom.TabIndex = 10;
            lblDormRoom.Text = "Occupancy Rate";
            // 
            // lblCondoRatePercentage
            // 
            lblCondoRatePercentage.AutoSize = true;
            lblCondoRatePercentage.BackColor = Color.Transparent;
            lblCondoRatePercentage.Font = new Font("Century Gothic", 12F);
            lblCondoRatePercentage.Location = new Point(273, 201);
            lblCondoRatePercentage.Name = "lblCondoRatePercentage";
            lblCondoRatePercentage.Size = new Size(59, 23);
            lblCondoRatePercentage.TabIndex = 11;
            lblCondoRatePercentage.Text = "100%";
            // 
            // CondoOccupancyRate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(614, 491);
            Controls.Add(lblCondoRatePercentage);
            Controls.Add(lblDormRoom);
            Controls.Add(pBCondoOccupancyRate);
            Controls.Add(iconbtnMinimized);
            Controls.Add(iconbtnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CondoOccupancyRate";
            Text = "OccupancyRate";
            Load += OccupancyRate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconbtnClose;
        private FontAwesome.Sharp.IconButton iconbtnMinimized;
        private ProgressBar pBCondoOccupancyRate;
        private Label lblDormRoom;
        private Label lblCondoRatePercentage;
    }
}
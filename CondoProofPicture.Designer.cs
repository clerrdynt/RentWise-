namespace RentWise_
{
    partial class CondoProofPicture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProofPicture));
            iconbtnClose = new FontAwesome.Sharp.IconButton();
            iconbtnMinimized = new FontAwesome.Sharp.IconButton();
            iconpbxProofPayment = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)iconpbxProofPayment).BeginInit();
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
            iconbtnClose.Location = new Point(477, 12);
            iconbtnClose.Name = "iconbtnClose";
            iconbtnClose.Size = new Size(46, 40);
            iconbtnClose.TabIndex = 6;
            iconbtnClose.UseVisualStyleBackColor = false;
            iconbtnClose.Click += iconbtnClose_Click;
            // 
            // iconbtnMinimized
            // 
            iconbtnMinimized.BackColor = Color.White;
            iconbtnMinimized.BackgroundImage = (Image)resources.GetObject("iconbtnMinimized.BackgroundImage");
            iconbtnMinimized.FlatAppearance.BorderSize = 0;
            iconbtnMinimized.FlatStyle = FlatStyle.Flat;
            iconbtnMinimized.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconbtnMinimized.IconColor = Color.Black;
            iconbtnMinimized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnMinimized.IconSize = 25;
            iconbtnMinimized.Location = new Point(425, 12);
            iconbtnMinimized.Name = "iconbtnMinimized";
            iconbtnMinimized.Size = new Size(46, 40);
            iconbtnMinimized.TabIndex = 12;
            iconbtnMinimized.UseVisualStyleBackColor = false;
            iconbtnMinimized.Click += iconbtnMinimized_Click;
            // 
            // iconpbxProofPayment
            // 
            iconpbxProofPayment.BackColor = Color.Transparent;
            iconpbxProofPayment.ForeColor = SystemColors.ControlText;
            iconpbxProofPayment.IconChar = FontAwesome.Sharp.IconChar.None;
            iconpbxProofPayment.IconColor = SystemColors.ControlText;
            iconpbxProofPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconpbxProofPayment.IconSize = 285;
            iconpbxProofPayment.Location = new Point(119, 37);
            iconpbxProofPayment.Name = "iconpbxProofPayment";
            iconpbxProofPayment.Size = new Size(285, 354);
            iconpbxProofPayment.TabIndex = 13;
            iconpbxProofPayment.TabStop = false;
            iconpbxProofPayment.Click += iconpbxProofPayment_Click;
            // 
            // ProofPicture
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(535, 442);
            Controls.Add(iconpbxProofPayment);
            Controls.Add(iconbtnMinimized);
            Controls.Add(iconbtnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProofPicture";
            Text = "ProofPicture";
            Load += ProofPicture_Load;
            ((System.ComponentModel.ISupportInitialize)iconpbxProofPayment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconbtnClose;
        private FontAwesome.Sharp.IconButton iconbtnMinimized;
        private FontAwesome.Sharp.IconPictureBox iconpbxProofPayment;
    }
}
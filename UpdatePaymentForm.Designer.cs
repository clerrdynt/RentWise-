namespace RentWise_
{
    partial class UpdatePaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePaymentForm));
            iconbtnClose = new FontAwesome.Sharp.IconButton();
            iconbtnMinimized = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblAccountName = new Label();
            lblAccountNumber = new Label();
            lblPayMethod = new Label();
            btnUpdateProofPayment = new Button();
            btnUploadProof = new Button();
            pbxProofPayment = new PictureBox();
            pbxPayMethodPic = new PictureBox();
            iconpbxPayMethodPic = new FontAwesome.Sharp.IconPictureBox();
            iconpbxCash = new FontAwesome.Sharp.IconPictureBox();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxProofPayment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPayMethodPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconpbxPayMethodPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconpbxCash).BeginInit();
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
            iconbtnClose.Location = new Point(742, 12);
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
            iconbtnMinimized.Location = new Point(690, 12);
            iconbtnMinimized.Name = "iconbtnMinimized";
            iconbtnMinimized.Size = new Size(46, 40);
            iconbtnMinimized.TabIndex = 8;
            iconbtnMinimized.UseVisualStyleBackColor = false;
            iconbtnMinimized.Click += iconbtnMinimized_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 10.2F);
            label1.Location = new Point(191, 14);
            label1.Name = "label1";
            label1.Size = new Size(161, 21);
            label1.TabIndex = 37;
            label1.Text = "Payment Method:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 10.2F);
            label2.Location = new Point(44, 330);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 38;
            label2.Text = "Account Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 10.2F);
            label3.Location = new Point(44, 373);
            label3.Name = "label3";
            label3.Size = new Size(159, 21);
            label3.TabIndex = 39;
            label3.Text = "Account Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 331);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 40;
            // 
            // lblAccountName
            // 
            lblAccountName.AutoSize = true;
            lblAccountName.BackColor = Color.FromArgb(0, 148, 115);
            lblAccountName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccountName.ForeColor = Color.White;
            lblAccountName.Location = new Point(212, 331);
            lblAccountName.Name = "lblAccountName";
            lblAccountName.Size = new Size(134, 21);
            lblAccountName.TabIndex = 41;
            lblAccountName.Text = "AccountName";
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.AutoSize = true;
            lblAccountNumber.BackColor = Color.FromArgb(0, 148, 115);
            lblAccountNumber.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccountNumber.ForeColor = Color.White;
            lblAccountNumber.Location = new Point(212, 373);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(149, 21);
            lblAccountNumber.TabIndex = 42;
            lblAccountNumber.Text = "AccountNumber";
            // 
            // lblPayMethod
            // 
            lblPayMethod.AutoSize = true;
            lblPayMethod.BackColor = Color.FromArgb(0, 148, 115);
            lblPayMethod.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPayMethod.ForeColor = Color.White;
            lblPayMethod.Location = new Point(191, 45);
            lblPayMethod.Name = "lblPayMethod";
            lblPayMethod.Size = new Size(151, 21);
            lblPayMethod.TabIndex = 43;
            lblPayMethod.Text = "PaymentMethod";
            // 
            // btnUpdateProofPayment
            // 
            btnUpdateProofPayment.BackColor = Color.FromArgb(0, 148, 115);
            btnUpdateProofPayment.Font = new Font("Century Gothic", 10.8F);
            btnUpdateProofPayment.ForeColor = Color.White;
            btnUpdateProofPayment.Location = new Point(297, 421);
            btnUpdateProofPayment.Name = "btnUpdateProofPayment";
            btnUpdateProofPayment.Size = new Size(122, 48);
            btnUpdateProofPayment.TabIndex = 44;
            btnUpdateProofPayment.Text = "Submit";
            btnUpdateProofPayment.UseVisualStyleBackColor = false;
            btnUpdateProofPayment.Click += btnUpdateProofPayment_Click;
            // 
            // btnUploadProof
            // 
            btnUploadProof.BackColor = Color.FromArgb(0, 148, 115);
            btnUploadProof.Font = new Font("Century Gothic", 10.8F);
            btnUploadProof.ForeColor = Color.White;
            btnUploadProof.Location = new Point(577, 330);
            btnUploadProof.Name = "btnUploadProof";
            btnUploadProof.Size = new Size(134, 48);
            btnUploadProof.TabIndex = 45;
            btnUploadProof.Text = "Upload";
            btnUploadProof.UseVisualStyleBackColor = false;
            btnUploadProof.Click += btnUploadProof_Click;
            // 
            // pbxProofPayment
            // 
            pbxProofPayment.BackColor = Color.Transparent;
            pbxProofPayment.Location = new Point(509, 82);
            pbxProofPayment.Name = "pbxProofPayment";
            pbxProofPayment.Size = new Size(263, 233);
            pbxProofPayment.TabIndex = 46;
            pbxProofPayment.TabStop = false;
            // 
            // pbxPayMethodPic
            // 
            pbxPayMethodPic.BackColor = Color.Transparent;
            pbxPayMethodPic.Location = new Point(116, 82);
            pbxPayMethodPic.Name = "pbxPayMethodPic";
            pbxPayMethodPic.Size = new Size(270, 221);
            pbxPayMethodPic.TabIndex = 47;
            pbxPayMethodPic.TabStop = false;
            // 
            // iconpbxPayMethodPic
            // 
            iconpbxPayMethodPic.BackColor = Color.Transparent;
            iconpbxPayMethodPic.ForeColor = SystemColors.ControlText;
            iconpbxPayMethodPic.IconChar = FontAwesome.Sharp.IconChar.BuildingUser;
            iconpbxPayMethodPic.IconColor = SystemColors.ControlText;
            iconpbxPayMethodPic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconpbxPayMethodPic.IconSize = 221;
            iconpbxPayMethodPic.Location = new Point(116, 82);
            iconpbxPayMethodPic.Name = "iconpbxPayMethodPic";
            iconpbxPayMethodPic.Size = new Size(270, 221);
            iconpbxPayMethodPic.SizeMode = PictureBoxSizeMode.CenterImage;
            iconpbxPayMethodPic.TabIndex = 48;
            iconpbxPayMethodPic.TabStop = false;
            // 
            // iconpbxCash
            // 
            iconpbxCash.BackColor = Color.Transparent;
            iconpbxCash.ForeColor = SystemColors.ControlText;
            iconpbxCash.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            iconpbxCash.IconColor = SystemColors.ControlText;
            iconpbxCash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconpbxCash.IconSize = 221;
            iconpbxCash.Location = new Point(116, 82);
            iconpbxCash.Name = "iconpbxCash";
            iconpbxCash.Size = new Size(270, 221);
            iconpbxCash.SizeMode = PictureBoxSizeMode.CenterImage;
            iconpbxCash.TabIndex = 49;
            iconpbxCash.TabStop = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 148, 115);
            btnUpdate.Font = new Font("Century Gothic", 10.8F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(577, 384);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 48);
            btnUpdate.TabIndex = 50;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // UpdatePaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 531);
            Controls.Add(btnUpdate);
            Controls.Add(pbxProofPayment);
            Controls.Add(btnUploadProof);
            Controls.Add(btnUpdateProofPayment);
            Controls.Add(lblPayMethod);
            Controls.Add(lblAccountNumber);
            Controls.Add(lblAccountName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(iconbtnMinimized);
            Controls.Add(iconbtnClose);
            Controls.Add(iconpbxPayMethodPic);
            Controls.Add(pbxPayMethodPic);
            Controls.Add(iconpbxCash);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdatePaymentForm";
            Text = "UpdatePaymentForm";
            Load += UpdatePaymentForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbxProofPayment).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPayMethodPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconpbxPayMethodPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconpbxCash).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconbtnClose;
        private FontAwesome.Sharp.IconButton iconbtnMinimized;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblAccountName;
        private Label lblAccountNumber;
        private Label lblPayMethod;
        private Button btnUpdateProofPayment;
        private Button btnUploadProof;
        private PictureBox pbxProofPayment;
        private PictureBox pbxPayMethodPic;
        private FontAwesome.Sharp.IconPictureBox iconpbxPayMethodPic;
        private FontAwesome.Sharp.IconPictureBox iconpbxCash;
        private Button btnUpdate;
    }
}
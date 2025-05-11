namespace RentWise_
{
    partial class EventCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventCard));
            lblEventWhen = new Label();
            lblEventName = new Label();
            lblEventWhere = new Label();
            SuspendLayout();
            // 
            // lblEventWhen
            // 
            lblEventWhen.AutoSize = true;
            lblEventWhen.BackColor = Color.Transparent;
            lblEventWhen.Font = new Font("Century Gothic", 10.8F);
            lblEventWhen.Location = new Point(26, 45);
            lblEventWhen.Name = "lblEventWhen";
            lblEventWhen.Size = new Size(61, 21);
            lblEventWhen.TabIndex = 0;
            lblEventWhen.Text = "When";
            // 
            // lblEventName
            // 
            lblEventName.AutoSize = true;
            lblEventName.BackColor = Color.Transparent;
            lblEventName.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEventName.Location = new Point(20, 79);
            lblEventName.Name = "lblEventName";
            lblEventName.Size = new Size(80, 26);
            lblEventName.TabIndex = 1;
            lblEventName.Text = "Event";
            // 
            // lblEventWhere
            // 
            lblEventWhere.AutoSize = true;
            lblEventWhere.BackColor = Color.Transparent;
            lblEventWhere.Font = new Font("Century Gothic", 10.8F);
            lblEventWhere.Location = new Point(26, 119);
            lblEventWhere.Name = "lblEventWhere";
            lblEventWhere.Size = new Size(67, 21);
            lblEventWhere.TabIndex = 2;
            lblEventWhere.Text = "Where";
            // 
            // EventCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lblEventWhere);
            Controls.Add(lblEventName);
            Controls.Add(lblEventWhen);
            Name = "EventCard";
            Size = new Size(424, 186);
            Load += EventCard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEventWhen;
        private Label lblEventName;
        private Label lblEventWhere;
    }
}

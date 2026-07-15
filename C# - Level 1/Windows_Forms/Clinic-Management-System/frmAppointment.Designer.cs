namespace Clinic_Management_System
{
    partial class frmAppointment
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.cbDoctors = new System.Windows.Forms.ComboBox();
            this.grpServices = new System.Windows.Forms.GroupBox();
            this.clbServices = new System.Windows.Forms.CheckedListBox();
            this.grpAppointmentDate = new System.Windows.Forms.GroupBox();
            this.mcAppointment = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.chkNotifications = new System.Windows.Forms.CheckBox();
            this.lblNeedHelp = new System.Windows.Forms.Label();
            this.linkClinicWebsite = new System.Windows.Forms.LinkLabel();
            this.notifyClinic = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.grpServices.SuspendLayout();
            this.grpAppointmentDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitle.Location = new System.Drawing.Point(481, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(485, 54);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Appointment Booking";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.ForeColor = System.Drawing.Color.Red;
            this.lblDoctor.Location = new System.Drawing.Point(634, 114);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(120, 38);
            this.lblDoctor.TabIndex = 2;
            this.lblDoctor.Text = "Doctor";
            // 
            // cbDoctors
            // 
            this.cbDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDoctors.FormattingEnabled = true;
            this.cbDoctors.Items.AddRange(new object[] {
            "Dr.Ahmed Hassan",
            "Dr.Mohamed Ali",
            "Dr.Sara Ibrahim",
            "Dr.Omar Khaled"});
            this.cbDoctors.Location = new System.Drawing.Point(575, 181);
            this.cbDoctors.Name = "cbDoctors";
            this.cbDoctors.Size = new System.Drawing.Size(261, 37);
            this.cbDoctors.TabIndex = 3;
            this.cbDoctors.SelectedIndexChanged += new System.EventHandler(this.cbDoctors_SelectedIndexChanged);
            // 
            // grpServices
            // 
            this.grpServices.Controls.Add(this.clbServices);
            this.grpServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpServices.ForeColor = System.Drawing.Color.Red;
            this.grpServices.Location = new System.Drawing.Point(56, 237);
            this.grpServices.Name = "grpServices";
            this.grpServices.Size = new System.Drawing.Size(325, 170);
            this.grpServices.TabIndex = 4;
            this.grpServices.TabStop = false;
            this.grpServices.Text = "Medical Services ";
            // 
            // clbServices
            // 
            this.clbServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbServices.FormattingEnabled = true;
            this.clbServices.Location = new System.Drawing.Point(11, 33);
            this.clbServices.Name = "clbServices";
            this.clbServices.Size = new System.Drawing.Size(308, 129);
            this.clbServices.TabIndex = 0;
            // 
            // grpAppointmentDate
            // 
            this.grpAppointmentDate.Controls.Add(this.mcAppointment);
            this.grpAppointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAppointmentDate.ForeColor = System.Drawing.Color.Red;
            this.grpAppointmentDate.Location = new System.Drawing.Point(1041, 237);
            this.grpAppointmentDate.Name = "grpAppointmentDate";
            this.grpAppointmentDate.Size = new System.Drawing.Size(341, 276);
            this.grpAppointmentDate.TabIndex = 5;
            this.grpAppointmentDate.TabStop = false;
            this.grpAppointmentDate.Text = "Appointment Date";
            // 
            // mcAppointment
            // 
            this.mcAppointment.Location = new System.Drawing.Point(22, 57);
            this.mcAppointment.MaxSelectionCount = 1;
            this.mcAppointment.Name = "mcAppointment";
            this.mcAppointment.ShowTodayCircle = false;
            this.mcAppointment.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(536, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current Time :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // chkNotifications
            // 
            this.chkNotifications.AutoSize = true;
            this.chkNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotifications.ForeColor = System.Drawing.SystemColors.Desktop;
            this.chkNotifications.Location = new System.Drawing.Point(1120, 594);
            this.chkNotifications.Name = "chkNotifications";
            this.chkNotifications.Size = new System.Drawing.Size(235, 29);
            this.chkNotifications.TabIndex = 7;
            this.chkNotifications.Text = "Receive Notifications";
            this.chkNotifications.UseVisualStyleBackColor = true;
            // 
            // lblNeedHelp
            // 
            this.lblNeedHelp.AutoSize = true;
            this.lblNeedHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeedHelp.ForeColor = System.Drawing.Color.Red;
            this.lblNeedHelp.Location = new System.Drawing.Point(73, 559);
            this.lblNeedHelp.Name = "lblNeedHelp";
            this.lblNeedHelp.Size = new System.Drawing.Size(115, 22);
            this.lblNeedHelp.TabIndex = 8;
            this.lblNeedHelp.Text = "Need Help?";
            // 
            // linkClinicWebsite
            // 
            this.linkClinicWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkClinicWebsite.ForeColor = System.Drawing.SystemColors.Desktop;
            this.linkClinicWebsite.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkClinicWebsite.LinkColor = System.Drawing.Color.Blue;
            this.linkClinicWebsite.Location = new System.Drawing.Point(40, 604);
            this.linkClinicWebsite.Name = "linkClinicWebsite";
            this.linkClinicWebsite.Size = new System.Drawing.Size(225, 22);
            this.linkClinicWebsite.TabIndex = 9;
            this.linkClinicWebsite.TabStop = true;
            this.linkClinicWebsite.Text = "Visit SmileCare Website";
            this.linkClinicWebsite.VisitedLinkColor = System.Drawing.Color.Yellow;
            this.linkClinicWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClinicWebsite_LinkClicked);
            // 
            // notifyClinic
            // 
            this.notifyClinic.Text = "notifyIcon1";
            this.notifyClinic.Visible = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrevious.Location = new System.Drawing.Point(65, 735);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(209, 79);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "Previous ";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(575, 735);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(284, 79);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save Appointment";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(1107, 735);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(209, 79);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblShowTime
            // 
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTime.ForeColor = System.Drawing.Color.Yellow;
            this.lblShowTime.Location = new System.Drawing.Point(762, 446);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(98, 32);
            this.lblShowTime.TabIndex = 13;
            this.lblShowTime.Text = "label3";
            // 
            // frmAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1412, 826);
            this.Controls.Add(this.lblShowTime);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.linkClinicWebsite);
            this.Controls.Add(this.lblNeedHelp);
            this.Controls.Add(this.chkNotifications);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpAppointmentDate);
            this.Controls.Add(this.grpServices);
            this.Controls.Add(this.cbDoctors);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Name = "frmAppointment";
            this.Text = "frmAppointment";
            this.Load += new System.EventHandler(this.frmAppointment_Load);
            this.grpServices.ResumeLayout(false);
            this.grpAppointmentDate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox cbDoctors;
        private System.Windows.Forms.GroupBox grpServices;
        private System.Windows.Forms.GroupBox grpAppointmentDate;
        private System.Windows.Forms.MonthCalendar mcAppointment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.CheckBox chkNotifications;
        private System.Windows.Forms.Label lblNeedHelp;
        private System.Windows.Forms.LinkLabel linkClinicWebsite;
        private System.Windows.Forms.NotifyIcon notifyClinic;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckedListBox clbServices;
        private System.Windows.Forms.Label lblShowTime;
    }
}
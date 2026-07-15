namespace Clinic_Management_System
{
    partial class frmPatientInformation
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tboxFullName = new System.Windows.Forms.TextBox();
            this.tboxPhone = new System.Windows.Forms.TextBox();
            this.tboxID = new System.Windows.Forms.TextBox();
            this.tboxAddress = new System.Windows.Forms.TextBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dtkDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblNote = new System.Windows.Forms.Label();
            this.txbDateOfBirth = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExist = new System.Windows.Forms.Button();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitle.Location = new System.Drawing.Point(532, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(433, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Patient Information";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(46, 147);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(275, 36);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name            :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(46, 240);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(272, 36);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone Number    :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(46, 313);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(272, 36);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "National ID          :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(46, 394);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(268, 36);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address              :";
            // 
            // tboxFullName
            // 
            this.tboxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxFullName.Location = new System.Drawing.Point(385, 150);
            this.tboxFullName.Multiline = true;
            this.tboxFullName.Name = "tboxFullName";
            this.tboxFullName.Size = new System.Drawing.Size(298, 33);
            this.tboxFullName.TabIndex = 5;
            // 
            // tboxPhone
            // 
            this.tboxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.tboxPhone.Location = new System.Drawing.Point(385, 243);
            this.tboxPhone.Multiline = true;
            this.tboxPhone.Name = "tboxPhone";
            this.tboxPhone.Size = new System.Drawing.Size(298, 33);
            this.tboxPhone.TabIndex = 6;
            // 
            // tboxID
            // 
            this.tboxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.tboxID.Location = new System.Drawing.Point(385, 316);
            this.tboxID.Multiline = true;
            this.tboxID.Name = "tboxID";
            this.tboxID.Size = new System.Drawing.Size(298, 33);
            this.tboxID.TabIndex = 7;
            // 
            // tboxAddress
            // 
            this.tboxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.tboxAddress.Location = new System.Drawing.Point(385, 397);
            this.tboxAddress.Multiline = true;
            this.tboxAddress.Name = "tboxAddress";
            this.tboxAddress.Size = new System.Drawing.Size(298, 33);
            this.tboxAddress.TabIndex = 8;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdoFemale);
            this.grpGender.Controls.Add(this.rdoMale);
            this.grpGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGender.ForeColor = System.Drawing.Color.Red;
            this.grpGender.Location = new System.Drawing.Point(1091, 150);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(192, 137);
            this.grpGender.TabIndex = 9;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdoFemale.Location = new System.Drawing.Point(70, 91);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(104, 29);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdoMale.Location = new System.Drawing.Point(70, 42);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(80, 29);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1059, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date Of Birth";
            // 
            // dtkDateOfBirth
            // 
            this.dtkDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtkDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtkDateOfBirth.Location = new System.Drawing.Point(1065, 454);
            this.dtkDateOfBirth.Name = "dtkDateOfBirth";
            this.dtkDateOfBirth.Size = new System.Drawing.Size(191, 28);
            this.dtkDateOfBirth.TabIndex = 12;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(646, 481);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(82, 36);
            this.lblNote.TabIndex = 13;
            this.lblNote.Text = "Note";
            // 
            // txbDateOfBirth
            // 
            this.txbDateOfBirth.Location = new System.Drawing.Point(488, 537);
            this.txbDateOfBirth.Multiline = true;
            this.txbDateOfBirth.Name = "txbDateOfBirth";
            this.txbDateOfBirth.Size = new System.Drawing.Size(402, 171);
            this.txbDateOfBirth.TabIndex = 14;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Black;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Red;
            this.btnPrevious.Location = new System.Drawing.Point(108, 760);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(184, 65);
            this.btnPrevious.TabIndex = 15;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Red;
            this.btnNext.Location = new System.Drawing.Point(603, 760);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(184, 65);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Next ";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExist
            // 
            this.btnExist.BackColor = System.Drawing.Color.Black;
            this.btnExist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExist.ForeColor = System.Drawing.Color.Red;
            this.btnExist.Location = new System.Drawing.Point(1091, 760);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(184, 65);
            this.btnExist.TabIndex = 17;
            this.btnExist.Text = "Cancel ";
            this.btnExist.UseVisualStyleBackColor = false;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // frmPatientInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1411, 837);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txbDateOfBirth);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.dtkDateOfBirth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.tboxAddress);
            this.Controls.Add(this.tboxID);
            this.Controls.Add(this.tboxPhone);
            this.Controls.Add(this.tboxFullName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPatientInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPatientInformation";
        
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tboxFullName;
        private System.Windows.Forms.TextBox tboxPhone;
        private System.Windows.Forms.TextBox tboxID;
        private System.Windows.Forms.TextBox tboxAddress;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtkDateOfBirth;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txbDateOfBirth;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExist;
    }
}
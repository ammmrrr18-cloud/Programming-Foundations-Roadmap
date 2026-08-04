namespace Students_Management
{
    partial class frmIdCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIdCard));
            this.grbID_Card = new System.Windows.Forms.GroupBox();
            this.picIdCard = new System.Windows.Forms.PictureBox();
            this.ShowtxtGender = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ShowtxtGrade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ShowtxtPhone = new System.Windows.Forms.TextBox();
            this.ShowtxtEmail = new System.Windows.Forms.TextBox();
            this.ShowtxtName = new System.Windows.Forms.TextBox();
            this.ShowtxtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.grbID_Card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIdCard)).BeginInit();
            this.SuspendLayout();
            // 
            // grbID_Card
            // 
            this.grbID_Card.BackColor = System.Drawing.Color.Teal;
            this.grbID_Card.Controls.Add(this.btnContinue);
            this.grbID_Card.Controls.Add(this.picIdCard);
            this.grbID_Card.Controls.Add(this.ShowtxtGender);
            this.grbID_Card.Controls.Add(this.label13);
            this.grbID_Card.Controls.Add(this.ShowtxtGrade);
            this.grbID_Card.Controls.Add(this.label12);
            this.grbID_Card.Controls.Add(this.ShowtxtPhone);
            this.grbID_Card.Controls.Add(this.ShowtxtEmail);
            this.grbID_Card.Controls.Add(this.ShowtxtName);
            this.grbID_Card.Controls.Add(this.ShowtxtID);
            this.grbID_Card.Controls.Add(this.label8);
            this.grbID_Card.Controls.Add(this.label9);
            this.grbID_Card.Controls.Add(this.label10);
            this.grbID_Card.Controls.Add(this.label11);
            this.grbID_Card.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbID_Card.Location = new System.Drawing.Point(3, 3);
            this.grbID_Card.Name = "grbID_Card";
            this.grbID_Card.Size = new System.Drawing.Size(925, 422);
            this.grbID_Card.TabIndex = 14;
            this.grbID_Card.TabStop = false;
            this.grbID_Card.Text = "ID Card";
            // 
            // picIdCard
            // 
            this.picIdCard.Image = ((System.Drawing.Image)(resources.GetObject("picIdCard.Image")));
            this.picIdCard.Location = new System.Drawing.Point(17, 48);
            this.picIdCard.Name = "picIdCard";
            this.picIdCard.Size = new System.Drawing.Size(191, 246);
            this.picIdCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIdCard.TabIndex = 21;
            this.picIdCard.TabStop = false;
            // 
            // ShowtxtGender
            // 
            this.ShowtxtGender.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowtxtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowtxtGender.ForeColor = System.Drawing.Color.White;
            this.ShowtxtGender.Location = new System.Drawing.Point(770, 171);
            this.ShowtxtGender.Name = "ShowtxtGender";
            this.ShowtxtGender.ReadOnly = true;
            this.ShowtxtGender.Size = new System.Drawing.Size(151, 34);
            this.ShowtxtGender.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(619, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 32);
            this.label13.TabIndex = 19;
            this.label13.Text = "Gender : ";
            // 
            // ShowtxtGrade
            // 
            this.ShowtxtGrade.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowtxtGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowtxtGrade.ForeColor = System.Drawing.Color.White;
            this.ShowtxtGrade.Location = new System.Drawing.Point(770, 54);
            this.ShowtxtGrade.Name = "ShowtxtGrade";
            this.ShowtxtGrade.ReadOnly = true;
            this.ShowtxtGrade.Size = new System.Drawing.Size(151, 34);
            this.ShowtxtGrade.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(628, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 32);
            this.label12.TabIndex = 11;
            this.label12.Text = "Grade : ";
            // 
            // ShowtxtPhone
            // 
            this.ShowtxtPhone.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowtxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowtxtPhone.ForeColor = System.Drawing.Color.White;
            this.ShowtxtPhone.Location = new System.Drawing.Point(341, 249);
            this.ShowtxtPhone.Name = "ShowtxtPhone";
            this.ShowtxtPhone.ReadOnly = true;
            this.ShowtxtPhone.Size = new System.Drawing.Size(215, 34);
            this.ShowtxtPhone.TabIndex = 17;
            // 
            // ShowtxtEmail
            // 
            this.ShowtxtEmail.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowtxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowtxtEmail.ForeColor = System.Drawing.Color.White;
            this.ShowtxtEmail.Location = new System.Drawing.Point(341, 179);
            this.ShowtxtEmail.Name = "ShowtxtEmail";
            this.ShowtxtEmail.ReadOnly = true;
            this.ShowtxtEmail.Size = new System.Drawing.Size(270, 34);
            this.ShowtxtEmail.TabIndex = 16;
            // 
            // ShowtxtName
            // 
            this.ShowtxtName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowtxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowtxtName.ForeColor = System.Drawing.Color.White;
            this.ShowtxtName.Location = new System.Drawing.Point(336, 115);
            this.ShowtxtName.Name = "ShowtxtName";
            this.ShowtxtName.ReadOnly = true;
            this.ShowtxtName.Size = new System.Drawing.Size(270, 34);
            this.ShowtxtName.TabIndex = 15;
            // 
            // ShowtxtID
            // 
            this.ShowtxtID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowtxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowtxtID.ForeColor = System.Drawing.Color.White;
            this.ShowtxtID.Location = new System.Drawing.Point(336, 48);
            this.ShowtxtID.Name = "ShowtxtID";
            this.ShowtxtID.ReadOnly = true;
            this.ShowtxtID.Size = new System.Drawing.Size(102, 34);
            this.ShowtxtID.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(214, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 32);
            this.label8.TabIndex = 8;
            this.label8.Text = "Phone : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(219, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 32);
            this.label9.TabIndex = 7;
            this.label9.Text = "Email : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(218, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 32);
            this.label10.TabIndex = 6;
            this.label10.Text = "Name : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(243, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 32);
            this.label11.TabIndex = 5;
            this.label11.Text = "ID : ";
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Black;
            this.btnContinue.ForeColor = System.Drawing.Color.LightCoral;
            this.btnContinue.Location = new System.Drawing.Point(383, 363);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(173, 53);
            this.btnContinue.TabIndex = 22;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // frmIdCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 422);
            this.Controls.Add(this.grbID_Card);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmIdCard";
            this.Text = "frmIdCard";
            this.Load += new System.EventHandler(this.frmIdCard_Load);
            this.grbID_Card.ResumeLayout(false);
            this.grbID_Card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIdCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbID_Card;
        private System.Windows.Forms.PictureBox picIdCard;
        private System.Windows.Forms.TextBox ShowtxtGender;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ShowtxtGrade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ShowtxtPhone;
        private System.Windows.Forms.TextBox ShowtxtEmail;
        private System.Windows.Forms.TextBox ShowtxtName;
        private System.Windows.Forms.TextBox ShowtxtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnContinue;
    }
}
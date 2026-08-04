namespace Students_Management
{
    partial class frmStudentsManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentsManagement));
            this.MyListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grbStudent = new System.Windows.Forms.GroupBox();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnGenerateStudents = new System.Windows.Forms.Button();
            this.grbStudentList = new System.Windows.Forms.GroupBox();
            this.cboView = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.btnShowCard = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.grbStudent.SuspendLayout();
            this.grbGender.SuspendLayout();
            this.grbStudentList.SuspendLayout();
            this.grbID_Card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIdCard)).BeginInit();
            this.SuspendLayout();
            // 
            // MyListView
            // 
            this.MyListView.BackColor = System.Drawing.Color.Black;
            this.MyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.MyListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyListView.ForeColor = System.Drawing.Color.Red;
            this.MyListView.HideSelection = false;
            this.MyListView.LargeImageList = this.imageList1;
            this.MyListView.Location = new System.Drawing.Point(6, 29);
            this.MyListView.Name = "MyListView";
            this.MyListView.Size = new System.Drawing.Size(1796, 304);
            this.MyListView.SmallImageList = this.imageList1;
            this.MyListView.TabIndex = 0;
            this.MyListView.UseCompatibleStateImageBehavior = false;
            this.MyListView.View = System.Windows.Forms.View.Details;
            this.MyListView.SelectedIndexChanged += new System.EventHandler(this.MyListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID ";
            this.columnHeader1.Width = 204;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name ";
            this.columnHeader2.Width = 259;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email ";
            this.columnHeader3.Width = 284;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phone ";
            this.columnHeader4.Width = 285;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Grade ";
            this.columnHeader5.Width = 329;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Gender";
            this.columnHeader6.Width = 409;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "vecteezy_happy-schoolboy-with-backpack-and-book-ready-for-school_56613837.png");
            this.imageList1.Images.SetKeyName(1, "vecteezy_watercolor-illustration-of-happy-girl-with-student_54315921.png");
            // 
            // grbStudent
            // 
            this.grbStudent.BackColor = System.Drawing.Color.Green;
            this.grbStudent.Controls.Add(this.cboGrade);
            this.grbStudent.Controls.Add(this.txtPhone);
            this.grbStudent.Controls.Add(this.txtEmail);
            this.grbStudent.Controls.Add(this.txtName);
            this.grbStudent.Controls.Add(this.txtID);
            this.grbStudent.Controls.Add(this.grbGender);
            this.grbStudent.Controls.Add(this.label5);
            this.grbStudent.Controls.Add(this.label4);
            this.grbStudent.Controls.Add(this.label3);
            this.grbStudent.Controls.Add(this.label2);
            this.grbStudent.Controls.Add(this.label1);
            this.grbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbStudent.Location = new System.Drawing.Point(-3, 68);
            this.grbStudent.Name = "grbStudent";
            this.grbStudent.Size = new System.Drawing.Size(815, 318);
            this.grbStudent.TabIndex = 1;
            this.grbStudent.TabStop = false;
            this.grbStudent.Text = "Student Info";
            // 
            // cboGrade
            // 
            this.cboGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Items.AddRange(new object[] {
            "Excellent",
            "Very Good",
            "Good",
            "Pass",
            "Fail"});
            this.cboGrade.Location = new System.Drawing.Point(609, 180);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(151, 33);
            this.cboGrade.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(143, 267);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(262, 38);
            this.txtPhone.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(146, 200);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(315, 38);
            this.txtEmail.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(146, 133);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(311, 38);
            this.txtName.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(146, 66);
            this.txtID.Mask = "00000";
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(127, 38);
            this.txtID.TabIndex = 6;
            this.txtID.ValidatingType = typeof(int);
            // 
            // grbGender
            // 
            this.grbGender.Controls.Add(this.rdoFemale);
            this.grbGender.Controls.Add(this.rdoMale);
            this.grbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGender.Location = new System.Drawing.Point(532, 37);
            this.grbGender.Name = "grbGender";
            this.grbGender.Size = new System.Drawing.Size(222, 90);
            this.grbGender.TabIndex = 5;
            this.grbGender.TabStop = false;
            this.grbGender.Text = "Gender";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.Location = new System.Drawing.Point(111, 56);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(96, 26);
            this.rdoFemale.TabIndex = 6;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.Location = new System.Drawing.Point(8, 56);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(73, 26);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grade : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(681, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(393, 42);
            this.label6.TabIndex = 2;
            this.label6.Text = "Student Management";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGray;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1244, 413);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 49);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightGray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1452, 413);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 49);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightGray;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(1660, 413);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 49);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnGenerateStudents
            // 
            this.btnGenerateStudents.BackColor = System.Drawing.Color.LightGray;
            this.btnGenerateStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateStudents.Location = new System.Drawing.Point(925, 413);
            this.btnGenerateStudents.Name = "btnGenerateStudents";
            this.btnGenerateStudents.Size = new System.Drawing.Size(248, 49);
            this.btnGenerateStudents.TabIndex = 6;
            this.btnGenerateStudents.Text = "Generate Students";
            this.btnGenerateStudents.UseVisualStyleBackColor = false;
            this.btnGenerateStudents.Click += new System.EventHandler(this.btnGenerateStudents_Click);
            // 
            // grbStudentList
            // 
            this.grbStudentList.BackColor = System.Drawing.Color.Gray;
            this.grbStudentList.Controls.Add(this.MyListView);
            this.grbStudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbStudentList.Location = new System.Drawing.Point(-3, 487);
            this.grbStudentList.Name = "grbStudentList";
            this.grbStudentList.Size = new System.Drawing.Size(1802, 333);
            this.grbStudentList.TabIndex = 7;
            this.grbStudentList.TabStop = false;
            this.grbStudentList.Text = "Students List";
            // 
            // cboView
            // 
            this.cboView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboView.FormattingEnabled = true;
            this.cboView.Items.AddRange(new object[] {
            "Details",
            "LargeIcon",
            "SmallIcon",
            "List",
            "Tile"});
            this.cboView.Location = new System.Drawing.Point(97, 413);
            this.cboView.Name = "cboView";
            this.cboView.Size = new System.Drawing.Size(151, 33);
            this.cboView.TabIndex = 12;
            this.cboView.SelectedIndexChanged += new System.EventHandler(this.cboView_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(13, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "View : ";
            // 
            // grbID_Card
            // 
            this.grbID_Card.BackColor = System.Drawing.Color.Teal;
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
            this.grbID_Card.Location = new System.Drawing.Point(897, 68);
            this.grbID_Card.Name = "grbID_Card";
            this.grbID_Card.Size = new System.Drawing.Size(925, 300);
            this.grbID_Card.TabIndex = 13;
            this.grbID_Card.TabStop = false;
            this.grbID_Card.Text = "ID Card";
            // 
            // picIdCard
            // 
            this.picIdCard.Image = ((System.Drawing.Image)(resources.GetObject("picIdCard.Image")));
            this.picIdCard.Location = new System.Drawing.Point(6, 29);
            this.picIdCard.Name = "picIdCard";
            this.picIdCard.Size = new System.Drawing.Size(202, 271);
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
            // btnShowCard
            // 
            this.btnShowCard.BackColor = System.Drawing.Color.LightGray;
            this.btnShowCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCard.Location = new System.Drawing.Point(606, 413);
            this.btnShowCard.Name = "btnShowCard";
            this.btnShowCard.Size = new System.Drawing.Size(248, 49);
            this.btnShowCard.TabIndex = 14;
            this.btnShowCard.Text = "Show Card";
            this.btnShowCard.UseVisualStyleBackColor = false;
            this.btnShowCard.Click += new System.EventHandler(this.btnShowCard_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmStudentsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1845, 823);
            this.Controls.Add(this.btnShowCard);
            this.Controls.Add(this.grbID_Card);
            this.Controls.Add(this.cboView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grbStudentList);
            this.Controls.Add(this.btnGenerateStudents);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grbStudent);
            this.MaximizeBox = false;
            this.Name = "frmStudentsManagement";
            this.Text = "frmStudentsManagement";
            this.grbStudent.ResumeLayout(false);
            this.grbStudent.PerformLayout();
            this.grbGender.ResumeLayout(false);
            this.grbGender.PerformLayout();
            this.grbStudentList.ResumeLayout(false);
            this.grbID_Card.ResumeLayout(false);
            this.grbID_Card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIdCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView MyListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox grbStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnGenerateStudents;
        private System.Windows.Forms.GroupBox grbStudentList;
        private System.Windows.Forms.ComboBox cboView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox grbID_Card;
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
        private System.Windows.Forms.PictureBox picIdCard;
        private System.Windows.Forms.Button btnShowCard;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}


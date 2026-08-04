using Students_Management.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Students_Management
{
    public partial class frmStudentsManagement : Form
    {
        public frmStudentsManagement()
        {
            InitializeComponent();
        }

        void ClearInputs()
        {
            txtID.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            cboGrade.Text = string.Empty;
            txtID.Focus();
        }

        bool isEditMode = false;

        void UpdateStudentData(ListViewItem item)
        {

            item.Text = txtID.Text;
            item.SubItems[1].Text = txtName.Text;
            item.SubItems[2].Text = txtEmail.Text;
            item.SubItems[3].Text = txtPhone.Text;
            item.SubItems[4].Text = cboGrade.Text;

            if(rdoMale.Checked)
            {
                item.SubItems[5].Text = rdoMale.Text;
                item.ImageIndex = 0;
            }
            else
            {
                item.SubItems[5].Text = rdoFemale.Text;
                item.ImageIndex = 1;
            }


            ClearInputs();

        }

        bool IsAnyGenderSelected()
        {
            if ((rdoMale.Checked))
                return true;

            if ((rdoFemale.Checked))
                return true;


            return false;
        }

        bool AreStudentInputsValid()
        {

            if(string.IsNullOrEmpty(txtID.Text)|| string.IsNullOrEmpty(txtName.Text)||
               !txtPhone.MaskCompleted || string.IsNullOrEmpty(txtEmail.Text)||
               string.IsNullOrEmpty(cboGrade.Text)|| !IsAnyGenderSelected())
            {
                return false;
            }
            return true;
        }


        Control FindFirstMissingStudentInput()
        {

            if (string.IsNullOrEmpty(txtID.Text)) return txtID;
            if (string.IsNullOrEmpty(txtName.Text)) return txtName;
            if (string.IsNullOrEmpty(txtEmail.Text)) return txtEmail;
            if (!txtPhone.MaskCompleted) return txtPhone;
            if (!IsAnyGenderSelected()) return grbGender;
            if (string.IsNullOrEmpty(cboGrade.Text)) return cboGrade;
           


            return null;
        }

        void ChangeControlColore(Control control,Color color)
        {
         
            control.BackColor = color;
        }


        void ShowNotify(string title,string text)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = title;
            notifyIcon1.BalloonTipText = text;
            notifyIcon1.ShowBalloonTip(1000);
        }


        Control FirstMissingInput;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if(FirstMissingInput!=null)
            {
                if (FirstMissingInput != grbGender)
                {
                    ChangeControlColore(FirstMissingInput, Color.White);
                }

                FirstMissingInput = null;
            }

             if (!AreStudentInputsValid())
             {
                MessageBox.Show(
                               "Please enter all student information before continuing.",
                               "Missing Information",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning
                               );

                 FirstMissingInput = FindFirstMissingStudentInput();

                if (FirstMissingInput != grbGender)
                {
                    ChangeControlColore(FirstMissingInput, Color.Red);
                    FirstMissingInput.Focus();
                }

                return;
             }
            
              

            if (isEditMode)
            {

                UpdateStudentData(MyListView.SelectedItems[0]);

                btnAdd.Text = "Add";
                isEditMode = false;


                ShowNotify("Student Updated", "The student information has been updated successfully");


                return;
            }


            

            txtID.Focus();
            ListViewItem item = new ListViewItem(txtID.Text);
            item.SubItems.Add(txtName.Text);
            item.SubItems.Add(txtEmail.Text);
            item.SubItems.Add(txtPhone.Text);
            item.SubItems.Add(cboGrade.Text);

            if (rdoMale.Checked)
            {
                item.SubItems.Add(rdoMale.Text);
                item.ImageIndex = 0;
            }
            else
            {
                item.SubItems.Add(rdoFemale.Text);
                item.ImageIndex = 1;
            }


            MyListView.Items.Add(item);



            ClearInputs();

            ShowNotify("Student Added", "The student has been added successfully.");
        }


        bool HasStudentsInListView()
        {
            return (MyListView.Items.Count != 0);
        }

        bool HasSelectedStudent()
        {
            return (MyListView.SelectedItems.Count != 0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!CheckStudentListAndSelection("Delete"))
                return;


            MyListView.Items.Remove(MyListView.SelectedItems[0]);


            ShowNotify("Student Deleted", "The student has been deleted successfully");
        }

        public static int NumOfStudents = 0;
        private void btnGenerateStudents_Click(object sender, EventArgs e)
        {
            InputBox input = new InputBox();
            input.ShowDialog();

            if (NumOfStudents == 0)
            {
                ShowMessage("Operation cancelled. Please try again.", "Operation Cancelled", MessageBoxIcon.Question);

                return;
            }



            Random random = new Random();

            for (int i = 1; i <= NumOfStudents; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());

                item.SubItems.Add("Person" + i.ToString());
                item.SubItems.Add("Person" + i.ToString() + "@gmail.com");
                item.SubItems.Add("010000000" + i);


                int index = random.Next(cboGrade.Items.Count);
                item.SubItems.Add(cboGrade.Items[index].ToString());


                if (i % 2 == 0)
                {
                    rdoFemale.Checked = true;
                    item.SubItems.Add(rdoFemale.Text);

                    item.ImageIndex = 1;
                }
                else
                {
                    rdoMale.Checked = true;
                    item.SubItems.Add(rdoMale.Text);

                    item.ImageIndex = 0;
                }

                MyListView.Items.Add(item);
            }


            ShowNotify("Students Generated", "Students have been generated successfully");
        }

      

        private void cboView_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboView.Text.ToLower())
            {
                case "details":
                    MyListView.View = View.Details;
                 break;

                case "largeicon":
                    MyListView.View = View.LargeIcon;
                    break;

                case "smallicon":
                    MyListView.View = View.SmallIcon;
                    break;
                case "list":
                    MyListView.View = View.List;
                    break;
                case "tile":
                    MyListView.View = View.Tile;
                    break;


            }


        }


        Image GetStudentImageByGender(string Person)
        {

            if (Person.ToLower() == "male")
            {
                return Resources.vecteezy_happy_schoolboy_with_backpack_and_book_ready_for_school_56613837;
            }
            else
            {
                return Resources.vecteezy_watercolor_illustration_of_happy_girl_with_student_54315921;
            }

        }

        void ShowMessage(string message,string title, 
            MessageBoxIcon messageBoxIcon= MessageBoxIcon.Warning, MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK)
        {
            MessageBox.Show(message, title, messageBoxButtons, messageBoxIcon);                    
        }


        bool CheckStudentListAndSelection(string Action)
        {
            if (!HasStudentsInListView())
            {
                ShowMessage("There are no students in the list to " + Action + ". Please add at least one student first."
                    , "No Students Found");

                return false;
            }


            if (!HasSelectedStudent())
            {
                ShowMessage("Please select a student to " + Action,
                         "No Student Selected");

                return false;
            }


            return true;
        }




    

        private void btnEdit_Click(object sender, EventArgs e)
        {

            

            if (!CheckStudentListAndSelection("Edit"))
                return;

            isEditMode = true;

            frmIdCard frmIdCard = new frmIdCard();
            frmIdCard.ShowDialog();

            ShowMessage("The student is now in Edit Mode. Please make your changes and click Update to save them.",
                        "Edit Mode",MessageBoxIcon.Information);


            btnAdd.Text = "Update";
            txtID.Focus();

        }




        public static string Id, NameStudent, Email, Phone, Grade, Gender;
        public static Image Person;


        void AssignValues(string _Id, string _Name, string _Email, string _Phone, string _Grade,
            string _Gender,Image _person)
        {
            Id= _Id;
            NameStudent = _Name;
            Email= _Email;
            Phone= _Phone;
            Grade= _Grade;
            Gender= _Gender;
            Person = _person;
        }


        private void MyListView_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            if (MyListView.SelectedItems.Count == 0)
                return;

            ListViewItem item = MyListView.SelectedItems[0];

            ShowtxtID.Text= item.Text;
            ShowtxtName.Text= item.SubItems[1].Text;
            ShowtxtEmail.Text = item.SubItems[2].Text;
            ShowtxtPhone.Text = item.SubItems[3].Text;
            ShowtxtGrade.Text = item.SubItems[4].Text;
            ShowtxtGender.Text = item.SubItems[5].Text;

            picIdCard.Image = GetStudentImageByGender(ShowtxtGender.Text);


            AssignValues(ShowtxtID.Text, ShowtxtName.Text, ShowtxtEmail.Text, ShowtxtPhone.Text
                , ShowtxtGrade.Text, ShowtxtGender.Text, picIdCard.Image);

        }

        private void btnShowCard_Click(object sender, EventArgs e)
        {
            if (!CheckStudentListAndSelection(" Show Card"))
                return;


            frmIdCard frm = new frmIdCard();
            frm.Show();
        }
    }
}

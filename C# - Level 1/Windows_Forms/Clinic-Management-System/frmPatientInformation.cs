using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Clinic_Management_System
{
    public partial class frmPatientInformation : Form
    {
        public frmPatientInformation()
        {
            InitializeComponent();
        }


        private void btnPrevious_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            frm.Show();
            this.Hide();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation"
                   , MessageBoxButtons.OKCancel) == DialogResult.OK) 
            {
                this.Close();
            }

        }

        bool IsTextBoxEmpty(TextBox txtName)
        {
            return txtName.Text == "";
        }

        void HighlightTextBox(TextBox txtName,Color color)
        {
            txtName.BackColor = color;
        }

        void HighlightGroupBox(GroupBox groupName,Color color)
        {
            groupName.BackColor = color;
        }
        void ShowValidationMessage(string Message)
        {
            MessageBox.Show(Message, "Missing Information");
        }

        bool ValidateTextBox(TextBox txtName, string Message)
        {

           if( IsTextBoxEmpty(txtName))
           {
                HighlightTextBox(txtName,Color.Red);
                txtName.Focus();
                ShowValidationMessage(Message);
                return false;
           }
           else
           {
               HighlightTextBox(txtName, Color.White);
           }


            return true;
        }

        bool IsRadioButtonUnchecked(RadioButton rdoName)
        {
            return !rdoName.Checked;
        }

        bool ValidateGenderSelection(RadioButton rdo1Name, RadioButton rdo2Name,GroupBox grpName,string Message)
        {
            if(IsRadioButtonUnchecked(rdo1Name) && IsRadioButtonUnchecked(rdo2Name))
            {
                HighlightGroupBox(grpName, Color.Red);
                rdo1Name.Focus();
                ShowValidationMessage(Message);
                return false;
            }
            else
            {
                HighlightGroupBox(grpName, Color.White);
            }

                return true;
        }

        bool ValidateForm()
        {

            if (!ValidateTextBox(tboxFullName, "Please enter the patient's full name."))
                return false;

            if (!ValidateTextBox(tboxPhone, "Please enter the phone number."))
                return false;

            if (!ValidateTextBox(tboxID, "Please enter the National ID."))
                return false;

            if (!ValidateTextBox(tboxAddress, "Please enter the address."))
                return false;


            if (!ValidateGenderSelection(rdoMale, rdoFemale, grpGender, "Please select the patient's gender."))
                return false;

            if (!ValidateDateOfBirth(dtkDateOfBirth))
                return false;






            return true;
        }



        private void btnNext_Click(object sender, EventArgs e)
        {

            if (!ValidateForm())
                return;
           


            frmAppointment frm = new frmAppointment();
            frm.Show();
            this.Hide();

        }


        bool ValidateDateOfBirth(DateTimePicker dateTimeName)
        {
            if(dateTimeName.Value.Date>= DateTime.Today)
            {
                MessageBox.Show(
                                 "The date of birth must be earlier than today.",
                                 "Invalid Date of Birth",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);

                dateTimeName.Focus();
                return false;

            }

            return true;
        }

       
    }
}

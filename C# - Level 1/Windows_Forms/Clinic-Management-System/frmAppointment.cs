using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Clinic_Management_System
{
    public partial class frmAppointment : Form
    {
        public frmAppointment()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      



        private void frmAppointment_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to SmileCare Clinic");
            mcAppointment.MinDate = DateTime.Today;
        }

        private void cbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {

            clbServices.Items.Clear();


            switch (cbDoctors.SelectedItem.ToString())
            {
                case "Dr.Ahmed Hassan":
                    clbServices.Items.Add("Teeth Cleaning");
                    clbServices.Items.Add("Teeth Whitening");
                    clbServices.Items.Add("Dental Checkup");
                    clbServices.Items.Add("Dental X-Ray");
                    break;

                case "Dr.Mohamed Ali":
                    clbServices.Items.Add("Dental Filling");
                    clbServices.Items.Add("Root Canal Treatment");
                    clbServices.Items.Add("Tooth Extraction");
                    clbServices.Items.Add("Emergency Dental Care");
                    break;

                case "Dr.Sara Ibrahim":
                    clbServices.Items.Add("Dental Implant");
                    clbServices.Items.Add("Dental Crown");
                    clbServices.Items.Add("Dental Bridge");
                    clbServices.Items.Add("Cosmetic Dentistry");
                    break;

                case "Dr.Omar Khaled":
                    clbServices.Items.Add("Orthodontic Consultation");
                    clbServices.Items.Add("Braces Installation");
                    clbServices.Items.Add("Braces Adjustment");
                    clbServices.Items.Add("Retainer Check");
                    break;


            }
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblShowTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void llClinicWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkClinicWebsite.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.asnanonline.com/");
        }


        void ShowValidationMessage(string Message)
        {
            MessageBox.Show(Message, "Missing Information");
        }

        void HighlightCheckedListBox(CheckedListBox checkedListName, Color color)
        {
            checkedListName.BackColor = color;
        }

        bool ValidateComboBox(ComboBox cbName,string Message)
        {
            if (cbName.SelectedIndex != -1)
            {
           
                return true;
            }
            else
            {
              
                cbName.Focus();
                ShowValidationMessage(Message);
                return false;
            }
            
        }

        bool ValidateCheckedListBox(CheckedListBox checkedListName, string Message)
        {
            if(checkedListName.CheckedItems.Count>0)
            {
                HighlightCheckedListBox(checkedListName, Color.White);
                return true;
            }
            else
            {
                HighlightCheckedListBox(checkedListName, Color.Red);
                checkedListName.Focus();
                ShowValidationMessage(Message);
                return false;
            }
        }


       bool ValidateForm()
        {

            if (!ValidateComboBox(cbDoctors, "Please select a doctor before continuing."))
                return false;

            if(!ValidateCheckedListBox(clbServices, "Please select at least one medical service."))
                return false;



            return true;
        }


        void ShowNotification()
        {
            notifyClinic.Icon = SystemIcons.Application;
            notifyClinic.BalloonTipIcon = ToolTipIcon.Info;
            notifyClinic.BalloonTipTitle= "Appointment Saved";
            notifyClinic.BalloonTipText = "Your appointment has been successfully saved.";
            notifyClinic.ShowBalloonTip(30);
        }



       

      

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!ValidateForm())
                return;


            if (chkNotifications.Checked)
            {
                ShowNotification();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            frmPatientInformation frm = new frmPatientInformation();
            frm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation"
                , MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}

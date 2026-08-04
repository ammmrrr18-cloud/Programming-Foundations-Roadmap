using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Management
{
    public partial class frmIdCard : Form
    {
        public frmIdCard()
        {
            InitializeComponent();
        }

       
        private void frmIdCard_Load(object sender, EventArgs e)
        {
            ShowtxtID.Text = frmStudentsManagement.Id;
            ShowtxtName.Text = frmStudentsManagement.NameStudent;
            ShowtxtEmail.Text = frmStudentsManagement.Email;
            ShowtxtGrade.Text = frmStudentsManagement.Grade;
            ShowtxtPhone.Text = frmStudentsManagement.Phone;
            ShowtxtGender.Text = frmStudentsManagement.Gender;
            picIdCard.Image = frmStudentsManagement.Person;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

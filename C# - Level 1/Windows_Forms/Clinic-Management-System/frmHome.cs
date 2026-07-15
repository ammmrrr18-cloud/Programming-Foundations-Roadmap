using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

       

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            frmPatientInformation frm = new frmPatientInformation();
            frm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

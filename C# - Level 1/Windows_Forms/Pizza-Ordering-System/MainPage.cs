using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            Form frm = new AboutUsPage();
            frm.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form frm = new MenuePage();
            frm.ShowDialog();
        }
    }
}

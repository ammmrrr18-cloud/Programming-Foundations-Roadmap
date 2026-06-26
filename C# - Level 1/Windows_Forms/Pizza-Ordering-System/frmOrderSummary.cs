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
    public partial class frmOrderSummary : Form
    {
        public frmOrderSummary()
        {
            InitializeComponent();
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            Form frm = new MenuePage();
            frm.Show();
            this.Close(); 

        }


        private void frmOrderSummary_Load(object sender, EventArgs e)
        {
            lablSize.Text = MenuePage.Size;
            lablCurst.Text = MenuePage.CrustType;
            lablWhereToEat.Text = MenuePage.WhereToEat;
            lablTopping.Text = frmToppings.Toppings;
            lablMoney.Text = frmToppings.FinalTotalPrices;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if(btnConfirm.Text == "Reset Order")
            {
                Form frm = new MenuePage();
                this.Hide();
                frm.ShowDialog();
                this.Close();
                return;
            }




         if(   MessageBox.Show("Are you sure you want to confirm this order?", "Confirm Order", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button2)==DialogResult.Yes)

            {
                MessageBox.Show("Order Placed Successfully!");

                btnBackToMainPage.Enabled = false;
                btnBackToMainPage.BackColor = Color.White;
                
                btnConfirm.Text = "Reset Order";
                btnConfirm.ForeColor = Color.Orange;

            }
            else
            {
                MessageBox.Show("Order Cancelled.");
            }


            

        }
    }
}

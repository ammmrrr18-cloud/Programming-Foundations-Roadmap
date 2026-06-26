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
    public partial class MenuePage : Form
    {
        public static string TotalMenueSizePizzaPrice = "0";
        public static string Size = "Small";
        public static string CrustType = "Thin Crust";
        public static string WhereToEat = "Eat In";


        public MenuePage()
        {
            InitializeComponent();
        }

      

        public float LoadDefulatePrices()
        {
            float TotalPrices = 0;
            TotalPrices = TotalPrices + Convert.ToSingle(rdoSmallSize.Tag);
            TotalPrices+= Convert.ToSingle(rdoThin.Tag);
            TotalPrices += Convert.ToSingle(rdoEatIn.Tag);

            return TotalPrices;

        }


        private void MenuePage_Load(object sender, EventArgs e)
        {
            float TotalPrices = LoadDefulatePrices();
            labelMoney.Text = TotalPrices.ToString();


            TotalMenueSizePizzaPrice = labelMoney.Text;
        }

        private void btnMenuePrices_Click(object sender, EventArgs e)
        {
            Form frm = new frmPriceList();
            frm.Show();
        }


        public float UpdateTotalMenuSizePrices()
        {
            float TotalPrices = 0;
            

            if(rdoSmallSize.Checked)
            {
                TotalPrices += Convert.ToSingle(rdoSmallSize.Tag);
                Size = "Small";
            }
            else if(rdoMedSize.Checked)
            {
                TotalPrices += Convert.ToSingle(rdoMedSize.Tag);
                Size = "Medium";
            }
            else if(rdoLargeSize.Checked)
            {
                TotalPrices += Convert.ToSingle(rdoLargeSize.Tag);
                Size = "Large";
            }


            if(rdoThin.Checked)
            {
                TotalPrices += Convert.ToSingle(rdoThin.Tag);
                CrustType = "Thin Crust";
            }
            else if (rdoThick.Checked)
            {
                TotalPrices += Convert.ToSingle(rdoThick.Tag);
                CrustType = "Thick Crust";
            }


            if (rdoEatIn.Checked)
            {
                TotalPrices += Convert.ToSingle(rdoEatIn.Tag);
                WhereToEat = "Eat In";
            }
            else if (rdoTakeOut.Checked)
            {
                TotalPrices += Convert.ToSingle(rdoTakeOut.Tag);
                WhereToEat = "Take Out";
            }




            return TotalPrices;
        }

        private void rdoSmallSize_CheckedChanged(object sender, EventArgs e)
        {

            float Price = UpdateTotalMenuSizePrices();

            labelMoney.Text = Price.ToString();
        }

        private void rdoMedSize_CheckedChanged(object sender, EventArgs e)
        {
            float Price = UpdateTotalMenuSizePrices();

            labelMoney.Text = Price.ToString();
        }


        private void rdoLargeSize_CheckedChanged(object sender, EventArgs e)
        {
            float Price = UpdateTotalMenuSizePrices();

            labelMoney.Text = Price.ToString();
        }

        private void rdoThin_CheckedChanged(object sender, EventArgs e)
        {
            float Price = UpdateTotalMenuSizePrices();

            labelMoney.Text = Price.ToString();
        }

        private void rdoThick_CheckedChanged(object sender, EventArgs e)
        {
            float Price = UpdateTotalMenuSizePrices();

            labelMoney.Text = Price.ToString();
        }

        private void rdoEatIn_CheckedChanged(object sender, EventArgs e)
        {
            float Price = UpdateTotalMenuSizePrices();

            labelMoney.Text = Price.ToString();
        }

        private void rdoTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            float Price = UpdateTotalMenuSizePrices();

            labelMoney.Text = Price.ToString();
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            TotalMenueSizePizzaPrice = labelMoney.Text;
            Form frm = new frmToppings();
            frm.ShowDialog();
        }
    }
}

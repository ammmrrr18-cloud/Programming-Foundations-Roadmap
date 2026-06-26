using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class frmToppings : Form
    {

        public static string Toppings = "No Toppings";
        public static string FinalTotalPrices = "";

        public frmToppings()
        {
            InitializeComponent();
        }
        private void frmToppings_Load(object sender, EventArgs e)
        {
            labMoney.Text = MenuePage.TotalMenueSizePizzaPrice;
        }
        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
  
        public float UpdateTotalMenuToppingPrices()
        {
            float TotalPrices = 0;
            Toppings = "";

            if (chkOnions.Checked)
            {
                TotalPrices +=Convert.ToSingle( chkOnions.Tag);
                Toppings += "Onions, ";
            }
             if(chkTomatoes.Checked)
            {
                TotalPrices += Convert.ToSingle(chkTomatoes.Tag);
                Toppings += "Tomatoes, ";
            }
             if(chkJalapeno.Checked)
            {
                TotalPrices += Convert.ToSingle(chkJalapeno.Tag);
                Toppings += "Jalapeno, ";
            }
             if (chkMushroom.Checked)
            {
                TotalPrices += Convert.ToSingle(chkMushroom.Tag);
                Toppings += "Mushroom, ";
            }
             if(chkBlackOlives.Checked)
            {
                TotalPrices += Convert.ToSingle(chkBlackOlives.Tag);
                Toppings += "BlackOlives, ";
            }
             if (chkGreenPepper.Checked)
            {
                TotalPrices += Convert.ToSingle(chkGreenPepper.Tag);
                Toppings += "GreenPepper, ";
            }



            if(chkCheddarCheese.Checked)
            {
                TotalPrices += Convert.ToSingle(chkCheddarCheese.Tag);
                Toppings += "CheddarCheese, ";
            }
             if (chkMozzarella.Checked)
            {
                TotalPrices += Convert.ToSingle(chkMozzarella.Tag);
                Toppings += "Mozzarella, ";
            }
             if (chkCreamCheese.Checked)
            {
                TotalPrices += Convert.ToSingle(chkCreamCheese.Tag);
                Toppings += "CreamCheese, ";
            }

             if(Toppings.EndsWith(", "))
            {
                Toppings = Toppings.Substring(0, Toppings.Length - 2);
            }


            return TotalPrices;
        }
      
        public float TotalPricesResult(float PrevSizeMenuePrice,float MenueToppingPrice)
        {

            return PrevSizeMenuePrice + MenueToppingPrice;
        }

        private void chkOnions_CheckedChanged(object sender, EventArgs e)
        {
            float ToppingPrices = UpdateTotalMenuToppingPrices();
            float TotalPrices = TotalPricesResult(Convert.ToSingle(MenuePage.TotalMenueSizePizzaPrice), ToppingPrices);
            labMoney.Text = TotalPrices.ToString();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            float ToppingPrices = UpdateTotalMenuToppingPrices();
            float TotalPrices = TotalPricesResult(Convert.ToSingle(MenuePage.TotalMenueSizePizzaPrice), ToppingPrices);
            labMoney.Text = TotalPrices.ToString();
        }

        private void chkJalapeno_CheckedChanged(object sender, EventArgs e)
        {
            float ToppingPrices = UpdateTotalMenuToppingPrices();
            float TotalPrices = TotalPricesResult(Convert.ToSingle(MenuePage.TotalMenueSizePizzaPrice), ToppingPrices);
            labMoney.Text = TotalPrices.ToString();
        }

        private void chkMushroom_CheckedChanged(object sender, EventArgs e)
        {
            float ToppingPrices = UpdateTotalMenuToppingPrices();
            float TotalPrices = TotalPricesResult(Convert.ToSingle(MenuePage.TotalMenueSizePizzaPrice), ToppingPrices);
            labMoney.Text = TotalPrices.ToString();
        }

        private void chkBlackOlives_CheckedChanged(object sender, EventArgs e)
        {
            float ToppingPrices = UpdateTotalMenuToppingPrices();
            float TotalPrices = TotalPricesResult(Convert.ToSingle(MenuePage.TotalMenueSizePizzaPrice), ToppingPrices);
            labMoney.Text = TotalPrices.ToString();
        }

        private void chkGreenPepper_CheckedChanged(object sender, EventArgs e)
        {
            float ToppingPrices = UpdateTotalMenuToppingPrices();
            float TotalPrices = TotalPricesResult(Convert.ToSingle(MenuePage.TotalMenueSizePizzaPrice), ToppingPrices);
            labMoney.Text = TotalPrices.ToString();
        }

        private void chkCheddarCheese_CheckedChanged(object sender, EventArgs e)
        {
            float ToppingPrices = UpdateTotalMenuToppingPrices();
            float TotalPrices = TotalPricesResult(Convert.ToSingle(MenuePage.TotalMenueSizePizzaPrice), ToppingPrices);
            labMoney.Text = TotalPrices.ToString();
        }

        private void chkMozzarella_CheckedChanged(object sender, EventArgs e)
        {
            float ToppingPrices = UpdateTotalMenuToppingPrices();
            float TotalPrices = TotalPricesResult(Convert.ToSingle(MenuePage.TotalMenueSizePizzaPrice), ToppingPrices);
            labMoney.Text = TotalPrices.ToString();
        }

        private void chkCreamCheese_CheckedChanged(object sender, EventArgs e)
        {
            float ToppingPrices = UpdateTotalMenuToppingPrices();
            float TotalPrices = TotalPricesResult(Convert.ToSingle(MenuePage.TotalMenueSizePizzaPrice),ToppingPrices);
            labMoney.Text = TotalPrices.ToString();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            FinalTotalPrices = labMoney.Text;
            Form frm = new frmOrderSummary();
            frm.ShowDialog();
        }

       
    }
}

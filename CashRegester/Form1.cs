using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Phoenix Keeling, November 26 2020

namespace CashRegester
{
    public partial class Form1 : Form
    {
        Double DFDDP = 12.49;
        Double GIAB = 5.99;
        Double FFSDM = 21.99;
        Double noDFDDP;
        Double noGIAB;
        Double noFFSDM;
        Double DFDDPPrice;
        Double GIAPPrice;
        Double FFSDMPrice;
        Double SubTotal;
        Double Taxes = 0.13;
        Double Tax;
        Double Total;
        Double Bill;

        public Form1()
        {
            InitializeComponent();
        }

        public double ChangeAmmount1 { get; set; }
        public double ChangeAmmount2 { get => ChangeAmmount1; set => ChangeAmmount1 = value; }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                noDFDDP = Convert.ToDouble(TBPizza.Text);
                noGIAB = Convert.ToDouble(TBBottle.Text);
                noFFSDM = Convert.ToDouble(TBMystery.Text);

                DFDDPPrice = noDFDDP * DFDDP;
                GIAPPrice = noGIAB * GIAB;
                FFSDMPrice = noFFSDM * FFSDM;

                SubTotal = DFDDPPrice + GIAPPrice + FFSDMPrice;
                AlmostTotal.Text = SubTotal.ToString("C");

                Tax = Taxes * SubTotal;
                GShares.Text = Tax.ToString("C");

                Total = Tax + SubTotal;
                RipOff.Text = Total.ToString("C");
            }

            catch
            {
                Order.Text = "Letters Are Not A Way To Count Food Orders";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Bill = Convert.ToDouble(BillBox.Text);
                ChangeAmmount1 = Bill - Total;
                ChangeBox.Text = ChangeAmmount1.ToString("C");
            }
            catch
            {
                Order.Text = "Letters Are Not A PayMent Method";
            }
        }

    }


}








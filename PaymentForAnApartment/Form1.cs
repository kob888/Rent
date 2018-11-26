using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentForAnApartment
{
    public partial class Form1 : Form
    {
        private Water coldWater;
        private Water hotWater;
        private Drainage drainage;

        double HotWaterInvoiceSum;
        double ColdWaterInvoiceSum;
        double TotalInvoiceSum;

        double ColdWaterRate = 21.64;
        double HotWaterRate = 128.74;
        double DrainageRate = 17.1;


        public Form1()
        {
            InitializeComponent();

            HotWaterInvoiceSum = 413.27;
            ColdWaterInvoiceSum = 283.84;
            TotalInvoiceSum = 3719.53;

            hotWaterInvoiceSum.Text = HotWaterInvoiceSum + " р.";
            coldWaterInvoiceSum.Text = ColdWaterInvoiceSum + " р.";
            totalInvoiceSum.Text = TotalInvoiceSum + " р.";
                      
                                    
        }

        public void Calculate()
        {
            coldWaterTotal.Text = coldWater.WaterTotalSum().ToString() + " р.";
            hotWaterTotal.Text = hotWater.WaterTotalSum().ToString() + " р.";
            drainageTotal.Text = drainage.DrainageTotalSum().ToString() + " р.";

            totalSumForWater.Text = TotalSumForWater().ToString() + " р.";
            totalPayment.Text = TotalPayment().ToString() + " р.";
        }

        public double TotalSumForWater()
        {
            return coldWater.WaterTotalSum() + hotWater.WaterTotalSum() + drainage.DrainageTotalSum();
        }

        public double TotalPayment()
        {
            double invoiceWithoutWaterSum = (TotalInvoiceSum - HotWaterInvoiceSum - ColdWaterInvoiceSum) * (int)numberOfMonth.Value;

            return invoiceWithoutWaterSum + TotalSumForWater();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //var InvoiceHotWater = hotWaterInvoiceSum.Text.Replace(" p.", "");
            //var InvoiceColdWater = coldWaterInvoiceSum.Text.Replace(" p.", "");
            //var InvoiceTotalWater = totalInvoiceSum.Text.Replace(" p.", "");
            //HotWaterInvoiceSum = int.Parse(InvoiceHotWater);
            //ColdWaterInvoiceSum = int.Parse(InvoiceColdWater);
            //TotalInvoiceSum = int.Parse(InvoiceTotalWater);

            var LastColdWaterIndicator = int.Parse(lastColdWaterIndicator.Text);
            var ColdWaterIndicator = int.Parse(coldWaterIndicator.Text);
            var HotWaterIndicator = int.Parse(hotWaterIndicator.Text);
            var LastHotWaterIndicator = int.Parse(lastHotWaterIndicator.Text);

            coldWater = new Water(LastColdWaterIndicator, ColdWaterIndicator, ColdWaterRate);
            hotWater = new Water(LastHotWaterIndicator, HotWaterIndicator, HotWaterRate);
            drainage = new Drainage(hotWater.WaterConsumptionPerMonth(), coldWater.WaterConsumptionPerMonth(), DrainageRate);

            Calculate();
        }

        private void changeValueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (changeValueCheckBox.Checked)
            {
                hotWaterInvoiceSum.Enabled = true;
                coldWaterInvoiceSum.Enabled = true;
                totalInvoiceSum.Enabled = true;
            }
            else
            {
                hotWaterInvoiceSum.Enabled = false;
                coldWaterInvoiceSum.Enabled = false;
                totalInvoiceSum.Enabled = false;
            }
        }
    }
}

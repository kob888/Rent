using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private ReceiptModel data;

        public Form1()
        {
            InitializeComponent();
            
            using (StreamReader reader = new StreamReader(@"Data.json"))
            {
                var json = reader.ReadToEnd();
                data = JsonConvert.DeserializeObject<ReceiptModel>(json);
            }

            hotWaterInvoiceSum.Text = data.HotWaterInvoiceSum + " р.";
            coldWaterInvoiceSum.Text = data.ColdWaterInvoiceSum + " р.";
            totalInvoiceSum.Text = data.TotalInvoiceSum + " р.";
            lastColdWaterIndicator.Text = data.LastColdWaterIndicator.ToString();
            lastHotWaterIndicator.Text = data.LastHotWaterIndicator.ToString();
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
                //hotWaterInvoiceSum.Enabled = true;
                //coldWaterInvoiceSu.Enabled = true;
               // totalInvoiceSum.Enabled = true;
            }
            else
            {
                //hotWaterInvoiceSum.Enabled = false;
                //coldWaterInvoiceSu.Enabled = false;
                //totalInvoiceSum.Enabled = false;
            }
        }

        private void changeReceiptButton_Click(object sender, EventArgs e)
        {
            ReceiptForm receiptForm = new ReceiptForm();
            receiptForm.Show(this);
        }
    }
}

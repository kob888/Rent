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
    public partial class ReceiptForm : Form
    {
        private ReceiptModel data;

        public ReceiptForm()
        {
            InitializeComponent();

            //using (StreamReader reader = new StreamReader("Data.json"))
            //{
            //    var json = reader.ReadToEnd();
            //    data = JsonConvert.DeserializeObject<ReceiptModel>(json);
            //}

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("Data.json");
            var json = File.ReadAllText("Data.json");  // reader.ReadToEnd()
            dynamic jsonObj = JsonConvert.DeserializeObject(json);
            reader.Close();
            jsonObj["HotWaterInvoiceSum"] = double.Parse(hotWater.Text);
            jsonObj["ColdWaterInvoiceSum"] = double.Parse(coldWater.Text);
            jsonObj["TotalInvoiceSum"] = double.Parse(totalSum.Text);
            
            string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
            File.WriteAllText("Data.json", output);

            Form1 owningForm = (Form1)this.Owner;
            owningForm.hotWaterInvoiceSum.Text = hotWater.Text;
            owningForm.coldWaterInvoiceSum.Text = coldWater.Text;
            owningForm.totalInvoiceSum.Text = totalSum.Text;

            this.Close();

            //data.HotWaterInvoiceSum = double.Parse(hotWater.Text);
            //data.ColdWaterInvoiceSum = double.Parse(coldWater.Text);
            //data.TotalInvoiceSum = double.Parse(hotWater.Text);

            //string output = JsonConvert.SerializeObject(data, Formatting.Indented);
            //File.WriteAllText("Data.json", output);
        }
    }
}

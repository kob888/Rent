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
    public partial class TariffForm : Form
    {
        public TariffForm()
        {
            InitializeComponent();
        }

        private void tariffButton_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("Data.json");
            var json = File.ReadAllText("Data.json");  // reader.ReadToEnd()
            dynamic jsonObj = JsonConvert.DeserializeObject(json);
            reader.Close();
            jsonObj["HotWaterRate"] = double.Parse(hotWaterTariff.Text);
            jsonObj["ColdWaterRate"] = double.Parse(coldWaterTariff.Text);
            jsonObj["DrainageRate"] = double.Parse(drainageTariff.Text);

            string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
            File.WriteAllText("Data.json", output);

            this.Close();
        }
    }
}

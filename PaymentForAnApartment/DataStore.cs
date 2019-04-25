using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentForAnApartment
{
    class Data
    {
        public double HotWaterInvoiceSum { get; set; }
        public double ColdWaterInvoiceSum { get; set; }
        public double TotalInvoiceSum { get; set; }        
            
        public double ColdWaterRate { get; set; }
        public double HotWaterRate { get; set; }
        public double DrainageRate { get; set; }

        public double LastColdWaterIndicator { get; set; }
        public double LastHotWaterIndicator { get; set; }

    }


    public class DataStore
    {
        string path = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())), "/DataStorage/Data.txt");

        private void Json()
        {
            Data obj = new Data()
            {
                HotWaterInvoiceSum = 413.27,
                ColdWaterInvoiceSum = 283.84,
                TotalInvoiceSum = 3719.53, 
                ColdWaterRate = 21.64,
                HotWaterRate = 128.74,
                DrainageRate = 17.1
            };

            
        }

    }
}

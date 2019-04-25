using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentForAnApartment
{
    public class ReceiptModel
    {
        public double HotWaterInvoiceSum { get; set; }
        public double ColdWaterInvoiceSum { get; set; }
        public double TotalInvoiceSum { get; set; }

        public double ColdWaterRate { get; set; }
        public double HotWaterRate { get; set; }
        public double DrainageRate { get; set; }

        public int LastColdWaterIndicator { get; set; }
        public int LastHotWaterIndicator { get; set; }
    }
}

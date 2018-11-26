using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentForAnApartment
{
    class Drainage
    {
        public double Rate { get; set; }                       // Тариф на водоотвод
        public int HotWaterConsumption { get; private set; }   // Расход горячей воды
        public int ColdWaterConsumption { get; private set; }  // Расход холодной воды

        public Drainage(int hotWaterConsumption, int coldWaterConsumption, double rate)
        {
            HotWaterConsumption = hotWaterConsumption;
            ColdWaterConsumption = coldWaterConsumption;
            Rate = rate;
        }

        public double DrainageTotalSum()
        {
            return (HotWaterConsumption + ColdWaterConsumption) * Rate;
        }
    }
}

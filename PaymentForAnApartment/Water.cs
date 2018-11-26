using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentForAnApartment
{
    class Water
    {
        public double InvoiceSum { get; set; }                 // Сумма по квитанции
        public double Rate { get;  set; }                       // Тариф на воду
        public int IndicatorValue { get;  set; }        // Показания счетчика воды
        public int LastIndicatorValue { get;  set; }    // Показания счетчика воды за прошлый месяц


        public Water(int lastIndicatorValue, int indicatoValue, double rate)
        {
            IndicatorValue = indicatoValue;
            LastIndicatorValue = lastIndicatorValue;
            Rate = rate;
        }

        // Расход воды за месяц
        public int WaterConsumptionPerMonth()
        {
            return IndicatorValue - LastIndicatorValue;
        }

        public double WaterTotalSum()
        {
            return WaterConsumptionPerMonth() * Rate;
        }
    }
}

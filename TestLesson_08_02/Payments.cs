using System;
using System.Collections.Generic;
using System.Text;

namespace TestLesson_08_02
{
    class Payments
    {   // Наличный расчет ежедневный
        public enum tariffsCashMethod 
        {                              // тарифы взрослы, детский, льготный, багаж
            edult = 180,
            child = 0,
            preferential = 0,
            luggage = 0,
        };
        // Безналичный расчет за месяц
        public enum tariffsCashlessMethodPerMonth
        {                              // тарифы взрослы, детский, льготный, багаж
            edult = 7500,
            child = 0,
            preferential = 0,
            luggage = 0,
        };
        // Безналичный расчет ежедневный
        public enum tariffsCashlessMethodEveryday
        {                              // тарифы взрослы, детский, льготный, багаж
            edult = 90,
            child = 0,
            preferential = 0,
            luggage = 90,
        };
    }
}

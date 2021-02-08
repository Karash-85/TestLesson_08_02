using System;
using System.Collections.Generic;
using System.Text;

namespace TestLesson_08_02
{
    public class BusPark
    {
        public int id; // идентификатор автобуса
        public float count; // количество автобусов
        public enum type { Express, City, Shuttle}; // тип автобуса - експресс, городской, пригородный
        public bool entarnet ; // наличие модуля связи для отслеживания        

    }
}

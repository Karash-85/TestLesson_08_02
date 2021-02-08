using System;
using System.Collections.Generic;
using System.Text;

namespace TestLesson_08_02
{
    class Person
    {
        public enum edult { women = 18-61, men = 18-63}; // Взрослый - женщина, мужчина
        public string child; // ребенок
        public enum preferential { pensioner = 63, disabled, military, manyChildren}; // Льготники
    }
}

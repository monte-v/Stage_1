using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_2_Inheritance
{
    internal class Vehicle
    {
        public string Make { get; set; }  // Производитель
        public string Model { get; set; } // Модель
        public int Year { get; set; }      // Год выпуска

        // Метод для получения информации о транспортном средстве
        public virtual string GetInfo()
        {
            return $"Производитель: {Make}, Модель: {Model}, Год: {Year}";
        }
    }
}

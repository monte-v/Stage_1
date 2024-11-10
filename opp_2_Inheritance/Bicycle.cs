using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_2_Inheritance
{
    internal class Bicycle : Vehicle
    {
        // Уникальные свойства для велосипеда
        public bool IsElectric { get; set; } // Является ли велосипед электрическим
        public int WheelSize { get; set; } // Размер колес в дюймах

        // Конструктор
        public Bicycle(string make, string model, int year, bool isElectric, int wheelSize)
        {
            Make = make;
            Model = model;
            Year = year;
            IsElectric = isElectric;
            WheelSize = wheelSize;
        }

        // Метод для получения информации
        public override string GetInfo()
        {
            return base.GetInfo() + $", Электрический: {IsElectric}, Размер колес: {WheelSize} дюймов";
        }
    }
}

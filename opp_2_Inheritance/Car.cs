using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace opp_2_Inheritance
{
    internal class Car : Vehicle
    {
        // Уникальные свойства для автомобиля
        public int NumberOfSeats { get; set; } // Количество мест
        public string TransmissionType { get; set; } // Тип трансмиссии 

        // Конструктор
        public Car(string make, string model, int year, int numberOfSeats, string transmissionType)
        {
            Make = make;
            Model = model;
            Year = year;
            NumberOfSeats = numberOfSeats;
            TransmissionType = transmissionType;
        }

        // Метод для получения информации
        public override string GetInfo()
        {
            return base.GetInfo() + $", Количество мест: {NumberOfSeats}, Тип трансмиссии: {TransmissionType}";
        }
    }
}

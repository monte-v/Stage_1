using solid_2_OCP;

class Program
{
    static void Main(string[] args)
    {
        double originalPrice = 1000; // Оригинальная цена

        // Создаем объекты скидок
        Discount percentageDiscount = new PercentageDiscount(10); // 10% скидка

        // Высчитываем и выводим цену со скидкой
        double priceAfterPercentageDiscount = percentageDiscount.Calculate(originalPrice);

        Console.WriteLine($"Цена после процентной скидки: {priceAfterPercentageDiscount}");
    }
}
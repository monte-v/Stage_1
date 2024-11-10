using solid_2_OCP;

class Program
{
    static void Main(string[] args)
    {
        double originalPrice = 1000; // Оригинальная цена

        // Создаем объекты скидок
        Discount percentageDiscount = new PercentageDiscount(10); // 10% скидка
        Discount fixedAmountDiscount = new FixedAmountDiscount(150); // Фиксированная скидка 150

        // Высчитываем и выводим цену со скидкой
        double priceAfterPercentageDiscount = percentageDiscount.Calculate(originalPrice);
        double priceAfterFixedAmountDiscount = fixedAmountDiscount.Calculate(originalPrice);

        Console.WriteLine($"Цена после процентной скидки: {priceAfterPercentageDiscount}");
        Console.WriteLine($"Цена после фиксированной скидки: {priceAfterFixedAmountDiscount}");
    }
}
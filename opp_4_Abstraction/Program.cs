using opp_4_Abstraction;

class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[]
            {
            new Circle(5),       // Круг с радиусом 5
            new Rectangle(4, 6)  // Прямоугольник с шириной 4 и высотой 6
            };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Площадь: {shape.GetArea()}");
        }
    }
}

using System;

public class Program
{
    // Обобщенный метод для обмена значениями
    public static void Swap<T>(ref T first, ref T second)
    {
        T temp = first;  
        first = second; 
        second = temp;   
    }

    public static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        Console.WriteLine($"До обмена: a = {a}, b = {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"После обмена: a = {a}, b = {b}");

    }
}

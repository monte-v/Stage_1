using System;

public class Program
{
    public static T FindMin<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Массив не должен быть пустым или равным null");
        }

        T min = array[0]; 

        for (int i = 1; i < array.Length; i++)
        {
            // Сравниваем current элемент с текущим минимальным
            if (array[i].CompareTo(min) < 0)
            {
                min = array[i]; 
            }
        }

        return min; 
    }

    public static void Main(string[] args)
    {
        int[] intArray = { 5, 3, 8, 1, 4 };
        Console.WriteLine($"Минимальное значение (int): {FindMin(intArray)}"); 
    }
}

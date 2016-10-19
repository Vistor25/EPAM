using System;
using Logic;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива:");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 1000);
            }
            Array.Sort(array);
            Console.WriteLine("Введите искомый элемент: ");
            int element = int.Parse(Console.ReadLine());
            Console.WriteLine("Индекс элемента:{0}", BinarySearch.BinarySearch_Iter(array, element));
            Console.ReadLine();
        }
    }
}

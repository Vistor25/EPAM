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
            int[] array = BinarySearch.CreationOfArray(size);
            Console.WriteLine("Введите искомый элемент: ");
            int element = int.Parse(Console.ReadLine());
            Console.WriteLine("Индекс элемента:{0}", BinarySearch.BinarySearch_Iter(array, element));
            Console.ReadLine();
        }
    }
}

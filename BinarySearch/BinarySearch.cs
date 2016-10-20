using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logic
{
    public class BinarySearch
    {
        public static int [] CreationOfArray(int size)
        {
            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 1000);
            }
            Array.Sort(array);
            return array;
        }
        public static int BinarySearch_Iter(int[] array, int key)
        {
            int left = 0;
            int right = array.Length;

            while (!(left >= right))
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == key)
                    return mid;

                if (array[mid] > key)
                    right = mid;
                else
                    left = mid + 1;
            }
            return -1;
        }
    }
}

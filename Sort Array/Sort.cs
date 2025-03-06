using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Array
{
    internal class Sort
    {
        public static int temp { get; set; }
        public static void sortArray(int[] numbers, int size, int temp)
        {
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
        }
        public static void printSort(int[]numbers, int size)
        {

        for(int i = 0; i<size; i++)
            {
                Console.Write(numbers[i]+" ");
            }
        }
    }
}

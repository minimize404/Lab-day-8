using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 4];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("Enter the value for element {0}, {1}: ", i + 1, j + 1);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int min = array[0, 0];
            int max = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }

                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("The minimum value in the array is: {0}", min);
            Console.WriteLine("The maximum value in the array is: {0}", max);

            Console.ReadLine();
        }
    }
}

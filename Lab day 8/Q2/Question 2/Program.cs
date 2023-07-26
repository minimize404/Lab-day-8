using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter the array size: ");
                int size = int.Parse(Console.ReadLine());

                Console.WriteLine();

                int[] array = new int[size];

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("Enter the value for element {0}: ", i + 1);
                    array[i] = int.Parse(Console.ReadLine());
                }

                int min = array[0];
                int max = array[0];

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }

                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }

                Console.WriteLine();

                Console.WriteLine("The minimum value in the array is: {0}", min);
                Console.WriteLine("The maximum value in the array is: {0}", max);

                Console.ReadLine();
            }
        }
    }
}

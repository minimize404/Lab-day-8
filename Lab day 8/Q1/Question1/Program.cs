using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] array = new int[10];

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("Enter the value for element {0}: ", i + 1);
                    array[i] = int.Parse(Console.ReadLine());
                }

                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }

                Console.WriteLine();

                Console.WriteLine("The scalar/ linear summation of the array is: {0}", sum);

                Console.ReadLine();
            }
        }
    }
}

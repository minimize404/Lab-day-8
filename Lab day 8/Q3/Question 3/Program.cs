using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array size: ");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[] numbers = new int[size];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter the value for element {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();    

            Console.WriteLine("Original array:");
            PrintArray(numbers);

            Array.Sort(numbers);

            Console.WriteLine("\nArray sorted in ascending order:");
            PrintArray(numbers);

            Array.Reverse(numbers);

            Console.WriteLine("\nArray sorted in descending order:");
            PrintArray(numbers);

            Console.ReadLine();
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}

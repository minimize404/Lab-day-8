using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] matrix2 = new int[2, 2] { { 5, 6 }, { 7, 8 } };

            int[,] product = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    product[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        product[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0} ", product[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

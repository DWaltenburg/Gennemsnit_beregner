using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gennemsnit_beregner
{
    internal class Program
    {
        static int[,] array = {{18,43},{18,41},{16,48},{18,44},
            {29,42},{26,44},{18,43},{20,45},{17,42},{17,43},
            {39,50},{21,43},{25,42},{30,42},{17,46},{57,45}};
        
        static void Main()
        {
            Console.WriteLine("Gennemsnit alder: " + GennemsnitAlder(array));
            Console.WriteLine("Gennemsnit skostørrelse: " + GennemsnitSko(array));
            Console.ReadLine();
        }

        static double GennemsnitAlder(int[,] array)
        {
            double sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, 0];
            }

            return sum/array.GetLength(0);
        }
        static double GennemsnitSko(int[,] array)
        {
            double sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, 1];
            }
            return sum/array.GetLength(0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightedMean
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] x = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int[] w = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            float result = Calculation(n, x, w);
            Console.WriteLine(string.Format("{0:0.##}", result));
            Console.Read();
        }

        static float Calculation(int n, int[] x, int[] w)
        {
            int under = 0, upper = 0;
            float result;

            for (int i = 0; i < n; i++)
            {
                under += w[i];
            }


            for (int j = 0; j < n; j++)
            {
                upper += x[j] * w[j];
            }


            result = (float)upper / under;
            return result;
        }
    }
}

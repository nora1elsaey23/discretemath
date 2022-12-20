using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum,j;
            Console.WriteLine("Enter start number");
            Console.WriteLine("Enter end number");
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (j = start; j <= end; j++)
            {
                sum=0;
                {
                    for (int i = 1; i <= j / 2; i++)
                    {
                        if (j % i == 0)
                            sum += i;
                    }
                    if (sum == j)
                        Console.WriteLine("{0} is perfect", j);

                }

            }









        }
    }
}

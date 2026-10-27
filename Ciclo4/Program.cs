using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num6 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num6; i++) {
                for (int j = 1; j <= 2; j++)
                {
                    num6 = num6 + i;
                    num6 = num6 - j;
                }
            }
            Console.WriteLine(num6);
        }
    }
}

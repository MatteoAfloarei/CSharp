using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_logica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num6 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num6; i++)
            {
                for (int y = i; y <= 2; y++)
                {
                    num6 = num6 + i;
                    num6 = num6 - y;
                }
            }
            Console.WriteLine(num6);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cicli_annidati
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    x = x + j;
                }
                x--;
            }
            Console.WriteLine(x);

        }
    }
}

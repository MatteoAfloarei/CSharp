using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limite = int.Parse(Console.ReadLine());
            string s = "X" ;
            for (int i = 1; i <= limite; i++)
            {
                if (i % 2 == 0)
                {
                    s += "Y" ;
                }
                else
                {
                    for (int j = i; j <= 2; j++)
                    {
                        s += "Z" ;
                        limite++;
                    }
                }
            }
            Console.WriteLine(s);
        }
    }
}

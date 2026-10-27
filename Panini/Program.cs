using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Panino";
            for (int i = 1; i < 3; i++)
            {
                s = s + i;
                for (int j = 0; j < i; j++)
                {
                    s = s + "Panini";
                }
            }
            Console.WriteLine(s);

        }
    }
}

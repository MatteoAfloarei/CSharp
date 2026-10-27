using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anni = 10;
            int mesi = 3;
            while (anni > mesi)
            {
                anni = anni - 2;
                if (anni < 5)
                    mesi++;
                else
                    mesi = mesi + 2;
            }
            Console.WriteLine(anni + " Anni");

        }
    }
}

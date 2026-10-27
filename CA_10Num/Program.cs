/*Scrivi i dieci numeri pari successivi al numero N.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_10Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            bool success = true;

            Console.WriteLine("Inserisci un numero: ");
            success = int.TryParse(Console.ReadLine(), out N);

            for (int i = 0; i < 10; i++)
                {
                N = N + 1;
                Console.WriteLine(N);
            }
            
        }
    }
}

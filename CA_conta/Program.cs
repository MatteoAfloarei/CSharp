
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_conta
{
    internal class Program
    {
        static void Main(string[] args)
        {   //variabili
            int num, numeri, p = 0, n = 0, u = 0;

            //input
            Console.WriteLine("Inserisci quanti numeri vuoi mettere: ");
            num = int.Parse(Console.ReadLine());

            //calcoli
            for (int i = 0; i < num; i++) {
                Console.WriteLine("Inserisci i numeri che vuoi: ");
                numeri = int.Parse(Console.ReadLine());

                if (numeri > 0)
                {
                    p = p + 1;
                }
                else if (numeri < 0)
                {

                    n = n + 1;
                }
                else
                {
                    u = u + 1;
                }
            }
            //output
            Console.WriteLine("num positivo: " + p);
            Console.WriteLine("num negativo: " + n);
            Console.WriteLine("num uguale: " + u);
        }
    }
}


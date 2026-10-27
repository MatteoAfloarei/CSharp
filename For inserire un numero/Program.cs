using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_inserire_un_numero
{
    internal class Program
    {
        static void Main(string[] args)
        { int somma = 0, n;
            for (int i = 0; i < 5; i++){

                Console.WriteLine("Inserire un numero: ");
                n = int.Parse(Console.ReadLine());

                somma = somma + n;
            }
            Console.WriteLine("La somma dei numeri e': " + somma);
            // questo programma fa inserire 5 numeri e farli sommare fra di loro
        }
    }
}
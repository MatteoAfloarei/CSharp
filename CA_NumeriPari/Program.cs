
/* Dati N numeri, contare quanti sono pari*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NumeriPari
{
    internal class Program
    {   
        static void Main(string[] args)
        {   //variabili
            int num, numeri, pari = 0;

            //input
            Console.WriteLine("Quanti numeri vuoi inserire? ");
            num = int.Parse(Console.ReadLine());

            //calcolo
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Inserisci il numero: ");
                numeri = int.Parse(Console.ReadLine());

                if (numeri % 2 == 0)
                {
                    pari++;
                }
            }
            //output
            Console.WriteLine("I numeri pari sono: " + pari);
        }
    }
    
}

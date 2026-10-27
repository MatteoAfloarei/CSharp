/* Dati 2 numeri in input stampare tutti i numeri dispari compresi*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_DispariCompresi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1, input2;

            Console.WriteLine("Inserisci due numeri: ");
            input1 = int.Parse(Console.ReadLine());
            input2 = int.Parse(Console.ReadLine());

            for (int i = input1; i < input2; i++) { 
              if(i % 2  == 1)
                {
                    Console.WriteLine("I numeri dispari sono: " + i);
                }
            }
        }
    }
}

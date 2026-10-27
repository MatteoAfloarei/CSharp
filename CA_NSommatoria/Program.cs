/*Dati 2 numeri in input stampare la sommatoria di tutti i numeri compresi*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NSommatoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1,input2,n = 0;


            Console.WriteLine("Inserisci Un Numero:");
            input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci Un Numero:");
            input2 = int.Parse(Console.ReadLine());

            for (int i = input1; i <= input2; i++) {
                
                n = n + i;
                Console.WriteLine(n);
            }
            
        }
    }
}

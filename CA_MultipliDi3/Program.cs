/*Dati N numeri contare quanti sono i multipli di 3.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_MultipliDi3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ContaMultipli = 0, N, u; // FIX: Initialize ContaMultipli to 0
            bool n = true, k = true;
            do
            {
                Console.WriteLine("Inserisci quanti numeri vuoi inserire: ");
                n = int.TryParse(Console.ReadLine(), out N);
                do
                {
                    for (int i = 0; i < N; i++) // FIX: use int i and compare to N, not n
                    {
                        Console.WriteLine("Inserisci numero: ");
                        k = int.TryParse(Console.ReadLine(), out u);
                        if(u % 3  == 0)
                        {
                            
                            ContaMultipli++;
                        }
                        else
                        {
                            Console.WriteLine("Input non valido. Inserisci un intero.");
                        }
                        
                    }
                } while (n == false);
          
            } while (n == false);
            Console.WriteLine();
            Console.WriteLine("Numero di multipli di 3 trovati: " + ContaMultipli);
            Console.ReadKey();
        
    

        } 
    }
}

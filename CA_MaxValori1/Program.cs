/* Data una serie di N numeri determinare il valore più grande*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_MaxValore
{
    internal class Program
    {
        static void Main(string[] args)
        {    // Variabili
            int N, num;
            bool success;

            // Input del numero di valori
            do
            {
                Console.WriteLine("Inserisci il numero di valori da confrontare: ");
                success = int.TryParse(Console.ReadLine(), out N);

                if (!success || N <= 0)
                {
                    Console.WriteLine("Errore: inserire un intero positivo.");
                }

            } while (!success || N <= 0);

            // Inserimento del  numero prima ai successivi
            do
            {
                Console.WriteLine("Inserisci numero: ");
                success = int.TryParse(Console.ReadLine(), out num); // num prende il posto 0 

                if (!success)
                {
                    Console.WriteLine("Errore: inserire un intero.");
                }

            } while (!success);

            int maxValue = num;

            // Inserimento dei numeri rimanenti
            for (int i = 1; i < N; i++) // dato che 0 e' gia stato preso, prendiamo 1 come inizio
            {
                do
                {
                    Console.WriteLine("Inserisci numero: ");
                    success = int.TryParse(Console.ReadLine(), out num);

                    if (!success)
                    {
                        Console.WriteLine("Errore: inserire un intero.");
                    }

                } while (!success);

                if (num > maxValue)
                {
                    maxValue = num;
                }
            }

            // Output
            Console.WriteLine("Il numero massimo è: " + maxValue);
        }
    }
}

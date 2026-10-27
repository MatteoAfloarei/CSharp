/*- Date N assicurazioni di automobili:
 * l'importo viene aumentato del 10% se vi è stato più di un incidente,
 * altrimenti viene scontato del 6%. Calcola la somma degli importi e 
 * stampa il risultato.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AUTOSCONTO
{
    internal class Program
    {
        static void Main(string[] args)
        {   //variabili
            int N,C;
            double I,S = 0,r;
            bool success = true;
            do
            {  //input1
                do
                {
                    Console.WriteLine("Quante assicurazioni di auto vuoi inserire? ");
                    success = int.TryParse(Console.ReadLine(), out N);
                    if (!success)
                    {
                        Console.WriteLine("Errore. Riprovare: ");
                    }else if(N <= 0)
                    {
                        Console.WriteLine("Numero non Valido: ");
                    }
                } while (!success || N <= 0);
                    

               //input2
                for (double j = 0; j < N; j++)
                {
                    Console.WriteLine("Inserire il costo: ");
                    success = double.TryParse(Console.ReadLine(), out I);
                    if (!success)
                    {
                        Console.WriteLine("Errore. Riprovare: ");
                    }else if(I <= 0)
                    {
                        Console.WriteLine("Credito non Valido: ");
                    }

                    Console.WriteLine("Inserire il numero di incidenti avvenuti: ");
                    success = int.TryParse(Console.ReadLine(), out C);
                    //calcolo
                    if (!success)
                    {
                        Console.WriteLine("Errore. Riprovare: ");
                    }

                    if (C > 1)
                    {
                        r = I * 1.10;
                    }
                    else
                    {
                        r = I * 0.94;
                    }
                    S += r;
                }
                //output
                Console.WriteLine("Il totale e: " + S);
               
            } while (!success);

            
            

            
        }
    }
}

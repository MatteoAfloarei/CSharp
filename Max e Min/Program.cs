using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Max_e_Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = int.MaxValue, min = int.MinValue,input1,input2;
            bool success = true;

            do
            {
                
                Console.WriteLine("Quanti numeri vuoi inserire? ");
                success = int.TryParse(Console.ReadLine(), out input1);
                if(!success || input1 < 0)
                {
                    Console.WriteLine("Riprova: ");
                }
            } while (!success || input1 < 0);

             
            for (int i = 0; i < input1; i++)
            {
                do
                {
                    Console.WriteLine("Inserisci numero: ");
                    success = int.TryParse(Console.ReadLine(), out input2);
                    if (!success)
                    {
                        Console.WriteLine("Riprova");
                    }
                   
                } while (!success);

                if(i == 0)
                {
                    min = input2;
                    max = input2;
                }
                else
                {
                    if(input2 < min)
                    {
                        min = input2;
                    } else if(input2 > max)
                    {
                        max = input2;
                    }
                }
            }
            Console.WriteLine("Il max e: " + max);
            Console.WriteLine("Il min e: " + min);
        }
    }
}

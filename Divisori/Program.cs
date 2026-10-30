/*Trovare il divisori di un numero*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1, input2;
            bool success = true;

            do
            {
                Console.WriteLine("Che numero vuoi inserire per sapere i divisori?");
                success = int.TryParse(Console.ReadLine(), out input1);
                if (!success || input1 < 0)
                {
                    Console.WriteLine("Riprova");
                }
            } while (!success);

            for(int i = input1; i > 0; i--)
            {
                input2 = input1 % i;
                if(input2 == 0)
                {
                    
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_EserRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num1,range;
            bool success = true;
            do
            {   
                Console.WriteLine("Quanti numeri vuoi generare? ");
                success = int.TryParse(Console.ReadLine(), out num1);
                if (!success)
                {
                    Console.WriteLine("Riprovare: ");
                }
                Console.WriteLine("Il range massimo che vuoi?");
                success = int.TryParse(Console.ReadLine(), out range);
                if (!success)
                {
                    Console.WriteLine("Riprovare: ");
                }
                for (int i = 0;i < num1; i++)
                {
                    int num = rnd.Next(range);
                    Console.WriteLine(num);
                }
            } while (!success);
        }
    }
}

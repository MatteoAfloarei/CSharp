/*Scrivi un programma in C# che Generi un numero casuale tra 1 e 100.
 Chieda ripetutamente all'utente di inserire un tentativo.
"Il numero è più grande" se il tentativo è troppo basso.
"Il numero è più piccolo" se il tentativo è troppo alto.
"Hai indovinato!" se il numero è corretto.
Alla fine, stampa anche in quanti tentativi è stato indovinato il numero.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indovina_Il_Numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int generatore = 56,tentativo,tentativi = 1;
            do
            {
                Console.WriteLine("Inserisci il tentativo di vincita: ");
                tentativo = int.Parse(Console.ReadLine());
                if (tentativo < generatore) {
                    Console.WriteLine("Il Numero e' piu grande ");
                }else if (tentativo > generatore)
                {
                    Console.WriteLine("Il Numero e' piu piccolo ");
                }
                else
                {
                    Console.WriteLine("Hai indovinato! Il numero era: " + generatore);
                    Console.WriteLine("Hai usato " + tentativi + " tentativi");
                }
                tentativi++;
            } while(generatore != tentativo);
            Console.ReadKey();
           
        }
    }
}

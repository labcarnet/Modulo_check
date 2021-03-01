using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_check
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var inputDigit = 0;
            while(true)
            {
                Console.WriteLine("Podaj liczbę w celu sprawdzenia jej parzystości.");
                inputDigit = GetUserDigit();
                if (inputDigit % 2 == 0) Console.WriteLine("Podana liczba jest parzysta\n.");
                else Console.WriteLine("Podana liczba jest nieparzysta\n.");
            }         
        }

        private static int GetUserDigit()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int userDigit))
                {
                    Console.WriteLine("\nPrzykro mi. Wprowadzone przez Ciebie dane nie są poprawne. \nPodaj jeszcze raz liczbę całkowitą nie większą jak 4294967295.");
                    continue;
                }
                return userDigit;
            }
        }
    }
}

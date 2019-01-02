using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rainy = true;
            // le bloque de if n'est éxcuté que si l'on a rainy = true
            if (rainy) 
            {
                Console.WriteLine("Bonjour, il pleut aujourd’hui, vous devriez prendre votre parapluie.");
            }
            else // le else est appellé si le if n'est pas éxecuté
            {
                Console.WriteLine("Bonjour, il ne pleut pas aujourd’hui, bonne journée.");
            }
            Console.ReadKey();
            
        }
    }
}

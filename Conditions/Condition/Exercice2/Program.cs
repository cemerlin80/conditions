using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("saisissez votre age");
            int.TryParse(Console.ReadLine(), out age); 
            if (age < 18 && age > 0) // Vérifier que l'âge à enseigner est compris entre 0 et 17
            {
                Console.WriteLine("vous avez moins de 18 ans , vous êtes mineur");
            }
            else if (age >18)
            {
                Console.WriteLine("vous avez plus de 18 ans , vous êtes majeur");
            }
            else // on gère le cas ou la saisie est incorrect
            {
                Console.WriteLine("Vous êtes un robot");
            }

        }
    }
}

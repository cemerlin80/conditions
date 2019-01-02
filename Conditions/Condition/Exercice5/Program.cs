using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection fujita = new NameValueCollection(); // Création du tableau associatif
            fujita.Add("F0", "Dégâts légers");
            fujita.Add("F1", "Dégâts modérés");
            fujita.Add("F2", "Dégâts importantes");
            fujita.Add("F3", "Dégâts considérables");
            fujita.Add("F4", "Dégâts dévastateurs");
            fujita.Add("F5", "Dégâts incroyables");

            Console.WriteLine("Renseigner le type d'une tornade"); // Recherche des dégâts d'une tornade
            string F = Console.ReadLine();
            if (F == "F0")

                Console.WriteLine(fujita["F0"]);
            else if (F == "F1")
                Console.WriteLine(fujita["F1"]);
            else if (F == "F2")
                Console.WriteLine(fujita["F2"]);
            else if (F == "F3")
                Console.WriteLine(fujita["F3"]);
            else if (F == "F4")
                Console.WriteLine(fujita["F4"]);
            else if (F == "F5")
                Console.WriteLine(fujita["F5"]);
            



        }
    }
}

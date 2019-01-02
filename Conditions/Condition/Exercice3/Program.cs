using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string sexe;
            Console.WriteLine("saisissez votre age");
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Quel est votre sexe ?");
            sexe =(Console.ReadLine());


            if (sexe == "homme")
            { 
                if(age < 18)
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes mineur.");
                }
                else
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes majeur.");

                }

            }
            else 
            {
     
                if(age <18)
                {
                    Console.WriteLine("Vous êtes une femme et vous êtes mineure.");
                }
                else
                {
                    Console.WriteLine("Vous êtes une femme et vous êtes majeure.");
                }
            }
            
        }
    }
}

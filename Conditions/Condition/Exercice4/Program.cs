using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        { 
            string login "Ibh", "login2", mdp = "123", mdp2;

            Console.WriteLine("Login");
            login2 = Console.ReadLine();
            Console.WriteLine("Mdp");
            mdp2 = Console.ReadLine();
            // On compare le login entrer et le mot de passe | login.Equals(login2) est équivalent à "=="
            if (login.Equals(login2) && mdp.Equals(mdp2))
            {
                Console.WriteLine("Bienvenue à la MANU, Amiens");

            }

            else
            {
                Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
            }
            Console.ReadKey();
             
            
        }
    }
}

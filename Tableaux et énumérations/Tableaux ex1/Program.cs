using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableaux_exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[] { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };
            for (int i = 0; i < week.Length; i++)
            {
                Console.WriteLine(week[i]);
            }
        }
    }
}

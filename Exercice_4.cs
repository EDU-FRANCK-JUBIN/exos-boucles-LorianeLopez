using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucles_Exercice_D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer un nombre : ");
            int nombre1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez entrer un nombre plus grand que le premier : ");
            int nombre2 = int.Parse(Console.ReadLine());
            int somme = calculSommeEntier(nombre1, nombre2);
            Console.WriteLine("La somme est de : " + somme);
            Console.ReadLine();

        }

        static int calculSommeEntier(int entier1, int entier2)
        {
            int somme = 0;
            List<int> entiers = new List<int>();
            for(int i = entier1; i<= entier2; i++)
            {
                entiers.Add(i);
            }

            foreach(int entier in entiers)
            {
                somme += entier;
            }


            return somme;
        }
    }
}

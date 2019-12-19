using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucles_Exercice_C
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> liste = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Veuillez entrer un nombre : ");
                int number1 = int.Parse(Console.ReadLine());
                liste.Add(number1);
            }

            int somme = 0;
            foreach (int entier in liste)
            {
                somme += entier;
            }

            double moyenne = somme / 5;
            Console.WriteLine("La somme est de " + somme);
            Console.WriteLine("La moyenne est de " + moyenne);
            Console.ReadLine();

        }
    }
}

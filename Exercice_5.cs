using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucles_Exercice_E
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> liste = new List<double>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Veuillez entrer un nombre : ");
                double nombre = double.Parse(Console.ReadLine());
                liste.Add(nombre);
            }
            double moyenne = calculMoyenne(liste);
            Console.WriteLine("La moyenne est de : " + moyenne);
            Console.ReadLine();

        }

        static double calculMoyenne(List<double> liste)
        {
            double somme = 0;
            foreach (double nombre in liste)
            {
                somme += nombre;
            }
            double moyenne = somme / liste.Count();
            return moyenne;
        }
    }
}

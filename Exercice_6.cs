using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucles_Exercice_F
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("La somme des multiples communs entre 5 et 3 est : " + sommeCommune());
            Console.ReadLine();

        }

        static double sommeCommune()
        {
            double somme = 0;
            List<int> multipeDe3 = new List<int>();
            List<int> multipeDe5 = new List<int>();
            List<int> communs = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    multipeDe3.Add(i);
                }
                if(i % 5 == 0)
                {
                    multipeDe5.Add(i);
                }
                if(multipeDe3.Contains(i) && multipeDe5.Contains(i))
                {
                    int j = i * 2;
                    communs.Add(j);
                }
            }
            foreach(int nombre in communs)
            {
                somme += nombre;
            }

            return somme;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucles_Exercice_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer en nombre : ");
            int nombre = int.Parse(Console.ReadLine());
            int nombre2 = nombre;
            int nombre3 = 0;

            for (int k = 0; k < nombre; k++)
            {
                if (k == 0)
                {
                    nombre3 = nombre + (nombre2 - 1);
                }
                else
                {
                    nombre3 += nombre2 - 1;
                }

                nombre2--;
            }
            Console.WriteLine(nombre3);
            Console.ReadLine(); 

        }
    }
}

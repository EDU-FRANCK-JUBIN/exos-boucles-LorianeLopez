using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucles_Exercice_A
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int i = 0; i<21; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i + " est un multiple de 2.");
                }
            }
            Console.ReadLine();

            int j = 0;
            while (j < 21)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j + " est un multiple de 2.");
                }
                j++;
            }
            Console.ReadLine();

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimeticZadatak6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite koliko clanova niza zelite: ");
            int cln = Convert.ToInt32(Console.ReadLine());
            int[] niz = new int[cln];

            Console.WriteLine("Upisite clanove: ");
            for (int i = 0; i < cln; i++) 
            {
                niz[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(niz);

            Console.WriteLine("Sortirani niz:");
            for(int i = 0;i < cln; i++)
            {
                Console.WriteLine(niz[i]);

            }
            Console.ReadKey();
        }
    }
}

﻿using System;
using System.Collections;

namespace ejercicio6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la cadena 1");
            String cadena1 = Console.ReadLine();
            Console.WriteLine("Digite la cadena 2");
            String cadena2 = Console.ReadLine();
            ArrayList array = new ArrayList();
            array.Add(cadena1);
            array.Add(cadena2);
            array.Sort();
            Console.WriteLine("Ordenado: ");
            foreach (String cadena in array)
            {
                Console.WriteLine("{0}", cadena);
            }
        }
    }
}

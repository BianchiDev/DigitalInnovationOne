﻿

using System;
using System.Globalization;
namespace Exercíco_de_Fixação
{
    class Program
    {
        static void Main(string[] args)
        {
        //Operadores comparativos

            int a = 10;
            bool c1 = a < 10; // Menor que 
            bool c2 = a < 20; // Maior que 
            bool c3 = a > 10; 
            bool c4 = a > 5;


            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("-------------------------");

            bool c5 = a <= 10; //Menor ou igual
            bool c6 = a >= 10; //Maior ou igual
            bool c7 = a == 10; // igual
            bool c8 = a != 10;

            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);

        }
    }
}
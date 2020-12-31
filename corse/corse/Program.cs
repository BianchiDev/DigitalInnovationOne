using System;
using System.Globalization;// usado para incluir na chamada o ponto atraves do operador CultureInfo.InvariantCulture

namespace corse{
    class Program{
        static void Main(string[] args){
            // SByte x = 100;
           
            /*
            bool completo = false;   // valor boleano
            char genero = 'F';       //caracter unicode
            char letra = '\u0041'; // código unicode da tabela unicode
            byte n1 = 126;           
            int n2 = 1000;
            int n3 = 214783647;
            long n4 = 2147483648L;
            float  n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green"; // Cadeia de caracteres Unicode IMUTÁVEL(segurança,simplicidade, thread safe)
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            sbyte n9 = sbyte.MinValue;
            decimal n10 = decimal.MaxValue;
            */


            //char genero1 = 'F';
            int idade = 32;
            double saldo = 10.35784; 
            string nome1 = "maria";
            //placeholders, concatenação e interpolação

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais",nome1, idade, saldo);//placeholders

            Console.WriteLine($"{nome1} tem {idade} anos e tem saldo igual a {saldo:F2} reais");//interpolação

            Console.WriteLine(nome1 + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais ");//interpolação








            /*
            Console.WriteLine(genero1);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome1);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4",CultureInfo.InvariantCulture));// imprime com o ponto de separador de decimais 
            Console.WriteLine("--------------------");
            Console.Write("Boa tarde");
            Console.WriteLine("Bom dia! ");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("-----------------------");
            */
            /*
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);
            Console.WriteLine(letra);
            Console.WriteLine(genero);
            Console.WriteLine(completo);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            */

        }
    }
}
//preenche o console -->  c + w + tab + tab

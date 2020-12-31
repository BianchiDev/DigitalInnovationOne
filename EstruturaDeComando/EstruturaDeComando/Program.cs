using System;

namespace EstruturaDeComando
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual a hora atual ");
            int hora = int.Parse(Console.ReadLine());



            //Estrutura condicional Composta//


            /*
            if (hora < 12)
            {
                Console.WriteLine(" Bom dia! ");
            }

            if (hora >= 12 && hora < 18)
            {
                Console.WriteLine(" Boa Tarde! ");
            }
            if (hora >= 18)
            {
                Console.WriteLine("Boa noite!");

            }
            */

            //Estrutura condicional Encadeada//

            /*
            if (hora < 12)
            {
                Console.WriteLine(" Bom dia! ");
            }
            else if (hora < 18)
            {
                Console.WriteLine(" Boa Tarde! ");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
            */

             int numero, limite;
            int limit = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++) 
        {
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            if (Y == 0) {
                Console.WriteLine("divisao impossivel");
            } else {
                double divisao = Dividir(x,y); 									// Digite aqui o calculo da divisao
                Console.WriteLine(divisao.ToString("F2"));
				
            }
        }
    }
}

//Epaminondas resolve contar usando a mão esquerda da seguinte maneira: 
//Ela começa com 1 no dedão, 2 no dedo indicador, 3 no médio, 4 no anelar, 5 no mínimo e depois 
//inverteu a ordem, contando 6 no anelar, 7 no médio, 8 no indicador, 9 no dedão, 10 novamente no dedo indicador
//e assim por diante.
//Faça um algoritmo que leia o número a ser contado e indique em qual dedo do Epaminondas parou?
//using System;

using System;
using System.Collections.Generic;
using System.Linq;

namespace contarNosDedos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número: ");

            int numero = Int32.Parse(Console.ReadLine());

            int[] multiplo8 = new int[numero];



            for (int x = 0; x < numero; x++)
            {
                if (x % 8 == 0)
                {
                    multiplo8[x] = x;
                }
            }


            foreach (int y in multiplo8)
            {

                if (numero == 1 || numero == (1 + y))
                {
                    Console.WriteLine("dedão");
                    break;
                }
                else if (numero == 2 || numero == (2 + y))
                {
                    Console.WriteLine("indicador");
                    break;
                }
                else if (numero == 3 || numero == (3 + y))
                {
                    Console.WriteLine("médio");
                    break;
                }
                else if (numero == 4 || numero == (4 + y))
                {
                    Console.WriteLine("anelar");
                    break;
                }
                else if (numero == 5 || numero == (5 + y))
                {
                    Console.WriteLine("mínimo");
                    break;
                }
                else if (numero == 6 || numero == (6 + y))
                {
                    Console.WriteLine("anelar");
                    break;
                }
                else if (numero == 7 || numero == (7 + y))
                {
                    Console.WriteLine("médio");
                    break;
                }
                else if (numero == 8 || numero == (8 + y))
                {
                    Console.WriteLine("indicador");
                    break;
                }
            }
        }
    }
}

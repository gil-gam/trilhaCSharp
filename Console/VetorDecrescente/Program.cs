///<sumary>Faça um programa que carregue um vetor com dez números inteiros. 
///Calcule e mostre um vetor resultante ordenado de maneira decrescente.
///</sumary>

using System;
using System.Linq;

namespace VetorDecrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++)
            {
                vetor[i] = Int32.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Esta é a ordem crescente: ");
            Array.Sort<int>(vetor);
            foreach (int x in vetor)
            {
                Console.Write(x + ", ");
            }


            Console.WriteLine("\n Esta é a ordem decrescente: ");
            Array.Reverse(vetor);
            foreach (int x in vetor)
            {
                Console.Write(x + ", ");
            }

        }
    }
}

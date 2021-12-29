/// <sumary>Faça um programa que carregue dois vetores de 3 elementos numéricos cada
/// e escreva um vetor resultante da intercalação desses outros dois vetores.
/// </sumary>

using System;

namespace SomaVetores
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] lista1 = new int[3];
            int[] lista2 = new int[3];
            int[] lista3 = new int[6];

            Console.WriteLine("informe 3 números para a 1ª lista: ");
            for (int l1 = 0; l1 < 3; l1++)
            {
                lista1[l1] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("informe 3 números para a 2ª lista: ");
            for (int l2 = 0; l2 < 3; l2++)
            {
                lista2[l2] = Int32.Parse(Console.ReadLine());
            }

            for (int l3 = 0; l3 < 3; l3++)
            {
                lista3[l3] = lista1[l3];
                lista3[l3 + 3] = lista2[l3];
            }


            Console.WriteLine("a soma das duas listas é: ");
            foreach (int x in lista3)
            {
                 Console.Write(x + ", ");
            }
        }
    }
}

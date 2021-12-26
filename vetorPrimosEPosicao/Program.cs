/// <sumary>Faça um algoritmo em pseudocódigo e fluxograma, que carregue um vetor de nove elementos
/// numéricos inteiros, calcule e mostre os números primos e suas respectivas posições dentro do vetor
/// (considere um vetor zero-based).
/// </sumary>

using System;
using System.Linq;

namespace vetorPrimosEPosicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[9];
            int y = 0;
            int posicao = 0;

            Console.WriteLine("Digite 9 números, seguidos de ENTER");
            for (int i = 0; i < 9; i++)
            {
                vetor[i] = Int32.Parse(Console.ReadLine());
            }

            foreach (int x in vetor)
            {
                for (y = 2; y <= vetor.Length; y++)
                {
                    posicao += 1;
                    if (x == 1)
                    {
                        break;
                    }
                    else if (x % y == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("O número {0}", + x + " é primo! Posição: " + posicao);
                        break;
                    }
                }
            }

        }
    }
}


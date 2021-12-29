/// <summary> Faça a tabuada de um número e apresente o resultado de acordo com o modelo a seguir, 
/// sabendo que o multiplicando deverá ser fornecido pelo usuário (n) e a quantidade de iterações também (i).
/// </summary>
/// 
using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número para a tabuada: ");
            int numero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe quantas vezes vai multiplicar: ");
            int vezes = Int32.Parse(Console.ReadLine());
            int multiplicador = numero;
            int i = 0;

            for (i = 1; i <= vezes; i++)
            {
                multiplicador = numero * i;
                Console.WriteLine(numero + " X " + i + " = " + multiplicador);
            }

        }
    }
}

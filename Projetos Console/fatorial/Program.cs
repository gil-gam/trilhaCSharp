///<sumary>
///Faça um algoritmo que lê um valor N inteiro e positivo e que calcula e escreve o fatorial de N (N!).
/// </sumary>

using System;
using System.Linq;


namespace fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro e positivo: ");
            int numero = Int32.Parse(Console.ReadLine());
            int i = 0;
            int fatorial = numero;  
            
            for (i = numero - 1; i >= 1; i--)
            {
                if (numero <= 0)
                    continue;

                numero = numero * i;                
            }

            Console.WriteLine("O fatorial de " + fatorial + " é: " + numero);

        }
    }
}

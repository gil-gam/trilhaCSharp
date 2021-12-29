//Faça um algoritmo que leia números, quando o número lido for igual a zero, 
//o algoritmo para de ler números e escreve o maior número lido

using System;
using System.Collections.Generic;
using System.Linq;


namespace mostrar_numero_maior
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite cada número + ENTER\n(Digite 0 para ver qual é o maior número)");
            double numero = 0;
            List<double> numeros = new List<double>();
            while (true)
            {
                numero = Double.Parse(Console.ReadLine());
                if (numero == 0)
                {
                    break;
                }
                numeros.Add(numero);
                
            }
            double maior = numeros.Max();
            Console.WriteLine("O maior número é: {0}", maior);
        }
    }
}

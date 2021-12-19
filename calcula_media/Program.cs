//Crie um algoritmo que leia as notas obtidas por um aluno e calcule a média entre elas. 
//O programa deve parar de ler notas e exibir a média quando digitada a nota 11.

using System;
using System.Collections.Generic;
using System.Linq;


namespace passo_5_exercicio_1
{
    class Program
    {

        static void Main(string[] args)
        {
            List<double> notas = new List<double>();
            Console.WriteLine("Digite as notas \n Digite 11 para calcular a média: ");
            double nota = 0;
            while (true)
            {
                nota = Double.Parse(Console.ReadLine());
                notas.Add(nota);
                if (nota == 11)
                {
                    break;
                }
            }

            try
            {
                double media = (notas.Sum() - 11) / (notas.Count - 1);

                Console.WriteLine("\n A média é: {0}", media);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}

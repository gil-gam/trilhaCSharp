///<sumary>Faça um algoritmo que leia uma matriz 5 x 3 com as notas de dez alunos em três provas. 
///Mostre um relatório com o número do aluno (número da linha) e a prova em que cada aluno
///obteve menor nota. 
///</sumary>

using System;
using System.Linq;
using System.Collections.Generic;


namespace MatrizNotasAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[5, 3];
            double[] nota = new double[3];
            
            try
            {
                for (int a = 0; a < 5; a++)
                {

                    for (int b = 0; b < 3; b++)
                    {
                        Console.WriteLine("Informe a nota " + (b + 1) + " do aluno " + (a + 1));
                        matriz[a, b] = Double.Parse(Console.ReadLine());
                        nota[b] = matriz[a, b];

                    }

                    Console.WriteLine("aluno: " + (a + 1) + ", menor nota: " + nota.Min());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

//São dados N azulejos de dimensões 10cm x 10cm. 
//Com eles, você deve montar um conjunto de quadrados de modo a utilizar TODOS os azulejos dados. 
//Inicialmente você deve montar o maior quadrado possível com os azulejos dados; 
//então, com os azulejos que sobraram, você deve montar o maior quadrado possível, e assim sucessivamente.

//Faça um algoritmo que calcule o número de quadrados do conjunto montado para um determinado número de azulejos
//que seja informado. Saia do algoritmo quando informado o número zero (0).


using System;
using System.Collections.Generic;
using System.Linq;

namespace quadradroDeAzulejos
{
    class Program
    {
        static void Main(string[] args)
        {
            double azulejos = 1;
            List<double> verificaQuadrados = new List<double>();
            List<double> totalQuadrados = new List<double>();
            totalQuadrados.Clear();


            while (azulejos != 0)
            {
                Console.WriteLine("Digite a quantidade de azulejos.\nDigite 0 para sair: ");
                azulejos = Double.Parse(Console.ReadLine());

                //Procurar o maior quadrado dentro do número de azulejos
                for (double numero = 2; numero < azulejos; numero++)
                {
                    double quadrado = Math.Pow(numero, 2);
                    if (quadrado > azulejos)
                        break;
                    verificaQuadrados.Add(quadrado);

                }

                double quadradoMaior = verificaQuadrados.Max();
                totalQuadrados.Add(quadradoMaior);
                double azulejosSobra = azulejos - quadradoMaior;

                //ver quantos múltiplos de 4 tem na sobra
                double quadradoMenor = 0;
                double azulejosUltimaSobra = 0;
                for (int y = 1; y <= azulejosSobra; y++)
                {                    
                    if (y % 4 == 0)
                    {
                        quadradoMenor = y;
                        totalQuadrados.Add(quadradoMenor);
                        azulejosUltimaSobra = azulejosSobra - y;
                       
                    }
                }

                double quadradoUnitario = quadradoMaior - quadradoMenor;


                Console.WriteLine(
                    "Com {0} ",
                    +azulejos
                    + " azulejos"
                    + " é possível montar "
                    + (totalQuadrados.Count + azulejosUltimaSobra)
                    + " quadrado(s)"); ;

                totalQuadrados.Clear();
            }

        }


    }
}

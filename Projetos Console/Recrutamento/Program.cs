/// <summary>
/// A empresa JS Recrutamento e Seleção Ltda., faz recrutamento e seleção de funcionários para várias 
/// empresas em diversos ramos de atuação. Atende em média 30 candidatos por dia, mas esse valor aumenta quando 
/// faz divulgação de vagas. Para facilitar o trabalho de identificação do perfil dos candidatos que se inscrevem
/// para as vagas, resolveu fazer um programa para registrar alguns dados para obter as informações a seguir:
/// • o número de candidatos do sexo feminino;
/// • o número de candidatos do sexo masculino;
/// • a idade média dos homens;
/// • a idade média das mulheres com experiência;
/// • a porcentagem dos homens entre 35 e 45 anos entre o total dos homens;
/// • a menor idade entre as mulheres que já têm experiência no serviço;
/// • o nível de escolaridade dos candidatos entre: ensino Fundamental, ensino Médio, Graduação e Pós graduação.
/// Faça um algoritmo para calcular as informações solicitadas anteriormente, sabendo que a cada iteração
/// deverá ser perguntado ao usuário se deseja cadastrar outro candidato, quando a resposta for negativa 
/// os resultados deverão ser apresentados.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;

namespace Recrutamento
{
    class Program
    {
        static void Main(string[] args)
        {
            string candidato = "S";
            double masculino = 0;
            double feminino = 0;
            int x = 0;
            List<double> idadeMediaHomens = new List<double>(0);
            double idade = 0;
            double homens3545 = 0;
            double media3545 = 0;
            int y = 0;
            List<double> idadeMediaMulheres = new List<double>(0);
            double idadeMulher = 0;
            string experiencia = "";
            int nivel = 0;
            int fundamental = 0;
            int medio = 0;
            int graduacao = 0;
            int posgraduacao = 0;


            try
            {
                while (candidato == "S")
                {
                    Console.WriteLine("Deseja cadastrar um candidato (S/N)?");
                    candidato = Console.ReadLine().ToUpper();

                    if (candidato == "N".ToUpper())
                        continue;

                    Console.WriteLine("Informe o sexo: (M)Masculino (F)Feminimo");
                    string sexo = Console.ReadLine().ToUpper();
                    if (sexo == "M")
                    {
                        masculino += 1;
                        Console.WriteLine("Informe a idade do candidato");
                        idade = Double.Parse(Console.ReadLine());
                        idadeMediaHomens.Add(idade);
                        if (idade >= 35 && idade <= 45)
                        {
                            homens3545 += 1;
                        }

                    }
                    else if (sexo == "F")
                    {
                        feminino += 1;
                        Console.WriteLine("Tem experiência (S/N)?");
                        experiencia = Console.ReadLine().ToUpper();
                        if (experiencia == "S")
                        {
                            Console.WriteLine("Informe a idade da candidato");
                            idadeMulher = Double.Parse(Console.ReadLine());
                            idadeMediaMulheres.Add(idadeMulher);
                            Console.WriteLine("A menor idade entre as mulheres que já têm experiência no serviço é: " + idadeMediaMulheres.Min());
                        }

                    }

                    Console.WriteLine("Informe o nível de escolaridade do candidato: " +
                        "\n 1 - ensino fundamental" +
                        "\n 2 - ensino médio" +
                        "\n 3 - graduação" +
                        "\n 4 - pós-graduação" +
                        "\n Indique o número correspondente: ");

                    nivel = Int32.Parse(Console.ReadLine());

                    if (nivel == 1)
                    {
                        fundamental += 1;
                    }
                    else if (nivel == 2)
                    {
                        medio += 1;
                    }
                    else if (nivel == 3)
                    {
                        graduacao += 1;
                    }
                    else if (nivel == 4)
                    {
                        posgraduacao += 1;
                    }

                }

                Console.WriteLine("Número de candidatos do sexo feminino: " + feminino);
                Console.WriteLine("Número de candidatos do sexo masculino: " + masculino);
                Console.WriteLine("A idade média dos homens é: " + (idadeMediaHomens.Sum() / idadeMediaHomens.Count()));
                x += 1;
                Console.WriteLine("A idade média das mulheres com experiência é: " + (idadeMediaMulheres.Sum() / idadeMediaMulheres.Count()));
                y += 1;
                if (homens3545 >= 1)
                {
                    media3545 = (homens3545 * 100 / masculino);
                }
                Console.WriteLine("A porcentagem dos homens entre 35 e 45 anos é de: " + media3545 + "%");
                
                
                Console.WriteLine("Nível de escolaridade: " +
                    "\n fundamental: " + fundamental +
                    "\n medio: " + medio +
                    "\n graduação: " + graduacao +
                    "\n pós-graduação: " + posgraduacao);

            }

            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}


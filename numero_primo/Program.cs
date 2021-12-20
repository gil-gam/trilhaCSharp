//Desenvolver um algoritmo que calcule se um número é primo ou não. 
//Dica usar o operador % que verifica o resto da divisão. 
//Saia do algoritmo quando digitado o número zero (0). 
//Um número natural é um número primo quando ele é maior que um (1) e 
//tem exatamente dois divisores naturais distintos: o número um (1) e ele mesmo
//Exemplo de números primos são: 2,3,5


using System;

namespace numero_primo
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int numero = 2;
                while (numero != 0)
                {
                    Console.WriteLine("Digite um número inteiro diferente de 1 + ENTER\npra ver se é PRIMO ou não.\nDigite 0 para sair");
                    numero = Int32.Parse(Console.ReadLine());

                    for (int x = 2; x <= numero; x++)
                    {
                        if (numero == 1)
                        {
                            break;
                        }
                        else if (numero % x == 0)
                        {
                            Console.WriteLine("O número {0}", + numero + " NÃO é número primo.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("O número {0}", + numero + " é primo!");
                            break;
                        }
                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}

//Faça um algoritmo que conte de 1 a 100 e a cada múltiplo de 10 emita uma mensagem: 
//“Múltiplo de 10”


using System;

namespace passo_5_exercicio_2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            for (int x = 1; x <= 100; x++)
            {
                if (x % 10 == 0)
                {
                    Console.WriteLine("Múltiplo de 10: {0}", x);
                }
            }
        }
    }
}
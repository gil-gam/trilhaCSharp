/// <sumary>
/// Pedro tem 1,50 metro e cresce 2 centímetros por ano, 
/// enquanto Lucas tem 1,10 metro e cresce 3 centímetros por ano. 
/// Construa um algoritmo que calcule e imprima quantos anos serão necessários para que:
/// a.Lucas e Pedro tenham o mesmo tamanho;
/// b.Lucas seja maior que Pedro.
/// </sumary>


using System;

namespace CalculaAlturaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pedro = 150;
            decimal lucas = 110;


            while (true)
            {
                pedro = pedro + 2;
                lucas = lucas + 3;
                if (pedro == lucas)
                {

                    Console.WriteLine("Lucas e Pedro terão o mesmo tamanho quando atingirem " + (pedro/100).ToString("0.00") + " m de altura.");                    
                }

                if (lucas > pedro)
                {
                    
                    Console.WriteLine("Lucas será maior que Pedro quando atingir " + (lucas/100).ToString("0.00") + " m de altura.");
                    break;
                }

            }
        }
    }
}

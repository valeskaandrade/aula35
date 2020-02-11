using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
    Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
    essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).*/
            Console.Write("Informe a quantidade de inteiros que irá informar: ");
            int N = int.Parse(Console.ReadLine());
            int IN = 0;
            int OUT = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Informe o {0}º número: ", i);
                int X = int.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20)
                {
                    IN++;

                }
                else
                {
                    OUT++;
                }
            }
            Console.WriteLine("DENTRO: " + IN);
            Console.WriteLine("FORA: " + OUT);
        }
    }
}

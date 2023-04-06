using System;

namespace Target_sistemas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool verifica = true, converter = true;
            int n = 0;

            do
            {
                Console.WriteLine("Informe um número inteiro:");
                converter = int.TryParse(Console.ReadLine(), out n);
            } while (n < 0 || !converter);

            int[] Fibonacci = new int[n];

            Fibonacci[0] = 0;
            Fibonacci[1] = 1;

            for (int i = 2; i < n; i++)
            {
                Fibonacci[i] = Fibonacci[i - 1] + Fibonacci[i - 2];
            }

            for (int i = 0; i < n; i++)
            {
                if (n == Fibonacci[i])
                {
                    Console.WriteLine($"O número {n} pertence a sequência de Fibonaci.");
                    verifica = false;
                }
            }

            if (verifica == true)
                Console.WriteLine($"O número {n} não pertence a sequência de Fibonaci.");

            Console.WriteLine("Pressione enter para encerrar");
            Console.ReadLine();
        }
    }
}

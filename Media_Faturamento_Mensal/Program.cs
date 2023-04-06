using System;
using System.Collections.Generic;

namespace media_faturamento_mensal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] faturamento = new decimal[31];
            int contador = 0, numero_dias = 0;
            decimal soma = 0, media_faturamento = 0, menor = 0, maior = 0;

            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine($"Digite o faturamento do {i}° dia");
                faturamento[i] = decimal.Parse(Console.ReadLine());

                menor = faturamento[i];

                if (faturamento[i] != 0)
                    contador++;

                soma += faturamento[i];
            }

            media_faturamento = soma / contador;

            for (int i = 1; i <= 30; i++)
            {
                if (faturamento[i] < menor)
                    menor = faturamento[i];

                if (faturamento[i] > maior)
                    maior = faturamento[i];

                if (faturamento[i] > media_faturamento)
                    numero_dias++;
            }

            Console.WriteLine($"O menor faturamento do mês foi {menor}.");
            Console.WriteLine($"O maior faturamento do mês foi {maior}.");
            Console.WriteLine($"O faturamento diario foi maior que a média mensal em {numero_dias} dias.");

            Console.WriteLine("Pressione enter para encerrar");
            Console.ReadLine();
        }
    }
}

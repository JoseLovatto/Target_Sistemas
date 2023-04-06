using System;

namespace Faturamento_mensal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal sp, rj, mg, es, outros, total;

            Console.WriteLine("Entre com o valor faturado pelo estado de São Paulo:");
            sp = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor faturado pelo estado de Rio de Janeiro:");
            rj = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor faturado pelo estado de Minas Gerais:");
            mg = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor faturado pelo estado de Espírito Santo:");
            es = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor faturado por outros estados:");
            outros = decimal.Parse(Console.ReadLine());

            total = sp + rj + mg + es + outros;

            Console.WriteLine($"O valor faturado pelo estado de São Paulo representa {(sp * 100) / total}% do total faturado");
            Console.WriteLine($"O valor faturado pelo estado do Rio de Janeiro representa {(rj * 100) / total}% do total faturado");
            Console.WriteLine($"O valor faturado pelo estado de Minas Gerais representa {(mg * 100) / total}% do total faturado");
            Console.WriteLine($"O valor faturado pelo estado do Espiríto Santo representa {(es * 100) / total}% do total faturado");
            Console.WriteLine($"O valor faturado pelos outros estados representa {(outros * 100) / total}% do total faturado");

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace inverte_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> palavra = new Queue<string>();
            Stack<string> inversao = new Stack<string>();

            Console.WriteLine("Quantas letras tem a string que será invertida?");
            int letras = int.Parse(Console.ReadLine());
            for (int i = 1; i <= letras; i++)
            {
                Console.WriteLine($"Digite a {i}ª letra:");
                palavra.Enqueue(Console.ReadLine());
            }

            Console.Clear();

            while (palavra.Count > 0)
                inversao.Push(palavra.Dequeue());

            while (inversao.Count > 0)
                Console.WriteLine(inversao.Pop());

            Console.WriteLine("Pressione enter para encerrar");
            Console.ReadLine();
        }
    }
}

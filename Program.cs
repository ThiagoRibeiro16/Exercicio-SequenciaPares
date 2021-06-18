using System;

namespace Exercicio_SequenciaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int i = 0;
            int entrada;

            Console.WriteLine("Sequência pares");
            Console.WriteLine("----------------");

            Console.Write("Digite um número inteiro positivo e veja todos os números pares entre zero e o número digitado: ");
            bool numeroValido = int.TryParse(Console.ReadLine(), out entrada);
           Console.WriteLine();

            if (!numeroValido)

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDigite apenas números inteiros");
                Console.ResetColor();
                Environment.Exit(-1);


            }

            for (i = 0; i <= entrada; i += 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($" {i} ");
                Console.ResetColor();
              
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
           Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("\nObrigado por utilizar nosso programa");
            Console.ResetColor();

        }
    }
}

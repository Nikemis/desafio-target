using System;

namespace Target
{
    class Program
    {
        static int Verificacao(int n)
        {
            if (n < 0)
            {
                return 0; 
            }

            if (n == 0 || n == 1)
            {
                return 1; 
            }

            int a = 0, b = 1;

            while (b < n)
            {
                int proximo = a + b;
                a = b;
                b = proximo;
            }

            if (b == n)
            {
                return 1; 
            }
            else
            {
                return 0; 
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Insira um número: ");
            int numero = int.Parse(Console.ReadLine());

            int resultado = Verificacao(numero);

            if (resultado == 1)
            {
                Console.WriteLine("{0} pertence à sequência de Fibonacci.", numero);
            }
            else
            {
                Console.WriteLine("{0} NÃO pertence à sequência de Fibonacci.", numero);
            }
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe um número para verificar se está na sequência de Fibonacci: ");
        int numero = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;

        if (numero == a || numero == b)
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            return;
        }

        int proximo = a + b;
        while (proximo <= numero)
        {
            if (proximo == numero)
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
                return;
            }
            a = b;
            b = proximo;
            proximo = a + b;
        }

        Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
    }
}

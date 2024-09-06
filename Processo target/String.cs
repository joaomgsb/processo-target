using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe uma string para verificar quantas vezes a letra 'a' aparece:");
        string input = Console.ReadLine();

        int cont = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'a' || input[i] == 'A')
            {
                cont++;
            }
        }

        Console.WriteLine($"A letra 'a' aparece {cont} vezes na string informada.");
    }
}

using System;

class Program
{
    static void Main()
    {
        int INDICE = 12;
        int SOMA = 0;
        int K = 1;

        while (K < INDICE)
        {
            K = K + 1; 
            SOMA = SOMA + K; 
        }

        Console.WriteLine(SOMA);
        //Resposta: O valor da variavel soma é igual a 77
    }
}
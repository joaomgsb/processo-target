using System;

class Program
{
    static void Main()
    {
        // Sequência a)
        Console.WriteLine("Próximo elemento da sequência a) 1, 3, 5, 7: " + ProximoElementoSequenciaA());

        // Sequência b)
        Console.WriteLine("Próximo elemento da sequência b) 2, 4, 8, 16, 32, 64: " + ProximoElementoSequenciaB());

        // Sequência c)
        Console.WriteLine("Próximo elemento da sequência c) 0, 1, 4, 9, 16, 25, 36: " + ProximoElementoSequenciaC());

        // Sequência d)
        Console.WriteLine("Próximo elemento da sequência d) 4, 16, 36, 64: " + ProximoElementoSequenciaD());

        // Sequência e)
        Console.WriteLine("Próximo elemento da sequência e) 1, 1, 2, 3, 5, 8: " + ProximoElementoSequenciaE());

        // Sequência f)
        Console.WriteLine("Próximo elemento da sequência f) 2, 10, 12, 16, 17, 18, 19: " + ProximoElementoSequenciaF());
    }

    static int ProximoElementoSequenciaA()
    {
        return 9; // 1, 3, 5, 7, ...
    }

    static int ProximoElementoSequenciaB()
    {
        return 128; // 2, 4, 8, 16, 32, 64, ...
    }

    static int ProximoElementoSequenciaC()
    {
        return 49; // 0, 1, 4, 9, 16, 25, 36, ...
    }

    static int ProximoElementoSequenciaD()
    {
        return 100; // 4, 16, 36, 64, ...
    }

    static int ProximoElementoSequenciaE()
    {
        return 13; // 1, 1, 2, 3, 5, 8, ...
    }

    static int ProximoElementoSequenciaF()
    {
        return 200; // 2, 10, 12, 16, 17, 18, 19, ...
    }
}
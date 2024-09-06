using System;

class Program
{
    static void Main()
    {
        // Simulando as lâmpadas
        bool[] lampadas = new bool[3];
        bool[] quente = new bool[3]; // Para marcar se a lâmpada está quente
        int escolha;

        // Informações para o usuário
        Console.WriteLine("Há três interruptores e três lâmpadas em salas diferentes.");
        Console.WriteLine("Seu objetivo é descobrir qual interruptor controla qual lâmpada.");

        // Simulação de ligar os interruptores
        Console.WriteLine("\nLigando o primeiro interruptor por algum tempo...");
        lampadas[0] = true;
        quente[0] = true; // A lâmpada do primeiro interruptor ficará quente após ser desligada

        Console.WriteLine("Agora, desligue o primeiro interruptor e ligue o segundo.");
        lampadas[0] = false; // Primeiro interruptor desligado
        lampadas[1] = true; // Segundo interruptor ligado

        // Pergunta ao usuário
        Console.WriteLine("\nAgora vá até a sala das lâmpadas.");
        Console.WriteLine("Escolha uma lâmpada para verificar: 1, 2 ou 3");
        escolha = int.Parse(Console.ReadLine()) - 1;

        // Verificar qual lâmpada foi escolhida e dar a resposta
        if (lampadas[escolha] == true)
        {
            Console.WriteLine("Esta lâmpada está acesa. Ela está conectada ao segundo interruptor.");
        }
        else if (quente[escolha] == true)
        {
            Console.WriteLine("Esta lâmpada está apagada, mas quente. Ela está conectada ao primeiro interruptor.");
        }
        else
        {
            Console.WriteLine("Esta lâmpada está apagada e fria. Ela está conectada ao terceiro interruptor.");
        }
    }
}

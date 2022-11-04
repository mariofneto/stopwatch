﻿
class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundo");
        Console.WriteLine("M = Minuto");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto tempo deseja contar?");
    }
    static void Start(int time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000); // serve para dar um descanso de 1 segundo antes da próxima repetição!
        }
        Console.Clear();
        Console.WriteLine("StopWatch finalizado!");
        Thread.Sleep(2500);
        Menu();
    }
}
using System;
using projetoRPG.src.Entities;

public class Program
{
    static void Main()
    {
        Character hero = new Character("Arus", 1, "Heroi");
        Wizzard jenifer = new Wizzard("Jen",1,"mago");

        Console.WriteLine(hero);
        Console.WriteLine(jenifer);
    }
}
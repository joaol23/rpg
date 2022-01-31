using System;
using static System.Console;
using projetoRPG.src.Entities;

public class Program
{

    static string[] getClasses()
    {
        return new string[] { "Knight", "Wizzard", "Gunslinger", "Ranger" };
    }
    static void ChooseCharacter()
    {
        WriteLine("======== Welcome to the RPG Project ========\n======== Please create your character! ========");

        string[] classes = getClasses();

        for (int i = 0; i < classes.Length; i++)
        {
            WriteLine(i + 1 + " - " + classes[i]);
        }
        WriteLine("x - sair");

        var choice = ReadLine();
        var Name = ChooseName();

        var character = ChooseClass(choice, Name);
    }

    static string ChooseName()
    {
        WriteLine();
        WriteLine("======== Choose the name of your character ========");

        return ReadLine();
    }
    static object ChooseClass(string choice, string name)
    {
        while (choice.ToUpper() != "X")
        {
            if (choice == "1")
            {
                Knight hero = new Knight(name);
                return hero;
            }
            else if (choice == "2")
            {
                Wizzard mage = new Wizzard(name);
                return mage;
            }
            else if (choice == "3")
            {
                Gunslinger gunslinger = new Gunslinger(name);
                return gunslinger;
            }
            else if (choice == "4")
            {

                Ranger ranger = new Ranger(name);
                return ranger;
            }else{
                throw new ArgumentException();
            }
        }
        return false;
    }

    static void Main()
    {
        ChooseCharacter();
    }
}
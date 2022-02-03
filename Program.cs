using System;
using static System.Console;
using projetoRPG.src.Entities;
using static System.Threading.Thread;

public class Program
{

    static void WriteClasses()
    {
        string[] classes = getClasses();
        for (int i = 0; i < classes.Length; i++)
        {
            WriteLine(i + 1 + " - " + classes[i]);
        }

    }

    static string[] getClasses()
    {
        return new string[] { "Knight", "Wizzard", "Gunslinger", "Ranger" };
    }
    static object ChooseCharacter()
    {
        WriteLine();
        WriteLine("======== Welcome to the RPG Project ========\n======== Please create your character! ========");


        WriteClasses();
        WriteLine("5 - Info");
        WriteLine("x - Leave");
        WriteLine();

        var choice = ReadLine();

        if (choice == "x")
        {
            return false;
        }

        if (choice == "5")
        {
            Info();
            return false;
        }
        else
        {
            var Name = ChooseName();

            var character = ChooseClass(choice, Name);

            return character;
        }
    }

    static void Info()
    {
        WriteLine();
        WriteLine("======== Choose a class for info ========");
        WriteClasses();
        WriteLine();

        var choice = ReadLine();

        var info = ChooseClass(choice, "Info", true);

        WriteLine();
        WriteLine(info);
        Sleep(4000);

        ChooseCharacter();
    }

    static string ChooseName()
    {
        WriteLine();
        WriteLine("======== Choose the name of your character ========");

        return ReadLine();
    }
    static object ChooseClass(string choice, string name, bool info = false)
    {
        if (choice == "1")
        {
            Knight hero = new Knight(name);
            hero.SetAttacks();
            if (info)
            {
                return hero.Info();
            }
            return hero;
        }
        else if (choice == "2")
        {
            Wizzard mage = new Wizzard(name);
            mage.SetAttacks();
            if (info)
            {
                return mage.Info();
            }
            return mage;
        }
        else if (choice == "3")
        {
            Gunslinger gunslinger = new Gunslinger(name);
            gunslinger.SetAttacks();
            if (info)
            {
                return gunslinger.Info();
            }
            return gunslinger;
        }
        else if (choice == "4")
        {
            Ranger ranger = new Ranger(name);
            ranger.SetAttacks();
            if (info)
            {
                return ranger.Info();
            }
            return ranger;
        }
        else
        {
            throw new ArgumentException();
        }
    }

    static void Main()
    {
        var character = ChooseCharacter();
        if (!character.Equals(false))
        {
            WriteLine();
            WriteLine("Seu personagem");
            WriteLine(character);
        }
    }
}
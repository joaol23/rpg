﻿using System;
using static System.Console;
using projetoRPG.src.Entities;

public class Program
{

    static string[] getClasses()
    {
        return new string[] { "Knight", "Wizzard", "Gunslinger", "Ranger" };
    }
    static object ChooseCharacter()
    {
        WriteLine("======== Welcome to the RPG Project ========\n======== Please create your character! ========");

        string[] classes = getClasses();

        for (int i = 0; i < classes.Length; i++)
        {
            WriteLine(i + 1 + " - " + classes[i]);
        }
        WriteLine("5 - Info");
        WriteLine("x - Leave");

        var choice = ReadLine();

        if (choice == "x")
        {
            return false;
        }
        var Name = ChooseName();

        var character = ChooseClass(choice, Name);

        return character;
    }

    static string ChooseName()
    {
        WriteLine();
        WriteLine("======== Choose the name of your character ========");

        return ReadLine();
    }
    static object ChooseClass(string choice, string name)
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
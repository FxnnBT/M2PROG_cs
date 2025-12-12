using System;
using System.Collections.Generic;

namespace Lists;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
    void Run()
    {
        lists();
    }

    internal void lists()
    {
        string[] charachters = new string[] {
            "Pac-Man",
            "Samus",
            "Crash Bandicoot",
            "Spyro the Dragon",
            "Donkey Kong",
            "Mario",
            "Luigi",
            "Astro",
            "Solid Snake",
            "Master Chief",
            "Kratos",
            "Sonic the Hedgehog",
            "Link"
        };
        List<string> characterList = new List<string>();

        characterList.Add("Jack Cooper");

        foreach (string character in charachters)
        {
            characterList.Add(character);
        }

        for (int i = 0; i < characterList.Count; i++)
        {
            Console.WriteLine(characterList[i]);
        }
    }
}

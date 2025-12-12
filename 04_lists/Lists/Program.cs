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
        lists3();
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

    internal void lists2()
    {
        List<double> reviews = new List<double>() { 9.99, 4.68, 342.97, 12.2 };

        reviews.Remove(342.97);
        reviews.RemoveAt(0);

        foreach (double review in reviews)
        {
            Console.WriteLine(review);
        }
    }

    internal void lists3()
    {
        List<Pickup> pickups = new List<Pickup>();

        for (int i = 0; i < 10; i++)
        {
            Pickup pickup = new Pickup()
            {
                x = i,
                y = 0
            };
            pickups.Add(pickup);
        }
        /*
        foreach (Pickup pickup in pickups)
        {
            if(pickup.x == 4){
                pickups.Remove(pickup);
            }
        }
        */
        for (int i = pickups.Count - 1; i >= 0; i--)
        {
            if (pickups[i].x == 4)
            {
                Console.WriteLine($"removed pickup {pickups[i].x}");
                pickups.RemoveAt(i);
            }
        }
        foreach (Pickup pickup in pickups)
        {
            Console.WriteLine("pickup " + pickup.x + " is still here");
        }
    }
}

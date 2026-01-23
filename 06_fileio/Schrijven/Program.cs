namespace Schrijven;
using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
    internal void Run()
    {
        string[] lines = { "Regel 1", "Regel 2", "Regel 3" };
        File.WriteAllLines("mijnregels.txt", lines);

        string text = File.ReadAllText("Favogame.json");
        FavoriteGame[] favogames = JsonSerializer.Deserialize<FavoriteGame[]>(text);
        foreach (FavoriteGame game in favogames)
        {
            Console.WriteLine(game.Name);
            Console.WriteLine(game.Platform);
        }
        //File.WriteAllText("mijntekst.txt", "Dit is een test");
    }
}

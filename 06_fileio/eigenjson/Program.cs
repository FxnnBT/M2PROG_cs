namespace eigenjson;
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
        string text = File.ReadAllText("Player.json");
        PlayerInfo[] players = JsonSerializer.Deserialize<PlayerInfo[]>(text);
        foreach (PlayerInfo player in players)
        {
            Console.WriteLine(player.name);
            Console.WriteLine(player.TitanType);
            Console.WriteLine(player.Health + ",");
        }
    }
}

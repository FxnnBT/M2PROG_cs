namespace fileio;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
    void Run()
    {
        ReadFile();
    }

    private void ReadFile()
    {
        /*Console.WriteLine(Environment.CurrentDirectory);
        string[] lines = File.ReadAllLines("quiz.txt");
        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine($"{i + 1}: {lines[i]}");
        } */

        Console.WriteLine(Environment.CurrentDirectory);
        string[] lines = File.ReadAllLines("nos.txt");
        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine($"{i + 1}: {lines[i]}");
        }
    }

}

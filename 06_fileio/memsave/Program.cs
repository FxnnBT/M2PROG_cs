namespace memsave;

class Program
{
    string welkomstTekst = "hello world";
    string saveFile = "welkomState.txt";

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
    internal void Run()
    {
        bool bestaatDeFile = File.Exists(saveFile);
        if (bestaatDeFile == true)
        {
            welkomstTekst = File.ReadAllText(saveFile);
        }
        Console.WriteLine(welkomstTekst);

        while (true)
        {
            Console.WriteLine(welkomstTekst);
            Console.WriteLine("Enter a text, then press enter");
            welkomstTekst = Console.ReadLine();
            File.WriteAllText(saveFile, welkomstTekst);
        }

    }
}

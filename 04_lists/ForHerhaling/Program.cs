namespace ForHerhaling;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
    void Run()
    {
        arrays();
    }

    internal void arrays()
    {
        double[] prijzen = new double[] { 0.99, 5.60, 10.11, 7.50 };
        string[] artiekelen = { "snoepje", "luxe broodje", "lunch menu", "salade" };
        Formulier[] formulieren = new Formulier[2];

        formulieren[0] = new Formulier()
        {
            Feedback = "prijzig maar lekker",
            Sterren = 5
        };
        formulieren[1] = new Formulier()
        {
            Feedback = "goedkoop en snel",
            Sterren = 3
        };
        for (int i = 0; i < prijzen.Length; i++)
        {
            Console.WriteLine(prijzen[i]);
            Console.WriteLine(artiekelen[i]);
        }
        foreach (Formulier formulier in formulieren)
        {
            Console.WriteLine(formulier.Feedback + " " + formulier.Sterren);
        }
    }

    internal class Formulier
    {
        internal int Sterren{get; set;}
        internal string Feedback{get; set;}
    }
}

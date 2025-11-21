namespace function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program(); // de 2e program is de variabele
            program.Run();
        }

         internal void Run()
        {
            Console.WriteLine("program gestart");
            return; // stopt de functie
        }

    }
}

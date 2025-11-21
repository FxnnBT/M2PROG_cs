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
            vraag1();
            vraag2();
            vraag3();
            vraag4();
            vraag5();
            Console.WriteLine("Dat was t de ballen");
            return; // stopt de functie
        }
        internal void vraag1()
        {
            Console.WriteLine("hoeveel mannen zijn door bonnie blue heen gegaan");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
            return;
        }
        internal void vraag2()
        {
            Console.WriteLine("Hoeveel views heeft de meest bekeken video op youtube");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
            return;
        }
        internal void vraag3()
        {
            Console.WriteLine("Wat is de hoofdstad van nederland");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
            return;
        }
        internal void vraag4()
        {
            Console.WriteLine("Wat is de beste programmeertaal");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
            return;
        }
        internal void vraag5()
        {
            Console.WriteLine("Wat is beter powershell of cmd");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
            return;
        }

    }
}

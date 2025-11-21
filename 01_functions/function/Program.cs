namespace function
{
    internal class Program
    {
        string[] vragen = new string[]
        {
            "hoeveel mannen zijn door bonnie blue heen gegaan",
            "Hoeveel views heeft de meest bekeken video op youtube",
            "Wat is de hoofdstad van nederland",
            "Wat is de beste programmeertaal",
            "Wat is beter powershell of cmd",
            "Wat komt eerder GTA 6 of PS6"
        };
    
        static void Main(string[] args)
        {
            Program program = new Program(); // de 2e program is de variabele
            program.Run();
        }

         internal void Run()
        {
            Console.WriteLine("program gestart");
            string randomVraag = GetRandomVraag();
            string antwoord = Console.ReadLine();
            //string vraag0 = GetVraag(0);
           /* string mannen = vraag1();
            string views = vraag2();
            string hoofdstad = vraag3();
            string progtaal = vraag4();
            string cmdofpws = vraag5();
            string game = vraag6();
            string snack = vraag7();
            */
            Console.WriteLine("Dat was t de ballen");
            return; // stopt de functie
        }
        internal string vraag1()
        {
            Console.WriteLine("hoeveel mannen zijn door bonnie blue heen gegaan");
            string antwoord = Console.ReadLine();
            return antwoord;
        }
        internal string vraag2()
        {
            Console.WriteLine("Hoeveel views heeft de meest bekeken video op youtube");
            string antwoord = Console.ReadLine();
            return antwoord;
        }
        internal string vraag3()
        {
            Console.WriteLine("Wat is de hoofdstad van nederland");
            string antwoord = Console.ReadLine();
            return antwoord;
        }
        internal string vraag4()
        {
            Console.WriteLine("Wat is de beste programmeertaal");
            string antwoord = Console.ReadLine();
            return antwoord;
        }
        internal string vraag5()
        {
            Console.WriteLine("Wat is beter powershell of cmd");
            string antwoord = Console.ReadLine();
            return antwoord;
        }
        internal string vraag6()
        {
            Console.WriteLine("Wat komt eerder GTA 6 of PS6");
            string antwoord = Console.ReadLine();
            return antwoord;
        }
        internal string vraag7()
        {
            Console.WriteLine("Wat is de beste snack");
            string antwoord = Console.ReadLine();
            return antwoord;
        }
        internal string GetVraag(int vraagIndex)
        {
            Console.WriteLine(vragen[vraagIndex]);
            return vragen[vraagIndex];
        }
        internal string GetRandomVraag()
        {
            int random = new Random().Next(0, vragen.Length);
            return GetVraag(random);
        }

    }
}

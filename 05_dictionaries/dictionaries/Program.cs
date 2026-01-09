namespace dictionaries;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    void Run()
    {
        dictionaries();
    }

    internal void dictionaries(){
        Dictionary<int, string> personeelopnummer = new Dictionary<int, string>();
        
        personeelopnummer.Add(69, "John pork");
        personeelopnummer.Add(67, "Jane Doe");

        string JohnPork = personeelopnummer[69];
        string JaneDoe = personeelopnummer[67];
        //Console.WriteLine(JohnPork);
        //Console.WriteLine(JaneDoe);

        foreach (KeyValuePair<int, string> item in personeelopnummer)
        {
            //Console.WriteLine($"{item.Key}: {item.Value}");
        }
        foreach (int key in personeelopnummer.Keys)
        {
            Console.WriteLine(key);
        }
        foreach (string value in personeelopnummer.Values)
        {
            Console.WriteLine(value);
        }
    }
}

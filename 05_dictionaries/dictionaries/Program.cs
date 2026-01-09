namespace dictionaries;

class Program
{
    private Dictionary<string, Room> rooms = new Dictionary<string, Room>();

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    void Run()
    {
        dictionaries();
        Rooms();
        ShowRoom(0, 0);
        ShowRoom(1, 0);
        ShowRoom(1, 1);
        ShowRoom(0, 1);
        ShowRoom(2, 2);
        
    }

    internal void dictionaries()
    {
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


    internal void Rooms()
    {
        Room start = new Room(0, 0, [
        "#####",
        "#   #"
        ,"#   #"
        ,"#   #"
        ,"#####",]);

        Room room1 = new Room(1, 0, [
        "#####",
        "#   #"
        ,"#   #"
        ,"#   #"
        ,"#####",]);

        Room room2 = new Room(1, 1, [
        "#####",
        "#   #"
        ,"#   #"
        ,"#   #"
        ,"#####",]);
        Room room3 = new Room(0, 1, [
        "#####",
        "#   #"
        ,"#   #"
        ,"#   #"
        ,"#####",]);

        rooms.Add(start.GetRoomLocationKey(), start);
        rooms.Add(room1.GetRoomLocationKey(), room1);
        rooms.Add(room2.GetRoomLocationKey(), room2);
        rooms.Add(room3.GetRoomLocationKey(), room3);
    }

    private void ShowRoom(int x, int y)
    {
        bool hasRoom = rooms.ContainsKey($"{x},{y}");
        if (hasRoom)
        {
            Room room = rooms[$"{x},{y}"];
            Console.WriteLine($"You are in room {x},{y}");
            foreach (string r in room.level)
            {
                Console.WriteLine(r);
            }
        }
        else
        {
            Console.WriteLine("Error 404 Room not found");
        }
    }




}

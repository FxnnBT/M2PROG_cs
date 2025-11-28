namespace rijschool;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    internal void Run()
    {
        Auto auto1 = new Auto()
        {
            automaat = true,
            kenteken = "AA824H",
            kilometersStand = 120000,
            merk = "volkswagen",
        };
        Auto auto2 = new Auto()
        {
            automaat = false,
            kenteken = "KU786G",
            kilometersStand = 67000,
            merk = "volvo",
        };

        RijLeraar rijLeraar = new RijLeraar()
        {
            leeftijd = 30,
            naam = "John",
            zzp = false,
        };
        LesUur lesUur = new LesUur()
        {
            auto = auto1,
            rijLeraar = rijLeraar,
            tijd = 1130,
        };
        
        LesUur lesUur2 = new LesUur()
        {
            auto = auto2,
            rijLeraar = rijLeraar,
            tijd = 1400,
        };
        
        Student student1 = new Student()
        {
            naam = "Zakaria",
            leeftijd = 17,
            LesPakket = 20,
            theoritest = false,
            rijtest = false,
            lesUur = lesUur,
        };
        Student student2 = new Student()
        {
            naam = "Sven",
            leeftijd = 17,
            LesPakket = 10,
            theoritest = true,
            rijtest = false,
            lesUur = lesUur2,
        };
        Dag dag = new Dag()
        {
            lesUren = new LesUur[] { lesUur, lesUur2 }
        };

    }
}

namespace Constructors;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
    private void Run()
    {
        QuizVraag quizVraag = new QuizVraag("hier komt de vraag", "hier komt het antwoord");
        Quiz quiz = new Quiz(10);
        quiz.VoegVraagToeOpIndex(0, quizVraag);
        quiz.VoegVraagToeOpIndex(1, "wat is 2+2?", "4");
        quiz.VoegVraagToeOpIndex(2, "wat is de hoofdstad van Nederland?", "Amsterdam");
        quiz.VoegVraagToeOpIndex(3, "wat is de hoofdstad van Frankrijk?", "Parijs");
        quiz.VoegVraagToeOpIndex(4, "wat is de hoofdstad van Duitsland?", "Berlijn");
        quiz.VoegVraagToeOpIndex(5, "wat is de hoofdstad van België?", "Brussel");
        quiz.VoegVraagToeOpIndex(6, "wat is de hoofdstad van Italië?", "Rome");
        quiz.VoegVraagToeOpIndex(7, "wat is de hoofdstad van Spanje?", "Madrid");
        quiz.VoegVraagToeOpIndex(8, "wat is de hoofdstad van Portugal?", "Lissabon");
        quiz.VoegVraagToeOpIndex(9, "wat is de hoofdstad van Engeland?", "Londen");
        Console.WriteLine(quiz.vragen[0].vraag);
        Console.ReadLine();
        Console.WriteLine(quiz.vragen[1].vraag);
        Console.ReadLine();
        Console.WriteLine(quiz.vragen[2].vraag);
        Console.ReadLine();
        Console.WriteLine(quiz.vragen[3].vraag);
        Console.ReadLine();
        Console.WriteLine(quiz.vragen[4].vraag);
        Console.ReadLine();
        Console.WriteLine(quiz.vragen[5].vraag);
        Console.ReadLine();
        Console.WriteLine(quiz.vragen[6].vraag);
        Console.ReadLine();
        Console.WriteLine(quiz.vragen[7].vraag);
        Console.ReadLine();
        Console.WriteLine(quiz.vragen[8].vraag);
        Console.ReadLine();
        Console.WriteLine(quiz.vragen[9].vraag);
        Console.ReadLine();
    }
}

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
    }
}

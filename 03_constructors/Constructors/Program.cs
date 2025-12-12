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
        QuizVraag quizVraag = new QuizVraag("hoe oud is bill gates?", "70");
        QuizVraag quizVraag2 = new QuizVraag("hier komt de vraag", "hier komt het antwoord");
        QuizVraag quizVraag3 = new QuizVraag("hier komt de vraag", "hier komt het antwoord");
        QuizVraag quizVraag4 = new QuizVraag("hier komt de vraag", "hier komt het antwoord");
        QuizVraag quizVraag5 = new QuizVraag("hier komt de vraag", "hier komt het antwoord");
        QuizVraag quizVraag6 = new QuizVraag("hier komt de vraag", "hier komt het antwoord");
        QuizVraag quizVraag7 = new QuizVraag("hier komt de vraag", "hier komt het antwoord");
        QuizVraag quizVraag8 = new QuizVraag("hier komt de vraag", "hier komt het antwoord");
        QuizVraag quizVraag9 = new QuizVraag("hier komt de vraag", "hier komt het antwoord");
        Quiz quiz = new Quiz(10);
       quiz.VoegVraagToeOpIndex(0, quizVraag);

    }
}

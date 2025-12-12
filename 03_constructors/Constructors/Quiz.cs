namespace Constructors;

class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldeAntwoorden;

    internal Quiz(int aantalVragen)
    {
        vragen = new QuizVraag[aantalVragen];
    }
    internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
    {
        vragen[index] = vraag;
    }

    internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
    {
        vragen[index] = new QuizVraag(vraag, antwoord);
    }
    internal void StelVraag(int index)
    {
        QuizVraag vraag = vragen[index];
        QuizVraagAntwoord quizVraagAntwoord = new QuizVraagAntwoord(vraag);
        Console.WriteLine(vraag.vraag);
        string antwoord = Console.ReadLine();
        if (antwoord == vraag.antwoord)
        {
            quizVraagAntwoord.goed = true;
        }
        else if (antwoord != vraag.antwoord)
        {
            quizVraagAntwoord.goed = false;
        }
    }

}
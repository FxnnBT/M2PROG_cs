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
}
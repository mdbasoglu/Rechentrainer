using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiplikationsquiz quiz = new Multiplikationsquiz();
            Console.WriteLine(quiz.Frage);
            Console.WriteLine("Ergebnis : " + quiz.Antwort);
        }
    }
}

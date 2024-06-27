using System;
namespace CountingMonkeys
{
    public class TaskSubtraction : ITask
    {
        public int NumberOne { get; private set; }
        public int NumberTwo { get; private set; }
        public int CorrectAnswer { get { return NumberOne - NumberTwo; } }


        public TaskSubtraction()
        {
            Random rand = new Random();
            NumberOne = rand.Next(1, 101);
            NumberTwo = rand.Next(1, (NumberTwo + 1)); //Not to get negative number as a result
        }

        public void DisplayQuestion()
        {
            Console.WriteLine("");
            Console.WriteLine($"Kolik je {NumberOne} - {NumberTwo}?");
            Console.WriteLine();
        }
    }
}

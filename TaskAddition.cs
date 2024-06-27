using System;
namespace CountingMonkeys
{
    public class TaskAddition : ITask
    {
        public int NumberOne { get; private set; }
        public int NumberTwo { get; private set; }
        public int CorrectAnswer { get { return NumberOne + NumberTwo; } }


        public TaskAddition()
        {
            Random rand = new Random();
            NumberOne = rand.Next(1, 51);
            NumberTwo = rand.Next(1, 51);
        }

        public void DisplayQuestion()
        {
            Console.WriteLine("");
            Console.WriteLine($"Kolik je {NumberOne} + {NumberTwo}?");
            Console.WriteLine();
        }
    }
}

namespace CountingMonkeys
{
    public class TaskMultiplication: ITask
    {
        public int NumberOne { get; private set; }
        public int NumberTwo { get; private set; }
        public int CorrectAnswer { get { return NumberOne * NumberTwo; } }


        public TaskMultiplication()
        {
            Random rand = new Random();
            NumberOne = rand.Next(1, 10);
            NumberTwo = rand.Next(1, 10);
        }

        public void DisplayQuestion()
        {
            Console.WriteLine($"Kolik je {NumberOne} * {NumberTwo}?");
            Console.WriteLine();
        }
    }
}
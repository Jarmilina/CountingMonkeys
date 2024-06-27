namespace CountingMonkeys
{
    public class TaskDivision : ITask
    {
        public int Dividend { get; private set; }
        public int Divisor { get; private set; }
        public int CorrectAnswer { get { return Dividend / Divisor; } }


        public TaskDivision()
        {
            Random rand = new Random();
            Dividend = rand.Next(1, 101);
            Divisor = GetDivisor(Dividend);
        }

        public void DisplayQuestion()
        {
            Console.WriteLine("");
            Console.WriteLine($"Kolik je {Dividend} / {Divisor}?");
            Console.WriteLine();
        }

        internal int GetDivisor(int dividend)
        {
            Random rand = new Random();
            int divisorTrial = rand.Next(1, 11);
            int divisor;

            if (dividend % divisorTrial == 0)
            {
                divisor = divisorTrial;
                return divisor;
            }
            else
            {
                return GetDivisor(dividend);
            }
        }
    }
}

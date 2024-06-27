namespace CountingMonkeys
{
    public abstract class User
    {
        public string Salutation { get; set; }

        public string FirstLetter { get; set; }

        public int Score { get; set; }

        public User(string firstLetter)
        {
            FirstLetter = firstLetter;
        }

        public abstract void Welcome();

        public abstract (bool isNumber, int userAnswer) Answer();

        public void IncreaseScore()
        {
            Score++;
        }

        public void SayGoodbye()
        {
            Console.WriteLine($"Nashledanou, opičko {Salutation}! Přijď si zase někdy započítat!");
            Console.WriteLine("");
            Console.WriteLine("  _\\|/_  ");
            Console.WriteLine("@(O v O)@");
            Console.WriteLine("  (_T_)   ");
        }
    }
}
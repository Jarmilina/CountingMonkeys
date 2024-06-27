namespace CountingMonkeys
{
    internal class Johanka : User, ILiterate
    {
        public string Salutation = "Johanko";
        public int Score { get; set; }
        public Johanka(string firstLetter) : base(firstLetter)
        {
            Salutation = "Johanko";
        }

        public override void Welcome()
        {
            Console.WriteLine("");
            Console.WriteLine($"{Salutation}, připrav se, jdeme počítat! :)");
            Console.WriteLine("");

        }

        public override (bool isNumber, int userAnswer) Answer()
        {
            string userInput = Console.ReadLine();
            int userAnswer;
            bool isNumber = int.TryParse(userInput, out userAnswer);
            return (isNumber, userAnswer);
        }
    }
}

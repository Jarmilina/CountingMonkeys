namespace CountingMonkeys
{
    internal class Vileminka : User, ILiterate
    {
        public string Salutation { get; set; }
        public int Score { get; set; }
        public Vileminka(string firstLetter) : base(firstLetter)
        {
            Salutation = "Vilemínko";
        }

        public override void Welcome()
        {
            Console.WriteLine("");
            Console.WriteLine($"{Salutation}, připrav se, jdeme počítat! :)");
            Console.WriteLine("");
        }

        public override (bool isNumber, int userAnswer) Answer()
        {
            Console.Write("Kolik jich je? Napiš číslo: ");
            string userInput = Console.ReadLine();
            int userAnswer;
            bool isNumber = int.TryParse(userInput, out userAnswer);
            return (isNumber, userAnswer);
        }
    }
}
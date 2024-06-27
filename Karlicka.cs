namespace CountingMonkeys
{
    internal class Karlicka : User, ILiterate
    {
        public string Salutation = "Karličko";
        public Karlicka(string userName) : base(userName)
        {
            Salutation = "Karličko";
        }

        public override void Welcome()
        {
            Console.WriteLine("");
            Console.WriteLine($"{Salutation}, připrav se, jdeme počítat! :)");
            Console.WriteLine("");

        }


        public override (bool isNumber, int userAnswer) Answer()
        {
            Console.Write("Kolik jich tu máme? Napiš číslo: ");
            string userInput = Console.ReadLine();
            int userAnswer;
            bool isNumber = int.TryParse(userInput, out userAnswer);
            return (isNumber, userAnswer);
        }
    }
}

namespace CountingMonkeys
{
    public class Validator
    {
        public bool isValidName = false;
        public Validator()
            {
            }

        internal string ValidateUser(string userName)
        {
            // Define valid names
            List<string> validNames = new List<string> { "j", "k", "v" };

            if (validNames.Contains(userName))
            {
                return userName;
            }

            // Check if userName is in validNames
            else
            {
                Console.WriteLine("Napiš první písmeno svého jména. Napiš J, K, nebo V. Potom stiskni Enter");
                Console.WriteLine("");
                userName = Console.ReadLine().ToLower();
                if (validNames.Contains(userName))
                {
                    return userName;
                }
                else
                {
                    return ValidateUser(userName);
                }
            }
        }

        internal bool ValidateAnswer(bool isNumber, int userAnswer, ITask task)
        {
            bool isValidAnswer = (isNumber && userAnswer == task.CorrectAnswer);

            return isValidAnswer;
        }
    }
}

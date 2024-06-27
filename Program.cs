using CountingMonkeys;

internal class Program
{
    static void Main(string[] args)
    {
        Validator validator = new Validator();

        Console.WriteLine("  Ahoj! Která opička počítá?");
        Console.WriteLine("");
        Console.WriteLine("     V jako Vilemínka");
        Console.WriteLine("     J jako Johanka");
        Console.WriteLine("     K jako Karlička");
        Console.WriteLine("");
        Console.WriteLine("  Napiš V, J nebo K a zmáčkni Enter.");
        Console.WriteLine("");

        string player = Console.ReadLine().ToLower();
        string firstLetter = validator.ValidateUser(player);

        User user = null;

        switch (firstLetter)
        {
            case "k":
                user = new Karlicka(player);
                break;
            case "j":
                user = new Johanka(player);
                break;
            case "v":
                user = new Vileminka(player);
                break;
        }

        PlayGame(user, validator);

        user.SayGoodbye();
    }



    static void PlayGame(User user, Validator validator)
    {
        user.Welcome();
        bool continuePlaying = true;
        while (continuePlaying)
        {

            ITask task = null;
            if (user is Karlicka)
            {
                task = new TaskCountingObjects();
            }
            else if (user is Vileminka || user is Johanka)
            {
                Random rand = new Random();
                int taskType = rand.Next(1, 5);

                switch (taskType)
                {
                    case 1:
                        task = new TaskAddition();
                        break;
                    case 2:
                        task = new TaskSubtraction();
                        break;
                    case 3:
                        task = new TaskMultiplication();
                        break;
                    case 4:
                        task = new TaskDivision();
                        break;
                }
            }

            task.DisplayQuestion();

            var answer = user.Answer();

            // Check the answer, repeat question twice more if incorrect,
            // then write correct answer
            if (validator.ValidateAnswer(answer.isNumber, answer.userAnswer, task))
            {
                Console.WriteLine("");
                Console.WriteLine("Správně!");
                user.IncreaseScore();
            }
            else
            {
                for (int i = 2; i > 0; i--)
                {
                    Console.WriteLine("");
                    Console.WriteLine("To není správně. Zkus to znovu!");
                    Console.WriteLine("");
                    task.DisplayQuestion();
                    var newAnswer = user.Answer();
                    bool isValidAnswer = validator.ValidateAnswer(newAnswer.isNumber, newAnswer.userAnswer, task);
                    if (!isValidAnswer)
                    {
                        Console.WriteLine($"Správná odpověď je {task.CorrectAnswer}.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        user.IncreaseScore();
                    }
                }
            }

            // Display current score
            Console.WriteLine($"Tvoje skóre: {user.Score}");

            //Ask if the user wants to continue -- Comenting out as this gets
            //annoying and does not currently have any further value
            //Console.Write("Chceš si ještě započítat? (a/n): ");
            //string continueCounting = Console.ReadLine().ToLower();
            //continuePlaying = continueCounting == "a";
        }
    }
}

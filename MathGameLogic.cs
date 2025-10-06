namespace MathGame
{
    public class MathGameLogic
    {
        public List<string> GameHistory { get; set; } = new List<string>();

        public void ShowMenu()
        {
            Console.WriteLine("Welcome to the Math Game!");
            Console.WriteLine("Choose an operation by typing the corresponding number:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. View Game History");
            Console.WriteLine("6. Exit");
        }

        public void StartGame()
        {
            bool exit = false;
            while (!exit)
            {
                ShowMenu();
                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        PlayGame("Addition");
                        break;
                    case "2":
                        PlayGame("Subtraction");
                        break;
                    case "3":
                        PlayGame("Multiplication");
                        break;
                    case "4":
                        PlayGame("Division");
                        break;
                    case "5":
                        ShowHistory();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void PlayGame(string operation)
        {
            Random rand = new Random();
            int num1 = rand.Next(0, 101);
            int num2 = rand.Next(1, 101); // Avoid division by zero

            if (operation == "Division")
            {
                    num2 = rand.Next(1, 101); // divisor
                    int result = rand.Next(0, 101); // quotient
                    num1 = num2 * result; // dividend
            }

            int correctAnswer = operation switch
            {
                "Addition" => num1 + num2,
                "Subtraction" => num1 - num2,
                "Multiplication" => num1 * num2,
                "Division" => num1 / num2,
                _ => 0
            };

            Console.WriteLine($"What is {num1} {GetOperatorSymbol(operation)} {num2}?");
            string? userInput = Console.ReadLine();

            if (userInput != null && int.TryParse(userInput, out int userAnswer) && userAnswer == correctAnswer)
            {
                Console.WriteLine("Correct!");
                GameHistory.Add($"{num1} {GetOperatorSymbol(operation)} {num2} = {correctAnswer} (Correct)");
            }
            else
            {
                Console.WriteLine($"Wrong! The correct answer is {correctAnswer}.");
                GameHistory.Add($"{num1} {GetOperatorSymbol(operation)} {num2} = {correctAnswer} (Wrong)");
            }
        }

        private string GetOperatorSymbol(string operation)
        {
            return operation switch
            {
                "Addition" => "+",
                "Subtraction" => "-",
                "Multiplication" => "*",
                "Division" => "/",
                _ => ""
            };
        }
        public void ShowStatistics()
        {
            int total = GameHistory.Count;
            int correct = GameHistory.Count(r => r.EndsWith("(Correct)", StringComparison.OrdinalIgnoreCase));
            int wrong = GameHistory.Count(r => r.EndsWith("(Wrong)", StringComparison.OrdinalIgnoreCase));

            double correctPercent = (double)correct / total * 100;
            double wrongPercent = (double)wrong / total * 100;

            Console.WriteLine($"Total questions: {total}");
            Console.WriteLine($"Correct: {correct} ({correctPercent:F1}%)");
            Console.WriteLine($"Wrong: {wrong} ({wrongPercent:F1}%)");
        }

        private void ShowHistory()
        {
            if (GameHistory.Count == 0)
            {
                Console.WriteLine("No games played yet.");
            }
            else
            {
                Console.WriteLine("Game History:");
                foreach (var record in GameHistory)
                {
                    Console.WriteLine(record);

                }
                ShowStatistics();
            }
        }

    }
}
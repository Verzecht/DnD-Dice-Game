public class Game
{
    private const int MaxAttempts = 3;
    private readonly Dice _dice;
    public Game(Dice dice)
    {
        _dice = dice;
    }

    public GameResult Play()
    {
        Console.WriteLine("Welcome to the Dice Game! Select one of the below dice and attempt to guess the randomly generated number in its range.");
        for (int i = 0; i < _dice.DiceTypes.Count; i++)
        { 
            Console.WriteLine($"{_dice.DiceTypes[i].DiceID}. {_dice.DiceTypes[i].DiceClass}");
        }

        int selectedIndex = -1;
        while (selectedIndex < 0 || selectedIndex >= _dice.DiceTypes.Count)
        {
            Console.Write("Enter the number of the die you want to select: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= _dice.DiceTypes.Count)
            {
                selectedIndex = choice - 1;
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
        }

        var selectedDie = _dice.DiceTypes[selectedIndex];
        Console.WriteLine(selectedDie.RollingMessage());
        int rollResult = _dice.Roll(selectedDie);
        Console.Clear();
        Console.WriteLine(selectedDie.RollingMessage());
        Console.WriteLine($"A number from a {selectedDie.DiceClass} has been rolled. Make your guesses");

        int triesLeft = MaxAttempts;
        while(triesLeft > 0)
        {
            int guess = ConsoleReader.ReadInteger("Enter a number: ");
            if(guess == rollResult)
            {
                return GameResult.Win;
            }
            Console.WriteLine("Incorrect guess.");
            triesLeft--;
            Console.WriteLine($"You have {triesLeft} attempts left.");
            Console.WriteLine();
        }
        return GameResult.Lose;
    }

    public static void PrintResult(GameResult result) //display the result of the game
    {
        string message = result == GameResult.Win ? "You win!" : "You lose!";
        Console.WriteLine(message);
    }


}

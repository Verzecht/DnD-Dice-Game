class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random(); // Instantiate a random number generator
        // Create a list of dice types
        var diceTypes = new List<DiceTypes> // List of available dice types
        {
            new D4(),
            new D6(),
            new D8(),
            new D10(),
            new D12(),
            new D20()
        };
        Dice dice = new Dice(randomNumber, diceTypes); // Create a Dice object passing Random number and list of DiceTypes
        Game game = new Game(dice); // Instantiate a Game object with the Dice instance

        GameResult result = game.Play();
        Game.PrintResult(result);
        Console.ReadKey();
    }
}

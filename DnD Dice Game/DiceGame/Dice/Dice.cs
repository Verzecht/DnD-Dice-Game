public class Dice : IDiceRoll
{
    private readonly Random _randomNumber; // Random instance for generating random numbers
    public List<DiceTypes> DiceTypes { get; } // stores the available dice types

    public Dice(Random randomNumber, List<DiceTypes> diceTypes) //receives Random and DiceType from constructor injection
    {
        _randomNumber = randomNumber;
        DiceTypes = diceTypes;
    }

    // Roll a specific die type
    public int Roll(DiceTypes diceType) => _randomNumber.Next(1, diceType.DiceSides + 1); //rolling logic

}

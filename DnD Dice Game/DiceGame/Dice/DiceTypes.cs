public abstract class DiceTypes
{
    public abstract int DiceID { get; }
    public abstract int DiceSides { get; }
    public abstract string DiceClass { get; }
    public abstract string Loading { get; }
    public virtual string RollingMessage() => "Rolling";
}

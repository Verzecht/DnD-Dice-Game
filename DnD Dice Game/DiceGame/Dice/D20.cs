public class D20 : DiceTypes
{
    public override int DiceID => 6;
    public override int DiceSides => 20;
    public override string DiceClass => "d20";
    public override string Loading => ". . .";
    public override string RollingMessage() => $"{base.RollingMessage()} {DiceClass} {Loading}";
}
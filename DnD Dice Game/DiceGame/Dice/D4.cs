public class D4 : DiceTypes
{
    public override int DiceID => 1;
    public override int DiceSides => 4;
    public override string DiceClass => "d4";
    public override string Loading => ". . .";
    public override string RollingMessage() => $"{base.RollingMessage()} {DiceClass} {Loading}";
}

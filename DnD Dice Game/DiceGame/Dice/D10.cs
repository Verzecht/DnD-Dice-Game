 public class D10 : DiceTypes
{
    public override int DiceID => 4;
    public override int DiceSides => 10;
    public override string DiceClass => "d10";
    public override string Loading => ". . .";
    public override string RollingMessage() => $"{base.RollingMessage()} {DiceClass} {Loading}";
}

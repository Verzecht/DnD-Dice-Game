public class D8 : DiceTypes
{
    public override int DiceID => 3;
    public override int DiceSides => 8;
    public override string DiceClass => "d8";
    public override string Loading => ". . .";
    public override string RollingMessage() => $"{base.RollingMessage()} {DiceClass} {Loading}";
}

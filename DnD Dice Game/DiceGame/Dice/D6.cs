public class D6 : DiceTypes
{

    public override int DiceID => 2;
    public override int DiceSides => 6;
    public override string DiceClass => "d6";
    public override string Loading => ". . .";
    public override string RollingMessage() => $"{base.RollingMessage()} {DiceClass} {Loading}";
}

public class D12 : DiceTypes
{
    public override int DiceID => 5;
    public override int DiceSides => 12;
    public override string DiceClass => "d12";
    public override string Loading => ". . .";
    public override string RollingMessage() => $"{base.RollingMessage()} {DiceClass} {Loading}";
}

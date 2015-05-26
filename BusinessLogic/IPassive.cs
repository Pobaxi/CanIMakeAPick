namespace BusinessLogic
{
    public interface IPassive
    {
        string Name { get; }
        DamageType DamageType { get; }
        int Ratio { get; }
        //Special property?
    }
}

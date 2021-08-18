public interface IBuilder
{
    int MaxLevel { get; }
    PriceStructure GetStructure(LevelStructure levelStructure);
}

using UnityEngine;

[CreateAssetMenu(fileName = "Factorys", menuName = "Factorys/Structure/BuilderBase", order = 1)]
public class FactoryContainer : ScriptableObject
{
    [SerializeField] PriceStructure[] _structures;

    public int MaxLevel => _structures.Length;

    public PriceStructure GetStructure(LevelStructure levelStructure)
    {
        if (_structures.Length >= (int)levelStructure)
        {
            return _structures[(int)levelStructure - 1];
        }
        else
        {
            return _structures[_structures.Length - 1];
        }
    }
}
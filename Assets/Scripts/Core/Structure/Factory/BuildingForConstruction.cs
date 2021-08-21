using UnityEngine;

[CreateAssetMenu(fileName = "Factorys", menuName = "Factorys/Structure/StructureContainer", order = 1)]
public class BuildingForConstruction : ScriptableObject
{
    [SerializeField] private PriceStructure[] _structures;

    public int MaxLevel => _structures.Length;

    public PriceStructure GetStructure(LevelStructure level)
    {
        if (_structures.Length >= (int)level)
        {
            return _structures[(int)level - 1];
        }
        else
        {
            return _structures[_structures.Length - 1];
        }
    }
}
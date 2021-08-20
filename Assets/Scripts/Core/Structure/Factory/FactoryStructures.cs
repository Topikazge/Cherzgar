using System;
using UnityEngine;

public class FactoryStructures : MonoBehaviour
{
    private static FactoryStructures[] s_structures;
    [SerializeField] private TypeStructure _typeFatory;
    [SerializeField] private BuildingForConstruction _builder;
    private int _maxLevel;

    public TypeStructure TypeFatory
    {
        get
        {
            return _typeFatory;
        }
    }
    public int MaxLevel
    {
        get
        {
            return _maxLevel;
        }
    }

    private void Awake()
    {
        _maxLevel = _builder.MaxLevel;
    }

    public static FactoryStructures GetFactory(TypeStructure typeStructure)
    {
        if (s_structures == null)
        {
            s_structures = FindObjectsOfType<FactoryStructures>();
        }
        foreach (FactoryStructures structure in s_structures)
        {
            if (structure.TypeFatory == typeStructure)
            {
                return structure;
            }
        }
        throw new Exception();
    }
    public Structure SpawnStructure(LevelStructure levelStructure)
    {
        return Instantiate(_builder.GetStructure(levelStructure).Structure);
    }
    public int GetPrice(LevelStructure levelStructure)
    {
        return _builder.GetStructure(levelStructure).Price;
    }



}

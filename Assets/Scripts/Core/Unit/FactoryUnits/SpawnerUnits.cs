using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerUnits : MonoBehaviour
{
    [SerializeField] FactoryUnits _factoryUnits;

    public UnitBase SpawnUnit(TypeUnit typeUnit)
    {
        return _factoryUnits.GetUnit(typeUnit);
    }
}

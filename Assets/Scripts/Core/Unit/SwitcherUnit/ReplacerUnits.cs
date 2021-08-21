using System;
using UnityEngine;

[RequireComponent(typeof(SpawnerUnits))]
public class ReplacerUnits : MonoBehaviour
{
    private SpawnerUnits _spawnerUnits;

    private void Start()
    {
        _spawnerUnits = GetComponent<SpawnerUnits>();
    }

    public void AutoReplaceUnits(UnitBase unit)
    {
        Vector2 poinSpawn = unit.transform.position;
        UnitBase nextUnit;
        switch (unit.TypeUnit)
        {
            case TypeUnit.Beggar:
                nextUnit = _spawnerUnits.SpawnUnit(TypeUnit.CommonResident);
                break;
            case TypeUnit.CommonResident:
                nextUnit = _spawnerUnits.SpawnUnit(TypeUnit.Shooter);
                Debug.Log("Произошел спавн Shooter");
                break;
            default:
                throw new Exception();
        }
        Destroy(unit.gameObject);
        Replace(nextUnit, poinSpawn);
        Debug.Log("Произошел спавн");
    }

    public void ReplaceUnits(UnitBase unit, TypeUnit typeInhabitant)
    {
        Vector2 poinSpawn = unit.transform.position;
        UnitBase nextUnit = _spawnerUnits.SpawnUnit(typeInhabitant);
        Destroy(unit.gameObject);
        Replace(nextUnit, poinSpawn);
    }

    private void Replace(UnitBase unit, Vector2 point)
    {
        unit.transform.position = point;
    }
}

using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Factorys", menuName = "Factorys/Unit", order = 1)]
public class FactoryUnits : ScriptableObject
{
    [SerializeField] private UnitBase _beggar;
    [SerializeField] private UnitBase _commonResident;
    [SerializeField] private UnitBase _shooter;
    [SerializeField] private UnitBase _fermer;

    public UnitBase GetUnit(TypeUnit typeInhabitants)
    {
        switch (typeInhabitants)
        {
            case TypeUnit.Beggar:
                return Instantiate(_beggar); 
            case TypeUnit.CommonResident:
                return Instantiate(_commonResident); 
            case TypeUnit.Shooter:
                return Instantiate(_shooter);
            case TypeUnit.Fermer:
                return Instantiate(_fermer); 
            default:
                throw new ArgumentException();
        }
    }
}

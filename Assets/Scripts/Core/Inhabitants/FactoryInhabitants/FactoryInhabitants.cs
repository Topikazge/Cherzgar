using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Factorys", menuName = "Factorys/Inhabitants", order = 1)]
public class FactoryInhabitants : ScriptableObject
{
    [SerializeField] private InhabitantBase _beggar;
    [SerializeField] private InhabitantBase _commonResident;
    [SerializeField] private InhabitantBase _shooter;

    public InhabitantBase GetInhabitant(TypeInhabitant typeInhabitants)
    {
        switch (typeInhabitants)
        {
            case TypeInhabitant.Beggar:
                return Instantiate(_beggar); ;
            case TypeInhabitant.CommonResident:
                return Instantiate(_commonResident); ;
            case TypeInhabitant.Shooter:
                return Instantiate(_shooter); ;
            default:
                throw new ArgumentException();
        }
    }
}

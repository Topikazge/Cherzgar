using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerInhabitants : MonoBehaviour
{
    [SerializeField] FactoryInhabitants _factoryInhabitants;

    public InhabitantBase SpawnInhabitant(TypeInhabitant typeInhabitant)
    {
        return _factoryInhabitants.GetInhabitant(typeInhabitant);
    }
}

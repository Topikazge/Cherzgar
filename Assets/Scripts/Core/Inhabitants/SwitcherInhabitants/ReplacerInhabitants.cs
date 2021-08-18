using System;
using UnityEngine;

[RequireComponent(typeof(SpawnerInhabitants))]
public class ReplacerInhabitants : MonoBehaviour
{
    private SpawnerInhabitants _spawnerInhabitants;

    private void Start()
    {
        _spawnerInhabitants = GetComponent<SpawnerInhabitants>();
    }

    public void AutoReplaceInhabitants(InhabitantBase inhabitant)
    {
        Vector2 poinSpawn = inhabitant.transform.position;
        InhabitantBase nextinhabitant;
        switch (inhabitant.TypeInhabitant)
        {
            case TypeInhabitant.Beggar:
                nextinhabitant = _spawnerInhabitants.SpawnInhabitant(TypeInhabitant.CommonResident);
                break;
            case TypeInhabitant.CommonResident:
                nextinhabitant = _spawnerInhabitants.SpawnInhabitant(TypeInhabitant.Shooter);
                Debug.Log("Произошел спавн Shooter");
                break;
            default:
                throw new Exception();
        }
        Destroy(inhabitant.gameObject);
        Replace(nextinhabitant, poinSpawn);
        Debug.Log("Произошел спавн");
    }

    public void ReplaceInhabitants(InhabitantBase inhabitant, TypeInhabitant typeInhabitant)
    {
        Vector2 poinSpawn = inhabitant.transform.position;
        InhabitantBase nextinhabitant;
        nextinhabitant = _spawnerInhabitants.SpawnInhabitant(typeInhabitant);
        Destroy(inhabitant.gameObject);
        Replace(nextinhabitant, poinSpawn);
    }

    private void Replace(InhabitantBase inhabitant, Vector2 point)
    {
        inhabitant.transform.position = point;
    }
}

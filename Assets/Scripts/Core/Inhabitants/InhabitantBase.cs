using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InhabitantBase : MonoBehaviour
{
    [SerializeField] private TypeInhabitant _typeInhabitant;

    public TypeInhabitant TypeInhabitant
    {
        get => _typeInhabitant;
    }
}

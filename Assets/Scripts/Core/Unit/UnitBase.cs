using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UnitBase : MonoBehaviour
{
    [SerializeField] private TypeUnit _typeUnit;

    public TypeUnit TypeUnit
    {
        get => _typeUnit;
    }
}

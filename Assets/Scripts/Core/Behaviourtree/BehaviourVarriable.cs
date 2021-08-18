using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourVarriable
{
    private string _name;
    private object _object;

    public BehaviourVarriable(string name, object @object)
    {
        _name = name;
        _object = @object;
    }

    public string Name => _name;
    public object @Object { get => _object; set => _object = value; }
}

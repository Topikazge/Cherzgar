using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorTree : CompositeNode
{
    private GameObject _objectTree;
    private Dictionary<string, BehaviourVarriable> _varriable;

    public BehaviorTree(GameObject objectTree) : base()
    {
        _varriable = new Dictionary<string, BehaviourVarriable>();
        _objectTree = objectTree;
    }




    public GameObject ObjectTree => _objectTree;



    public override NodeResult Execute()
    {
        throw new System.NotImplementedException();
    }
    public void Tick()
    {
        foreach (Node item in _children)
        {
            item.Execute();
        }
    }

    public BehaviourVarriable GetVarriable(string name)
    {
        return _varriable[name];
    }
    public BehaviorTree AddVarriable(BehaviourVarriable behaviourVarriable)
    {
        _varriable.Add(behaviourVarriable.Name, behaviourVarriable);
        return this;
    }
}

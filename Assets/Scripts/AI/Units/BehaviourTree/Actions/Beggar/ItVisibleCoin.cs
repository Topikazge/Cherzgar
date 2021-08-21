using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItVisibleCoin : ActionNode
{
    private BehaviourVarriable _targetVariable;
    private BehaviourVarriable _distanceChackCoinseed;

    public ItVisibleCoin(BehaviorTree behaviorTree) : base(behaviorTree)
    {
        _targetVariable = _behaviorTree.GetVarriable("Target");
        _distanceChackCoinseed = _behaviorTree.GetVarriable("DistanceChackCoinseed");
    }

    public override NodeResult Execute()
    {
        GameObject target = (GameObject)_targetVariable.Object;
  
        float distanveBetweenObjects = Mathf.Abs(_behaviorTree.ObjectTree.transform.position.x - target.transform.position.x);
        if (distanveBetweenObjects <= (float)_distanceChackCoinseed.Object)
        {
            return NodeResult.Success;
        }
        else
        {
            return NodeResult.Failure;
        }
    }
}

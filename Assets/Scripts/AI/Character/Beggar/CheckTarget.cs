using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTarget : ActionNode
{
    private BehaviourVarriable _targetVariable;

    public CheckTarget(BehaviorTree behaviorTree) : base(behaviorTree)
    {
        _targetVariable = _behaviorTree.GetVarriable("Target");
    }

    public override NodeResult Execute()
    {

        if (_targetVariable.Object == null)
        {
            return NodeResult.Failure;
        }
        else
        {
            return NodeResult.Success;
        }

        
    }
}

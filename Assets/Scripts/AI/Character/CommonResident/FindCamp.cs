using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindCamp : ActionNode
{
    private BehaviourVarriable _target;
    public FindCamp(BehaviorTree behaviorTree) : base(behaviorTree)
    {
        _behaviorTree = behaviorTree;
        _target = _behaviorTree.GetVarriable("Target");
    }

    public override NodeResult Execute()
    {
        RebelGalaxy vacance = GameObject.FindObjectOfType<RebelGalaxy>();

        if (vacance != null)
        {
            _target.Object = vacance.gameObject;
            return NodeResult.Success;
        }

        return NodeResult.Success;
    }
}

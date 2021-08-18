using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindVacance : ActionNode
{
    private BehaviourVarriable _target;
    public FindVacance(BehaviorTree behaviorTree) : base(behaviorTree)
    {
        _behaviorTree = behaviorTree;
        _target = _behaviorTree.GetVarriable("Target");
    }

    public override NodeResult Execute()
    {
        ArcherBarracks[] vacance = GameObject.FindObjectsOfType<ArcherBarracks>();
        if (vacance.Length > 0)
        {
            foreach (ArcherBarracks item in vacance)
            {
                if (item.CheckFreeVanace())
                {
                    _target.Object = item.gameObject;
                    return NodeResult.Success;
                }
            }
        }

        return NodeResult.Failure;
    }
}

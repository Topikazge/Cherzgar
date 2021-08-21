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
        ShopTools[] vacance = GameObject.FindObjectsOfType<ShopTools>();
        if (vacance.Length > 0)
        {
            foreach (ShopTools item in vacance)
            {
                if (item.TryGetTool())
                {
                    _target.Object = item.gameObject;
                    return NodeResult.Success;
                }
            }
        }

        return NodeResult.Failure;
    }
}

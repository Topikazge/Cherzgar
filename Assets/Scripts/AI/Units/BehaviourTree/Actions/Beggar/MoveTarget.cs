using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget : ActionNode
{
    private BehaviourVarriable _speedVariable;
    private BehaviourVarriable _target;
    private Transform _transform;

    public MoveTarget(BehaviorTree behaviorTree) : base(behaviorTree)
    {
        _speedVariable = _behaviorTree.GetVarriable("Speed");
        _target = _behaviorTree.GetVarriable("Target");
        _transform = _behaviorTree.ObjectTree.transform;
    }
    public override NodeResult Execute()
    {
        float speed = (float)_speedVariable.Object;
        float diretionX = 0;
        GameObject transformGameObject = (GameObject)_target.Object;
        Transform transformTarget = transformGameObject.transform;

        if (transformTarget.position.x > _transform.position.x)
        {
            diretionX = 1;
        }
        else if (transformTarget.position.x < _transform.position.x)
        {
            diretionX = -1;
        }

        _transform.Translate(new Vector2(speed * diretionX * Time.deltaTime, 0), Space.World);

        return NodeResult.Success;
    }
}

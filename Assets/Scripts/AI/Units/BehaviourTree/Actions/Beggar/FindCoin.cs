using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindCoin : ActionNode
{
    private BehaviourVarriable _targetVariable;
    private BehaviourVarriable _distanceChackCoinseed;
    private BehaviourVarriable _coinsLayer;

    public FindCoin(BehaviorTree behaviorTree) : base(behaviorTree)
    {
        _targetVariable = _behaviorTree.GetVarriable("Target");
        _distanceChackCoinseed = _behaviorTree.GetVarriable("DistanceChackCoinseed");
        _coinsLayer = _behaviorTree.GetVarriable("CoinsLayer");
    }


    public override NodeResult Execute()
    {
        Vector2 startFind = _behaviorTree.ObjectTree.transform.position;
        Vector2 endRightFind = new Vector2(startFind.x, startFind.y);
        endRightFind.x += (float)_distanceChackCoinseed.Object;
        Vector2 endLeftFind = new Vector2(startFind.x, startFind.y); ;
        endLeftFind.x += (float)_distanceChackCoinseed.Object * -1;
        RaycastHit2D raycastHit2D = Physics2D.Linecast(endLeftFind, endRightFind, (LayerMask)_coinsLayer.Object);
        if (raycastHit2D.collider != null)
        {
            _targetVariable.Object = raycastHit2D.collider.gameObject;
            return NodeResult.Success;
        }
        else
        {
            _targetVariable.Object = null;
            return NodeResult.Failure;
        }
    }

    private void Find()
    {

    }
}

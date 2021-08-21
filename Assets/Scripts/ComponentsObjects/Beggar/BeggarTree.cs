using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeggarTree : UnitBase
{
    [SerializeField] private float _speed;
    [SerializeField] private float _distanceCheckCoins;
    [SerializeField] private LayerMask _coinsLayer;
    private BehaviorTree _behaviorTree;

    private BeggarCollisionHandler _collision;

    private ReplacerUnits _switcherUnits;

    private void Start()
    {
        CreateBehaviorTree();
        _collision = GetComponent<BeggarCollisionHandler>();
        _collision.CoinCollision.AddSubscriber(AppCoin);

        _switcherUnits = FindObjectOfType<ReplacerUnits>();
    }

    private void Update()
    {
        _behaviorTree.Tick();
    }

    private void CreateBehaviorTree()
    {
        _behaviorTree = new BehaviorTree(gameObject);

        BehaviourVarriable behaviourVarriable = new BehaviourVarriable("Speed", _speed);
        BehaviourVarriable distanceCheckckCoins = new BehaviourVarriable("DistanceChackCoinseed", _distanceCheckCoins);
        BehaviourVarriable coinsLayer = new BehaviourVarriable("CoinsLayer", _coinsLayer);
        BehaviourVarriable Target = new BehaviourVarriable("Target", null);

        _behaviorTree.AddVarriable(behaviourVarriable)
            .AddVarriable(distanceCheckckCoins)
         .AddVarriable(coinsLayer)
                 .AddVarriable(Target);

        FindCoin findCoin = new FindCoin(_behaviorTree);
        CheckTarget checkTarget = new CheckTarget(_behaviorTree);
        ItVisibleCoin itVisibleCoin = new ItVisibleCoin(_behaviorTree);
        MoveTarget moveCoin = new MoveTarget(_behaviorTree);

        Sequence Move = new Sequence();
        Move.AddNode(checkTarget)
            .AddNode(itVisibleCoin)
            .AddNode(moveCoin);



        Selector EnterTree = new Selector();
        EnterTree.AddNode(Move).AddNode(findCoin);

        _behaviorTree.AddNode(EnterTree);

    }

    private void AppCoin(Coin coin)
    {
        _switcherUnits.AutoReplaceUnits(this);
    }

    private void OnDrawGizmos()
    {
        Vector2 startFind = transform.position;
        Vector2 endRightFind = new Vector2(startFind.x, startFind.y);
        endRightFind.x += _distanceCheckCoins;
        Vector2 endLeftFind = new Vector2(startFind.x, startFind.y); ;
        endLeftFind.x += _distanceCheckCoins * -1;
        Gizmos.DrawLine(endLeftFind, endRightFind);
    }
}

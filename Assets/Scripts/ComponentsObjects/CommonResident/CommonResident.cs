using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonResident : UnitBase
{
    [SerializeField] private float _speed;
    private BehaviorTree _behaviorTree;

    private Wallet _wallet;
    private ResidentCollisionHandler _collisionHandler;

    private void Start()
    {
        SetupBehaviorTree();

        _wallet = GetComponent<Wallet>();

        _collisionHandler = GetComponent<ResidentCollisionHandler>();

        _collisionHandler.VacanceCollisison.AddSubscriber(GetVacance);

    }

    private void Update()
    {
        _behaviorTree.Tick();
    }

    public void GetVacance(IFreeTool freeVacance)
    {
        if (freeVacance.TryGetTool())
            freeVacance.GetTool(this);
    }
    public void AppCoin(Coin coin)
    {
        coin.App(_wallet);
    }

    private void SetupBehaviorTree()
    {
        _behaviorTree = new BehaviorTree(gameObject);
        BehaviourVarriable behaviourVarriable = new BehaviourVarriable("Speed", _speed);
        BehaviourVarriable Target = new BehaviourVarriable("Target", null);

        _behaviorTree.AddVarriable(behaviourVarriable)
                .AddVarriable(Target);

        FindVacance findVacance = new FindVacance(_behaviorTree);
        FindCamp findCamp = new FindCamp(_behaviorTree);
        MoveTarget moveTarget = new MoveTarget(_behaviorTree);

        Selector finderTarget = new Selector();
        finderTarget.AddNode(findVacance)
                .AddNode(findCamp);

        Sequence sequence = new Sequence();
        sequence.AddNode(finderTarget)
                .AddNode(moveTarget);

        _behaviorTree.AddNode(sequence);

    }
}

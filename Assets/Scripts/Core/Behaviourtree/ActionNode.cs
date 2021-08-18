using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class ActionNode : Node
{
    protected BehaviorTree _behaviorTree;

    public ActionNode(BehaviorTree behaviorTree)
    {
        _behaviorTree = behaviorTree;
    }

    /*  public event Func<NodeResult> CallBackActions;

      public override NodeResult Execute()
      {
          switch (CallBackActions.Invoke())
          {
              case NodeResult.Failure:
                  return NodeResult.Success;
              case NodeResult.Success:
                  return NodeResult.Failure;
              case NodeResult.Running:
                  return NodeResult.Running;
              default:
                  return NodeResult.Failure;
          }
      }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : CompositeNode
{
    public override NodeResult Execute()
    {
        foreach (var child in Children)
        {
            var status = child.Execute();
            if (status != NodeResult.Failure)
                return status;
        }

        return NodeResult.Failure;
    }
}

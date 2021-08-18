using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence : CompositeNode
{
    public override NodeResult Execute()
    {
        foreach (var child in Children)
        {
            var status = child.Execute();
            if (status == NodeResult.Failure)
                return NodeResult.Failure;
        }

        return NodeResult.Success;
    }
}

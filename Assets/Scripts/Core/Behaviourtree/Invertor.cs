using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invertor : Node
{
    private Node _child;

    public Invertor(Node child)
    {
        _child = child;
    }

    public override NodeResult Execute()
    {
        switch (_child.Execute())
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
    }
}

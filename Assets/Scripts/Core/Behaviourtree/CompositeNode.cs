using System.Collections.Generic;
public abstract class CompositeNode : Node
{
    public List<Node> Children
    {
        get { return _children; }
    }

    protected List<Node> _children;

    public CompositeNode()
    {
        _children = new List<Node>();
    }

    public CompositeNode AddNode(Node child)
    {
        _children.Add(child);
        return this;
    }
}

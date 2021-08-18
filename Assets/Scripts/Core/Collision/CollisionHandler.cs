using System;
using UnityEngine;
public static class CollisionHandler
{
    public static void Check<T>(Action<T> handler, GameObject target)
    {
        T c = target.GetComponent<T>();
        if (c != null)
        {
            handler.Invoke(c);
        }
    }
}


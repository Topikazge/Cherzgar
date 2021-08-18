using System;
using UnityEngine;

public class FinderComponent
{
    public event Action Notification;
    public void Check<T>(GameObject target)
    {
        T c = target.GetComponent<T>();
        if (c != null)
        {
            Notification.Invoke();
        }
    }
}

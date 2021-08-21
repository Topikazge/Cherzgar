using System;
using UnityEngine;

public class FinderComponent<T>
{
    private event Action Notification;
    public void TryFind(GameObject target)
    {
        if (target.TryGetComponent(out T Ground))
        {
            Notification.Invoke();
        }
    }

    public  void AddSubscriber(Action subscriber)
    {
        if (subscriber != null)
        {
            Notification += subscriber;
        }
    }

    public void RemoveSubscriber(Action subscriber)
    {
        if (subscriber != null)
        {
            Notification -= subscriber;
        }
    }
}

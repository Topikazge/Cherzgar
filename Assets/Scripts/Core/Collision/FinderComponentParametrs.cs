using System;
using UnityEngine;

public class FinderComponentParametrs<T>
{
    private event Action<T> Notification;
    public static void Find(Action<T> handler, GameObject target)
    {
        T c = target.GetComponent<T>();
        if (c != null)
        {
            handler.Invoke(c);
        }
    }

    public void Find(GameObject target)
    {
        Find(Notification, target);
        /*  T component = target.GetComponent<T>();
          if (component != null)
          {
              Notification?.Invoke(component);
          }*/
    }

    public void AddSubscriber(Action<T> subscriber)
    {
        if (subscriber != null)
        {
            Notification += subscriber;
        }
    }

    public void RemoveSubscriber(Action<T> subscriber)
    {
        if (subscriber != null)
        {
            Notification -= subscriber;
        }
    }
}


using System;
using UnityEngine;

public class FinderComponentParametrs<T>
{
    public event Action<T> Notification;
    public void Check(GameObject target)
    {
        T component = target.GetComponent<T>();
        if (component != null)
        {
            Notification?.Invoke(component);
        }
    }
  
}


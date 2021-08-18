using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyObject : MonoBehaviour
{
    private static EmptyObject instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }


    public static EmptyObject getInstance()
    {
        return instance;
    }

}

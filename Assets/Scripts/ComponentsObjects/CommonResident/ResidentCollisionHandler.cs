using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResidentCollisionHandler : MonoBehaviour
{
    private FinderComponentParametrs<IFreeTool> _vacanceCollisison;
    public FinderComponentParametrs<IFreeTool> VacanceCollisison=> _vacanceCollisison;
    private void Awake()
    {
        _vacanceCollisison = new FinderComponentParametrs<IFreeTool>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _vacanceCollisison.Find(collision.gameObject);
    }
}

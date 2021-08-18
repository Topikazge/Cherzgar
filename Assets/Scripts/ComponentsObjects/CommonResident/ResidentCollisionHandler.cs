using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResidentCollisionHandler : MonoBehaviour
{
    private FinderComponentParametrs<IFreeVacance> _vacanceCollisison;
    public FinderComponentParametrs<IFreeVacance> VacanceCollisison=> _vacanceCollisison;
    private void Awake()
    {
        _vacanceCollisison = new FinderComponentParametrs<IFreeVacance>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _vacanceCollisison.Check(collision.gameObject);
    }
}

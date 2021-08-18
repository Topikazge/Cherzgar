using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResidentCollisionHandler : MonoBehaviour
{
    private FinderComponentParametrs<IFreeVacance> _vacanceCollisison;
    private FinderComponentParametrs<Coin> _coinCollision;

    public FinderComponentParametrs<Coin> CoinCollision => _coinCollision;
    public FinderComponentParametrs<IFreeVacance> VacanceCollisison=> _vacanceCollisison;
    private void Awake()
    {
        _vacanceCollisison = new FinderComponentParametrs<IFreeVacance>();
        _coinCollision = new FinderComponentParametrs<Coin>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _vacanceCollisison.Check(collision.gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _coinCollision.Check(collision.gameObject);
    }
}

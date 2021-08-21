using System;
using UnityEngine;

public class BeggarCollisionHandler : MonoBehaviour
{
    private FinderComponentParametrs<Coin> _coinCollision;
    public FinderComponentParametrs<Coin> CoinCollision => _coinCollision;

    private void Awake()
    {
        _coinCollision = new FinderComponentParametrs<Coin>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        CoinCollision.Find(collision.gameObject);
    }
}

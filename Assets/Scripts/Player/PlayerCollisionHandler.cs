using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    private FinderComponentParametrs<Coin> _finderCoin;
    private Player _player;
    
    public FinderComponentParametrs<Coin> FinderCoin => _finderCoin;

    private void Awake()
    {
        _finderCoin = new FinderComponentParametrs<Coin>();
    }

    private void Start()
    {
        _player = GetComponent<Player>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _finderCoin.Find(collision.gameObject);
    }
}

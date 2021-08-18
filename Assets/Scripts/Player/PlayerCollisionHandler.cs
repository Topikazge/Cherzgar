using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    [SerializeField] private LayerMask _COinLayer;
    private Player _player;

    private void Start()
    {
        _player = GetComponent<Player>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Coin coin = collision.gameObject.GetComponent<Coin>();
        if (coin != null)
        {
            Debug.Log(collision.gameObject.name);
            _player.AppCoin(coin);
        }
    }
}

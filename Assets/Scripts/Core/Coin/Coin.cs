using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private bool _canAppPlayer = true;

    private Rigidbody2D _rigidbody;
    private BoxCollider2D _collider;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _collider = GetComponent<BoxCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Ground Ground))
        {
            _rigidbody.gravityScale = 0;
            _collider.isTrigger = true;
            _canAppPlayer = false;
        }
    }

    public void Drop()
    {
        _canAppPlayer = false;
    }

    public void App(Wallet wallet)
    {
        if (_canAppPlayer && wallet.IsMaxCoin == false)
        {
            StopAllCoroutines();
            wallet.AddCoin();
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private bool _canAppPlayer = true;

    FinderComponent<Ground> _finderComponent;

    private Rigidbody2D _rigidbody;
    private BoxCollider2D _collider;

    private void Start()
    {
        _finderComponent = new FinderComponent<Ground>();
        _finderComponent.AddSubscriber(AllowApp); 

        _rigidbody = GetComponent<Rigidbody2D>();
        _collider = GetComponent<BoxCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _finderComponent.TryFind(collision.gameObject);
      /*  if (collision.gameObject.TryGetComponent(out Ground Ground))
        {
          
        }*/
    }

    private void AllowApp()
    {
        _rigidbody.gravityScale = 0;
        _collider.isTrigger = true;
        _canAppPlayer = true;
    }

    public void Drop()
    {
        _canAppPlayer = false;
    }

    public void App(Wallet wallet)
    {
        if (_canAppPlayer && (wallet.IsMaxCoin == false))
        {
            wallet.AddCoin();
            Destroy(gameObject);
        }
    }
}

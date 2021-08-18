using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private LayerMask _ground;
    private static float _time = 1.5f;
    private IEnumerator _timerCor;
    private bool _canAppPlayer = true;

    private Rigidbody2D _rigidbody;
    private BoxCollider2D _collider;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _collider = GetComponent<BoxCollider2D>();
    }

    private IEnumerator Timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(_time);
            _canAppPlayer = true;
            yield return null;
        }
    }

    public void DropPlayer()
    {
        _canAppPlayer = false;
        _timerCor = Timer();
        StartCoroutine(_timerCor);
    }

    public void CanAppPlayer(Wallet wallet)
    {
        if (_canAppPlayer)
        {
            StopAllCoroutines();
            wallet.AddCoin();
            Destroy(gameObject);
        }
    }
    public void Drop()
    {
    }

    public void CanApp(Wallet wallet)
    {
        if (wallet.IsMaxCoin == false)
        {
            Debug.Log("лллллллллл" + wallet.IsMaxCoin);
            StopAllCoroutines();
            wallet.AddCoin();
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == _ground)
        {
            _rigidbody.gravityScale = 0;
            _collider.isTrigger = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _radiosInteraction;
    [SerializeField] private LayerMask _interactLayer;
    private PlayerCollisionHandler _collisionHandler;

    private Wallet _wallet;
    private void Start()
    {
        _wallet = GetComponent<Wallet>();
        _collisionHandler = GetComponent<PlayerCollisionHandler>();
        _collisionHandler.FinderCoin.AddSubscriber(AppCoin);
    }

    private void Update()
    {
        bool moveLeft = Input.GetKey(KeyCode.A);
        bool moveRight = Input.GetKey(KeyCode.D);
        bool interaction = Input.GetKeyDown(KeyCode.E);
        float vectorMoveX = 0;


        if (interaction)
        {
            Collider2D collider2D = Physics2D.OverlapCircle(transform.position, _radiosInteraction, _interactLayer);
            if (collider2D != null)
            {
                IPaid interaction1 = collider2D.gameObject.GetComponent<IPaid>();
                if (interaction1 != null)
                {
                    interaction1.Pay(_wallet);    
                }
            }

        }
        else if (moveLeft)
        {
            vectorMoveX = -1;
        }
        else if (moveRight)
        {
            vectorMoveX = 1;
        }
        Vector3 vector3 = new Vector3(vectorMoveX * _speed * Time.deltaTime, 0, 0);

        transform.Translate(vector3);
    }

    private void AppCoin(Coin coin)
    {
        coin.App(_wallet);
    }


    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, _radiosInteraction);
    }
}

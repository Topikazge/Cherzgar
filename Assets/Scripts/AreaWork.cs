using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaWork : MonoBehaviour
{
    private float _horizontalSize;
    private BoxCollider2D _collider;

    public float HorizontalSize => _horizontalSize;

    private void Start()
    {
        _collider = GetComponent<BoxCollider2D>();
        _horizontalSize = _collider.size.x;
    }

  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MoveHorizontal
{
    public static void Move(float direction,float speed, Transform transform)
    {
        Vector2 movement = new Vector2(direction, 0);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RebelGalaxy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        InhabitantBase commonResident = collision.gameObject.GetComponent<CommonResident>();
        if (commonResident != null)
        {
            
        }
    }
}

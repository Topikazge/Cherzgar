using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinOnCharacter : MonoBehaviour
{ 
    private bool _isRasedCoin = false;

    public void RasedCoin()
    {
        _isRasedCoin = true;
    }

    public void DropCoin()
    {
        _isRasedCoin = false;
    }
}

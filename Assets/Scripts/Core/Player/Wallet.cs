using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    [SerializeField] private int _maxCount;
    [SerializeField] private int _count;

    public int Count => _count;
    public bool IsMaxCoin
    {
        get
        {
            if (_count >= _maxCount)
            {
                return true;
            }
            else
            {
                return false;
            }
         
        }
    }

    public void CashWithdrawal(int count)
    {
        _count -= count;
        if (_count < 0)
        {
            _count = 0;
        }
    }

    public void AddCoin()
    {
        if (_count < _maxCount)
        {
            _count++;
        }
    }
}

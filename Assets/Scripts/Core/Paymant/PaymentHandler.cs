using System;
using UnityEngine;

public class PaymentHandler : MonoBehaviour, IPaid
{
    [SerializeField] private bool _canPayment = true;

    private int _price;

    public event Action PaymentCompleted;

    public void SetPrice(int price)
    {
        _price = price;
    }

    public void Pay(Wallet wallet)
    {
        if (_canPayment)
        {
            if (CheckEnoughMoney(wallet.Count))
            {
                MakingPayment(wallet);
            }
        }
    }

    private bool CheckEnoughMoney(int value)
    {
        if (value >= _price)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void MakingPayment(Wallet wallet)
    {
        wallet.CashWithdrawal(_price);
        PaymentCompleted?.Invoke();
    }

}

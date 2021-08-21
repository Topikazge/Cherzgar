using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structure : MonoBehaviour
{
    [SerializeField] private TypeStructure _typeStructure;

    public TypeStructure TypeStructure => _typeStructure;
    /* private PaymentHandler _payer;

     public void Interaction(Wallet wallet)
     {
         _payer.Interaction(wallet);
     }

     public void SetPayer(PaymentHandler payer)
     {
         _payer = payer;
     }*/
}

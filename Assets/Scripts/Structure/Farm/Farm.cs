using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : MonoBehaviour
{
    [SerializeField] private float _maxWorkplaces;
    private float _amountWorkplaces;
    List<Fermer> _fermers;

    private FinderComponentParametrs<Fermer> _geterFermer;

    private void Awake()
    {
        _geterFermer = new FinderComponentParametrs<Fermer>();
    }

    private void Start()
    {
        _geterFermer.AddSubscriber(AddFermer);
        _amountWorkplaces = 0;
        _fermers = new List<Fermer>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        _geterFermer.Find(collision.gameObject);
    }

    private void AddFermer(Fermer fermer) 
    {
    
    
    }
}

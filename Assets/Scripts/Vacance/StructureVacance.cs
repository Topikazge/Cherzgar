using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PaymentHandler))]
public class StructureVacance : MonoBehaviour, IFreeVacance
{
    [SerializeField] private TypeInhabitant _typeVacance;
    [SerializeField] private int _priceArcher;
    [SerializeField] private int _countArcherForPay;
    [SerializeField] private Vacance[] _archerVacances;
    private int _currentVacancy;


    private PaymentHandler _paymentHandler;
    private VacanceView _vacanceViewer;

    private ReplacerInhabitants _replacerInhabitants;

    private void Start()
    {
        _paymentHandler = GetComponent<PaymentHandler>();
        _vacanceViewer = new VacanceView(_archerVacances);

        _currentVacancy = 0;

        _paymentHandler.PaymentCompleted += OnPaidUp;
        _paymentHandler.SetPrice(_priceArcher);

        _replacerInhabitants = FindObjectOfType<ReplacerInhabitants>();
    }

    public bool CheckFreeVanace()
    {
        if (_vacanceViewer.OpenVacance > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    private void OnPaidUp()
    {
        AddVacancy();
    }

    private void AddVacancy()
    {
        if (_currentVacancy < _countArcherForPay)
        {
            _vacanceViewer.ViewVacance();
            _currentVacancy++;
        }
    }
    private void RemoveVacancy()
    {
        if (_currentVacancy > 0)
        {
            _vacanceViewer.CloseVacance();
            _currentVacancy--;
        }
    }

    public void GetVacance(InhabitantBase inhabitantBase)
    {
        if (_currentVacancy > 0)
        {
            RemoveVacancy();
            _replacerInhabitants.ReplaceInhabitants(inhabitantBase, _typeVacance);
        }
    }
}
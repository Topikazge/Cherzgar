using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PaymentHandler))]
public class ShopTools : MonoBehaviour, IFreeTool
{
    [SerializeField] private TypeUnit _typeVacance;
    [SerializeField] private int _priceArcher;
    [SerializeField] private int _countArcherForPay;
    [SerializeField] private ShowcaseTools[] _archerTool;
    private int _currentTools;


    private PaymentHandler _paymentHandler;
    private ToolsShowcase _toolsShowcase;

    private ReplacerUnits _replacerUnits;

    private void Start()
    {
        _paymentHandler = GetComponent<PaymentHandler>();
        _toolsShowcase = new ToolsShowcase(_archerTool);

        _currentTools = 0;

        _paymentHandler.PaymentCompleted += OnPaidUp;
        _paymentHandler.SetPrice(_priceArcher);

        _replacerUnits = FindObjectOfType<ReplacerUnits>();
    }

    public bool TryGetTool()
    {
        if (_toolsShowcase.ToolsAvailable > 0)
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
        AddTool();
    }

    private void AddTool()
    {
        if (_currentTools < _countArcherForPay)
        {
            _toolsShowcase.ShowTool();
            _currentTools++;
        }
    }
    private void RemoveTool()
    {
        if (_currentTools > 0)
        {
            _toolsShowcase.HideTool();
            _currentTools--;
        }
    }

    public void GetTool(UnitBase UnitBase)
    {
        if (_currentTools > 0)
        {
            RemoveTool();
            _replacerUnits.ReplaceUnits(UnitBase, _typeVacance);
        }
    }
}
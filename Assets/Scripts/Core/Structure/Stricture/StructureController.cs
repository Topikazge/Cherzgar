using UnityEngine;

public class StructureController : MonoBehaviour
{
    [SerializeField] private TypeStructure _typeBuildStructure;
    [Header("Parametras Locations")]
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private GameObject _structureParent;
    private LevelStructure _levelStructure;
    private Structure _currentSctructure;
    private PaymentHandler _paymentforBuilding;
    private FactoryStructures _factoryStructure;

    private void Start()
    {
        _factoryStructure = FactoryStructures.GetFactory(_typeBuildStructure);
        _levelStructure = LevelStructure.One;
        SpawnFirstLevel();
    }

    public void ImprovementPaid()
    {
        ImproveStructure();
    }

    private void ImproveStructure()
    {
        Destroy(_currentSctructure.gameObject);
        IncreaseCurrentLevelStructure();
        Structure structure = GetStructure(_levelStructure);
        SetupLocations(structure);
        if ((int)_levelStructure < _factoryStructure.MaxLevel)
        {
            SetupSettingPayment(structure);
        }
        _currentSctructure = structure;
    }

    private void SpawnFirstLevel()
    {
        Structure structure = GetStructure(_levelStructure);
        SetupLocations(structure);
        if ((int)_levelStructure < _factoryStructure.MaxLevel)
        {
            SetupSettingPayment(structure);
        }
        _currentSctructure = structure;
    }

    private Structure GetStructure(LevelStructure levelStructure)
    {
        return _factoryStructure.SpawnStructure(levelStructure);
    }

    private void SetupLocations(Structure structure)
    {
        structure.transform.SetParent(_structureParent.transform);
        structure.transform.position = _spawnPoint.position;
    }

    private void SetupSettingPayment(Structure structure)
    {
        PaymentHandler paymentHandler = structure.GetComponent<PaymentHandler>();
        if (paymentHandler != null)
        {
            paymentHandler.PaymentCompleted += ImprovementPaid;
            int nextLevel = (int)_levelStructure + 1;
            int priceStructure = _factoryStructure.GetPrice((LevelStructure)nextLevel);
            paymentHandler.SetPrice(priceStructure);
        }
    }

    private void IncreaseCurrentLevelStructure()
    {
        _levelStructure += 1;
    }
}

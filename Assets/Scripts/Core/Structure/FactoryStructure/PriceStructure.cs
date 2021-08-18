using UnityEngine;

[CreateAssetMenu(fileName = "Factorys", menuName = "Factorys/Structure/PriceStructure", order = 1)]
public class PriceStructure : ScriptableObject
{
    [SerializeField] private Structure _structure;
    [SerializeField] private int _price;

    public Structure Structure => _structure;
    public int Price => _price;
}

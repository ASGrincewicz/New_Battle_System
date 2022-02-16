using UnityEngine;

[CreateAssetMenu(menuName ="Unit Stats", fileName = "Unit_Stats")]
public class Unit_Stats: ScriptableObject
{
    [SerializeField] private int _unitID = 0;
    [SerializeField] private string _unitName = "Fill this in.";
    [SerializeField] private int _health = 0;
    [SerializeField] private int _strength = 0;
    [SerializeField] private int _defense = 0;
    [SerializeField] private int _speed = 0;
    public int UnitID { get => _unitID; private set => _unitID = value; }
    public string UnitName { get => _unitName; private set => _unitName = value; }
    public int Health { get => _health; private set => _health = value; }
    public int Strength { get => _strength; private set => _strength = value; }
    public int Defense { get => _defense; private set => _defense = value; }
    public int Speed { get => _speed; private set => _speed = value; }

    private void OnEnable()
    {
        if(!Unit_Manager.GetStats(_unitID))
        {
            Unit_Manager.AddUnitStatsToDictionary(_unitID, this);
            Debug.Log($"{_unitID} was added.");
        }
    }
}
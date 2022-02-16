using UnityEngine;
using static Unit_Manager;

[CreateAssetMenu(menuName ="Unit Stats", fileName = "Unit_Stats")]
public class Unit_Stats: ScriptableObject, IHealth, IStrength, IDefense, ISpeed
{
    [SerializeField] private int _unitID = 0;
    [Tooltip("Set the Unit Name.")]
    [SerializeField] private string _unitName = "Fill this in.";
    [Tooltip("Set the Unit Health / Hit Points.")]
    [SerializeField] private int _health = 0;
    [Tooltip("Set the Unit Strength/Attack Power.")]
    [SerializeField] private int _strength = 0;
    [Tooltip("Set the Unit Defense/Toughness here.")]
    [SerializeField] private int _defense = 0;
    [Tooltip("Set the Unit Speed/Quickness here.")]
    [SerializeField] private int _speed = 0;
    public int UnitID { get => _unitID;}
    public string UnitName { get => _unitName;}
    public int Health { get => _health;}
    public int Strength { get => _strength;}
    public int Defense { get => _defense;}
    public int Speed { get => _speed;}

    private void OnEnable()
    {
        if(!GetStats(_unitID))
        {
            AddUnitStatsToDictionary(_unitID, this);
            Debug.Log($"{_unitID} was added.");
        }
        if (_health > MaxUnitHealth) _health = MaxUnitHealth;
        if (_strength > MaxUnitStrength) _strength = MaxUnitStrength;
        if (_defense > MaxUnitDefense) _defense = MaxUnitDefense;
        if (_speed > MaxUnitSpeed) _speed = MaxUnitSpeed;
    }
}

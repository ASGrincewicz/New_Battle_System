using UnityEngine;

public class Unit: MonoBehaviour
{
    [Tooltip("Use a 'Unit_Stats' asset here.")]
    [SerializeField] private Unit_Stats _stats;
    [SerializeField] private int _health = 0;
    [SerializeField] private int _strength = 0;
    [SerializeField] private int _defense = 0;
    [SerializeField] private int _speed = 0;
    public int Health { get => _health; set => _health = value; }
    public int Strenght { get => _strength; set => _strength = value; }
    public int Defense { get => _defense; set => _defense = value; }
    public int Speed { get => _speed; set => _speed = value; }

    private void Awake()
    {
        _health = _stats.Health;
        _strength = _stats.Strength;
        _defense = _stats.Defense;
        _speed = _stats.Speed;
    }
}
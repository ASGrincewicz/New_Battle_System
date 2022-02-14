using System;
using UnityEngine;

[CreateAssetMenu(menuName ="Unit Stats", fileName = "Unit_Stats")]
public class Unit_Stats: ScriptableObject
{
    [SerializeField] private int _health = 0;
    [SerializeField] private int _strength = 0;
    [SerializeField] private int _defense = 0;
    [SerializeField] private int _speed = 0;
    public int Health { get => _health;}
    public int Strength { get => _strength;}
    public int Defense { get => _defense;}
    public int Speed { get => _speed;}

}
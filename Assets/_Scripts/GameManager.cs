using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [Tooltip("Indictates true for player turn and false for opponent.")]
    [SerializeField] private bool _isPlayerTurn = false;

    [Header("Unit Management")]
    [SerializeField] private List<string> _units = new List<string>();
    public List<string> Units { get => _units; }


    private void OnEnable()
    {
        foreach(KeyValuePair<int, Unit_Stats> pair in Unit_Manager.UnitDictionary)
        {
            _units.Add(pair.Value.UnitName);
        }
        _units.Reverse();
    }
}

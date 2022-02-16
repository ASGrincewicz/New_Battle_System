using System.Collections.Generic;

public static class Unit_Manager
{
    //Create collection of Units
    private static Dictionary<int, Unit_Stats> _unitDictionary = new Dictionary<int, Unit_Stats>();
    public static Dictionary<int, Unit_Stats> UnitDictionary { get => _unitDictionary; }

    public static readonly int MaxUnitHealth = 100;
    public static readonly int MaxUnitStrength = 100;
    public static readonly int MaxUnitDefense = 100;
    public static readonly int MaxUnitSpeed = 100;

    //Method to return requested unit
    public static bool GetStats(int unitID)
    {
        if (_unitDictionary.ContainsKey(unitID))
            return true;
        else
            return false;
    }
    //Method to add unit
    public static void AddUnitStatsToDictionary(int unitID, Unit_Stats stats)
    {
        _unitDictionary.Add(unitID, stats);
    }

    //Method to delete unit
    public static void DeleteUnitStatsFromDictionary(int unitID)
    {
        if (_unitDictionary.ContainsKey(unitID)) _unitDictionary.Remove(unitID);
    }
}

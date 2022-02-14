using UnityEngine;

public class Singleton<T>: MonoBehaviour where T: Component
{
    protected static T _instance;

    public static T Instance { get => _instance; }

    private void Awake() => _instance = this as T;
}
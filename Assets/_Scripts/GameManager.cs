using System.Threading.Tasks;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [Tooltip("Indictates true for player turn and false for opponent.")]
    [SerializeField] private bool _isPlayerTurn = false;

    private void Start()
    {
       StartPlayerTurn();
    }

    private async void StartPlayerTurn()
    {
        while (!Input.GetKeyDown(KeyCode.Space))
        {
            await Task.Yield();
        }

       _isPlayerTurn = true;
        Debug.Log("Player Turn");
    }
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class UIManager:Singleton<UIManager>
{
    [Tooltip("Reference the battle screen canvas here.")]
    [SerializeField] private Canvas _battleUICanvas;
    [Header("Player UI")]
    [Tooltip("Reference the player UI panel here.")]
    [SerializeField] private Image _playerUIPanel;
    [Tooltip("Reference Player UI Action Buttons here.")]
    [SerializeField] private List<Button> _actionButtons;

    private void Awake()
    {
        foreach(var child in _playerUIPanel.transform.GetComponentsInChildren<Button>())
        {
            _actionButtons.Add(child);
        }
    }

}

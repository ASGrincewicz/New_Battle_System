using UnityEngine;
using UnityEngine.UI;

public class ActionButton : MonoBehaviour
{
    public enum ButtonPos { Top_Left, Top_Right, Bottom_Left, Bottom_Right }
    [Tooltip("Assign the button's position here.")]
    [SerializeField] private ButtonPos _buttonPosition;

    private void OnEnable()
    {
        switch (_buttonPosition)
        {
            case ButtonPos.Top_Left:
                transform.GetComponentInChildren<Text>().text = "Attack";
                break;
            case ButtonPos.Top_Right:
                transform.GetComponentInChildren<Text>().text = "Defend";
                break;
            case ButtonPos.Bottom_Left:
                transform.GetComponentInChildren<Text>().text = "Item";
                break;
            case ButtonPos.Bottom_Right:
                transform.GetComponentInChildren<Text>().text = "Escape";
                break;
        }
    }

}
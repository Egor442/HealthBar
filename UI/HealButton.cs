using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class HealButton : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private int _healPoint;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(OnClickButton);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnClickButton);
    }

    private void OnClickButton()
    {
        _player.Heal(_healPoint);
    }
}
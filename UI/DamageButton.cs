using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class DamageButton : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private int _damage;

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
        _player.TakeDamage(_damage);
    }
}
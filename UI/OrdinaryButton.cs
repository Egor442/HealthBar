using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class OrdinaryButton : MonoBehaviour
{
    [SerializeField] protected Player _player;
    [SerializeField] protected int _value;

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

    protected abstract void OnClickButton();
}
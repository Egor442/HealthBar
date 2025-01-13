using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class OrdinarySliderBar : TextBar
{
    [SerializeField] private Player _player;

    protected Slider _slider;
    protected float _targetValue;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _player.HealthChanged += SetTargetValue;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= SetTargetValue;
    }

    private void SetTargetValue(float value)
    {
        _targetValue = value;
        SetText((int)_slider.value, (int)_slider.maxValue);
    }
}
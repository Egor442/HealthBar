using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class OrdinarySliderBar : HealthBar
{
    protected Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void Update()
    {
        SetTargetValue();
        Slide();
    }

    protected override void SetTargetValue()
    {
        base.SetTargetValue();
    }

    protected virtual void Slide()
    {
        _slider.value = _targetValue;
    }
}
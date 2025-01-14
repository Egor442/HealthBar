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
        Slide();
    }

    protected override void SetTargetValue(float value)
    {
        base.SetTargetValue(value);
    }

    protected virtual void Slide()
    {
        _slider.value = _targetValue;
    }
}
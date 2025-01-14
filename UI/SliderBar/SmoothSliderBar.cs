using UnityEngine;

public class SmoothSliderBar : OrdinarySliderBar
{
    [SerializeField] private float _fillSpeed;

    protected override void Slide()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _targetValue, _fillSpeed * Time.deltaTime);
    }
}
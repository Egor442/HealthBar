using UnityEngine;

public class SmoothSlider : OrdinarySlider
{
    [SerializeField] private float _fillSpeed;

    private void Update()
    {
        Slide();
    }

    private void Slide()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _targetValue, _fillSpeed * Time.deltaTime);
        SetText();
    }
}
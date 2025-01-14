using TMPro;
using UnityEngine;

public class OrdinarySliderWithText : OrdinarySliderBar, IHealthBarWithText
{
    [SerializeField] private TMP_Text _healthBarText;

    public void SetText()
    {
        _healthBarText.text = $"{_slider.value}/{_slider.maxValue}";
    }

    protected override void SetTargetValue(float value)
    {
        base.SetTargetValue(value);
        SetText();
    }
}
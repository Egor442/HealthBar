using TMPro;
using UnityEngine;

public class SmoothSliderBarWithText : SmoothSliderBar, IHealthBarWithText
{
    [SerializeField] private TMP_Text _healthBarText;

    public void SetText()
    {
        _healthBarText.text = $"{(int)_slider.value}/{(int)_slider.maxValue}";
    }

    protected override void Slide()
    {
        base.Slide();
        SetText();
    }
}
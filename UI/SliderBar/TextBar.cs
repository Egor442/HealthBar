using TMPro;
using UnityEngine;

public class TextBar : MonoBehaviour
{
    [SerializeField] private TMP_Text _healthBarText;

    protected void SetText(int currentValue, int maxValue)
    {
        _healthBarText.text = $"{currentValue}/{maxValue}";
    }
}
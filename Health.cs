using UnityEngine;

public class Health
{
    private float _minValue;
    private float _maxValue;
    private float _value;

    public Health(float maxValue)
    {
        _minValue = 0;
        _maxValue = maxValue;
        _value = _maxValue;

        Validate();
    }

    public float CurrentValue => _value;

    public void AddValue(int heal)
    {
        _value += heal;
        Validate();
    }

    public void RemoveValue(int damage)
    {
        _value -= damage;
        Validate();
    }

    private void Validate()
    {
        _value = Mathf.Clamp(_value, _minValue, _maxValue);

        if (_minValue >= _maxValue)
        {
            _minValue = _maxValue - 1;
        }
    }
}
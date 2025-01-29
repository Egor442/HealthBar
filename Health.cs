using System;
using UnityEngine;

public class Health
{
    private float _minValue;
    private float _maxValue;

    public Health(float maxValue)
    {
        _minValue = 0;
        _maxValue = maxValue;
        Value = _maxValue;

        Validate();
    }

    public float Value { get; private set; }

    public void AddValue(int heal)
    {      
        Value += heal;
        Validate();
    }

    public void RemoveValue(int damage)
    {
        Value -= damage;
        Validate();
    }

    private void Validate()
    {
        Value = Mathf.Clamp(Value, _minValue, _maxValue);

        if (_minValue >= _maxValue)
        {
            _minValue = _maxValue - 1;
        }
    }
}
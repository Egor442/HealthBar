using System;
using UnityEngine;

public class Health
{
    private float _minValue;
    private float _maxValue;
    private float _value;

    public Health(float maxHealth)
    {
        _minValue = 0;
        _maxValue = maxHealth;
        _value = _maxValue;

        Validate();
    }

    public float CurrentHealth => _value;

    public void AddHealth(int heal)
    {
        _value += heal;
        Validate();
    }

    public void RemoveHealth(int damage)
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
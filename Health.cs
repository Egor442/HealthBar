using System;
using UnityEngine;

public class Health
{
    private float _minHealth;
    private float _maxHealth;
    private float _health;

    public Health(float maxHealth)
    {
        _minHealth = 0;
        _maxHealth = maxHealth;
        _health = _maxHealth;

        Validate();
    }

    public float CurrentHealth => _health;

    public void AddHealth(int heal)
    {
        _health += heal;
        Validate();
    }

    public void RemoveHealth(int damage)
    {
        _health -= damage;
        Validate();
    }

    private void Validate()
    {
        _health = Mathf.Clamp(_health, _minHealth, _maxHealth);

        if (_minHealth >= _maxHealth)
        {
            _minHealth = _maxHealth - 1;
        }
    }
}
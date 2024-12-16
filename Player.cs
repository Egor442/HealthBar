using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth;

    private Health _healthHandler;

    public Action<float> HealthChanged;

    private void Awake()
    {
        _healthHandler = new Health(_maxHealth);
    }

    private void Start()
    {
        HealthChanged?.Invoke(_healthHandler.CurrentHealth);
    }

    public void Heal(int health)
    {
        _healthHandler.AddHealth(health);
        HealthChanged?.Invoke(_healthHandler.CurrentHealth);
    }

    public void TakeDamage(int damage)
    {
        _healthHandler.RemoveHealth(damage);
        HealthChanged?.Invoke(_healthHandler.CurrentHealth);
    }   
}
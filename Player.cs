using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth;

    public Health Health { get; private set; }

    private void Awake()
    {
        Health = new Health(_maxHealth);
    }

    public void Heal(int health)
    {
        Health.AddValue(health);
    }

    public void TakeDamage(int damage)
    {
        Health.RemoveValue(damage);
    }
}
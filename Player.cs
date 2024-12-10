using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealth;

    private HealthHandler _healthHandler;

    public UnityAction<int> HealthChanged;

    private void Awake()
    {
        _healthHandler = new HealthHandler(_maxHealth);
    }

    private void Start()
    {
        HealthChanged?.Invoke(_healthHandler.Health);
    }

    public void Heal(int health)
    {
        _healthHandler.AddHealth(health);
        HealthChanged?.Invoke(_healthHandler.Health);
    }

    public void TakeDamage(int damage)
    {
        _healthHandler.RemoveHealth(damage);
        HealthChanged?.Invoke(_healthHandler.Health);
    }   
}
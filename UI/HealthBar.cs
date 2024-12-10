using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _degreeOccupancy;

    private Slider _healthBar;

    private void Awake()
    {
        _healthBar = GetComponent<Slider>();
    }
    
    private void OnEnable()
    {
        _player.HealthChanged += SetHealth;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= SetHealth;
    }

    public void SetHealth(int health)
    {
        _healthBar.value = health;
        _degreeOccupancy.text = $"{_healthBar.value}/{_healthBar.maxValue}";
    }
}
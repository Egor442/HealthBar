using TMPro;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;

    protected float _targetValue;

    private void OnEnable()
    {
        _player.HealthChanged += SetTargetValue;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= SetTargetValue;
    }

    protected virtual void SetTargetValue(float value)
    {
        _targetValue = value;
    }
}
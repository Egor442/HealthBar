using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;

    protected float _targetValue;

    protected virtual void SetTargetValue()
    {
        _targetValue = _player.Health.Value;
    }
}
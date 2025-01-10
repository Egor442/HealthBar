public class DamageButton : OrdinaryButton
{
    protected override void OnClickButton()
    {
        _player.TakeDamage(_value);
    }
}
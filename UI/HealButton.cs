public class HealButton : OrdinaryButton
{
    protected override void OnClickButton()
    {
        _player.Heal(_value);
    }
}
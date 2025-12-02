using UnityEngine;

public class SpeedBoot : PowerUpbase
{
    public override void ApplyEffect(Player player)
    {
        player.SetMoveSpeed(2);
        IsEffectActive = true;
        Destroy(gameObject);
    }
}

using UnityEngine;

public class SpeedBoot : PowerUpbase
{
    public override void ApplyEffect(Player player)
    {
        player.SetMoveSpeed(2);
        Destroy(gameObject);
    }
}

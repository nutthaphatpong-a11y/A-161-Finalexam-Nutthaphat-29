using UnityEngine;

public class Ahhhhhh : PowerUpbase
{
    public override void ApplyEffect(Player player)
    {
        player.TakeDamage(5);
        IsEffectActive = true;
        Destroy(gameObject);
    }
}

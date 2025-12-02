using UnityEngine;

public class ShieldEffect : PowerUpbase
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void ApplyEffect(Player player)
    {
        
        player.SetisInvulnerability(true);
        IsEffectActive = true;
        Destroy(gameObject);
    }
}

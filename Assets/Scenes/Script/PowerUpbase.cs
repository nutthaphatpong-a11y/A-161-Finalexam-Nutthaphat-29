using System;
using Unity.VisualScripting;
using UnityEngine;

public abstract class PowerUpbase : MonoBehaviour
{
    bool IsEffectActive = false;
    public Player player;

    public abstract void ApplyEffect(Player player);


}

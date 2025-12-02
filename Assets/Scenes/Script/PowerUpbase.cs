using System;
using Unity.VisualScripting;
using UnityEngine;

public abstract class PowerUpbase : MonoBehaviour
{
    public bool IsEffectActive = false;
    

    public abstract void ApplyEffect(Player player);


}

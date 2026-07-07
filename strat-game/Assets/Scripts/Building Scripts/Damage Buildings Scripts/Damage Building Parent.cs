using UnityEngine;

public abstract class DamageBuilding : Building
{

    [Tooltip("Soft Damage for a given building")]
    public float softDamage;

    [Tooltip("Hard Damage for a given building")]
    public float hardDamage;

    [Tooltip("Air Damage for a given building")]
    public float airDamage;

    [Tooltip("Range for a given building")]
    public float range;

    public virtual void Attack()
    {

    }
}

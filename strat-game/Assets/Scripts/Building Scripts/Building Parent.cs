using UnityEngine;

public abstract class Building : MonoBehaviour
{
    [Header("Interactions")]
    // This is for stuff like uimanager, soundmanager, and other things that need to interact with a unit

    [Header("Stats")]
    // This is for unit stats, including hp, soft damage, hard damage, air damage, speed, range, target, classification, cost

    [Tooltip("HP for a given unit")]
    public float hitPoints;

    [Header("Location")]
    public int locationX;
    public int locationY;

    // intialize building object
    public virtual void TakeDamage()
    {

    }
}
using UnityEngine;

public enum UnitClassification {soft, hard, air}
public enum UnitActionState {idle, moving, attacking}

public class UnitScript : MonoBehaviour
{
    [Header("Interactions")]
    // This is for stuff like uimanager, soundmanager, and other things that need to interact with a unit

    [Header("Stats")]
    // This is for unit stats, including hp, soft damage, hard damage, air damage, speed, range, target, classification, cost

    [Tooltip("HP for a given unit")]
    public float hitPoints;

    [Tooltip("Soft Damage for a given unit")]
    public float softDamage;

    [Tooltip("Hard Damage for a given unit")]
    public float hardDamage;

    [Tooltip("Air Damage for a given unit")]
    public float airDamage;

    [Tooltip("Speed for a given unit")]
    public float speed;

    [Tooltip("Range for a given unit")]
    public float range;

    [Tooltip("Target location for a given unit")]
    public Transform target;

    [Tooltip("Classification for a given unit")]
    public UnitClassification classification;

    [Tooltip("Action state for a given unit")]
    public UnitActionState actionState;

    [Tooltip("Cost for a given unit (in resources)")]
    public ResourceScript cost;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (actionState == UnitActionState.moving)
        Move();
    }


    // unit functions
    // move, attack, take damage, die

    private void Move()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target.position, step);
    }

    private void SetTarget()
    {
        
    }

}

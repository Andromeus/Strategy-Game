using UnityEngine;

[System.Serializable]
public class ResourceScript
{

    // This is a script for storing resource info and functions
    public int suppliesCount;
    public int orichalcumCount;
    public int voidglassCount;

    public void Incremenent(int amount)
    {
        suppliesCount += amount;
    }

}

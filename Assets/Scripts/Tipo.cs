using UnityEngine;

public class Tipo : MonoBehaviour
{
    public enum ItemType
    {
        armas,
        armadura,
        consumivel,
    }

    public ItemType itemType;
    public int amount;
}
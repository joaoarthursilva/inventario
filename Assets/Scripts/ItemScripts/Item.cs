using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public ItemType itemType;
    public string itemName;
    public string description;
    public int level;

    public abstract int GetDano();

    public abstract int GetVida();

    public abstract int GetMana();
    
    public abstract ItemDTO GetDto();
}
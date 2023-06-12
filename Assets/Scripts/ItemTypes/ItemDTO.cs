using UnityEngine;

public abstract class ItemDTO : ScriptableObject
{
    public ItemType itemType;
    public string nome;
    public string descricao;
    public int level;
}
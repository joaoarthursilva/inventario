public class Feet : Armor
{
    public int health;
    public PesDTO pesDto;

    private void Start()
    {
        ManageDTO();
    }

    private void ManageDTO()
    {
        itemName = pesDto.nome;
        description = pesDto.descricao;
        level = pesDto.level;
        health = pesDto.vida;
        mana = pesDto.mana;
        itemType = pesDto.itemType;
    }

    public override int GetDano()
    {
        return 0;
    }

    public override int GetVida()
    {
        return health;
    }
    
    public override ItemDTO GetDto()
    {
        return pesDto;
    }
}
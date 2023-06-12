public class Body : Armor
{
    public int health;
    public CorpoDTO corpoDto;

    private void Start()
    {
        ManageDto();
    }

    private void ManageDto()
    {
        itemName = corpoDto.nome;
        description = corpoDto.descricao;
        level = corpoDto.level;
        health = corpoDto.vida;
        mana = corpoDto.mana;
        itemType = corpoDto.itemType;
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
        return corpoDto;
    }
}
public class Head : Armor
{
    public int damage;
    public CabecaDTO cabecaDto;

    private void Start()
    {
        ManageDTO();
    }

    private void ManageDTO()
    {
        itemName = cabecaDto.nome;
        description = cabecaDto.descricao;
        level = cabecaDto.level;
        damage = cabecaDto.dano;
        mana = cabecaDto.mana;
        itemType = cabecaDto.itemType;
    }

    public override int GetDano()
    {
        return damage;
    }

    public override int GetVida()
    {
        return 0;
    }

    public override ItemDTO GetDto()
    {
        return cabecaDto;
    }
}

public class WeaponHealth : Weapon
{
    public int health;
    public ArmaVidaDTO weaponHealthDto;

    private void Start()
    {
        ManageDto();
    }

    private void ManageDto()
    {
        itemName = weaponHealthDto.nome;
        description = weaponHealthDto.descricao;
        level = weaponHealthDto.level;
        health = weaponHealthDto.vida;
        damage = weaponHealthDto.dano;
        itemType = weaponHealthDto.itemType;
    }

    public override int GetVida()
    {
        return health;
    }

    public override int GetMana()
    {
        return 0;
    }
    
    public override ItemDTO GetDto()
    {
        return weaponHealthDto;
    }
}
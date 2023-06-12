using UnityEngine.Serialization;

public class WeaponMana : Weapon
{
    public int mana;
    public ArmaManaDTO weaponManaDto;

    private void Start()
    {
        ManageDto();
    }

    private void ManageDto()
    {
        itemName = weaponManaDto.nome;
        description = weaponManaDto.descricao;
        level = weaponManaDto.level;
        mana = weaponManaDto.mana;
        damage = weaponManaDto.dano;
        itemType = weaponManaDto.itemType;
    }

    public override int GetVida()
    {
        return 0;
    }

    public override int GetMana()
    {
        return mana;
    }
    public override ItemDTO GetDto()
    {
        return weaponManaDto;
    }
}
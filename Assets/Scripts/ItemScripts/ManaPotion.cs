using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

public class ManaPotion : Consumable, IPointerClickHandler
{
    private bool _canDoubleClick;
    public int mana;
    public PocaoManaDTO pocaoManaDto;

    private void Start()
    {
        _canDoubleClick = false;
        ManageDto();
    }

    private void ManageDto()
    {
        itemName = pocaoManaDto.nome;
        description = pocaoManaDto.descricao;
        level = pocaoManaDto.level;
        mana = pocaoManaDto.mana;
        itemType = pocaoManaDto.itemType;
    }

    public void OnPointerClick(PointerEventData eventData) // aparecer infos do item e manage no double click
    {
        if (_canDoubleClick)
        {
            //consome o item
            FindObjectOfType<EquipStats>().AddManaModifier(mana);
            CancelInvoke();
            Destroy(gameObject);
        }
        else
        {
            // FindObjectOfType<InfoBoxManager>().SetDto(pocaoManaDto, 0, mana, 0);
            _canDoubleClick = true;
            Invoke(nameof(ResetDoubleClick), .3f);
        }
    }

    private void ResetDoubleClick()
    {
        _canDoubleClick = false;
    }

    public override int GetDano()
    {
        return 0;
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
        return pocaoManaDto;
    }
}
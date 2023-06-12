using UnityEngine.EventSystems;

public class DamagePotion : Consumable, IPointerClickHandler
{
    private bool _canDoubleClick;
    public int dano;
    public PocaoDanoDTO pocaoDanoDto;

    private void Start()
    {
        _canDoubleClick = false;
        ManageDto();
    }

    private void ManageDto()
    {
        itemName = pocaoDanoDto.nome;
        description = pocaoDanoDto.descricao;
        level = pocaoDanoDto.level;
        dano = pocaoDanoDto.dano;
        itemType = pocaoDanoDto.itemType;
    }

    public void OnPointerClick(PointerEventData eventData) // aparecer infos do item e manage no double click
    {
        if (_canDoubleClick)
        {
            //consome o item
            FindObjectOfType<EquipStats>().AddDamageModifier(dano);
            CancelInvoke();
            Destroy(gameObject);
        }
        else
        {
            // FindObjectOfType<InfoBoxManager>().SetDto(pocaoDanoDto, dano, 0, 0);
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
        return dano;
    }

    public override int GetVida()
    {
        return 0;
    }

    public override int GetMana()
    {
        return 0;
    }
    public override ItemDTO GetDto()
    {
        return pocaoDanoDto;
    }
}
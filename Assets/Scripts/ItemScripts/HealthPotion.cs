using UnityEngine.EventSystems;

public class HealthPotion : Consumable, IPointerClickHandler
{
    private bool _canDoubleClick;
    public int vida;
    public PocaoVidaDTO pocaoVidaDto;

    private void Start()
    {
        _canDoubleClick = false;
        ManageDto();
    }

    private void ManageDto()
    {
        itemName = pocaoVidaDto.nome;
        description = pocaoVidaDto.descricao;
        level = pocaoVidaDto.level;
        vida = pocaoVidaDto.vida;
        itemType = pocaoVidaDto.itemType;
    }

    public void OnPointerClick(PointerEventData eventData) // aparecer infos do item e manage no double click
    {
        if (_canDoubleClick)
        {
            //consome o item
            FindObjectOfType<EquipStats>().AddHealthModifier(vida);
            CancelInvoke();
            Destroy(gameObject);
        }
        else
        {
            // FindObjectOfType<InfoBoxManager>().SetDto(pocaoVidaDto, 0, 0, vida);
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
        return vida;
    }

    public override int GetMana()
    {
        return 0;
    }

    public override ItemDTO GetDto()
    {
        return pocaoVidaDto;
    }
}
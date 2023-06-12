using TMPro;
using UnityEngine;

public class InfoBoxManager : MonoBehaviour
{
    public GameObject infoBoxGameObject;
    public TextMeshProUGUI nomeTxt;
    public TextMeshProUGUI descricaoTxt;
    public TextMeshProUGUI levelTxt;
    public TextMeshProUGUI statsTxt;

    private ItemDTO _itemDto;
    private int _mana;
    private int _health;
    private int _dmg;

    private void Start()
    {
        infoBoxGameObject.SetActive(false);
    }

    public void DeactivateInfoBox()
    {
        infoBoxGameObject.SetActive(false);
    }

    private void Update()
    {
        if (!_itemDto) return;
        nomeTxt.text = _itemDto.nome;
        descricaoTxt.text = _itemDto.descricao;
        levelTxt.text = $"{_itemDto.level}";
        statsTxt.text = $"DMG +{_dmg}, MANA +{_mana}, HP +{_health}";
    }

    public void SetDto(ItemDTO itemDto, int dmg, int mana, int health)
    {
        infoBoxGameObject.SetActive(true);
        _dmg = dmg;
        _mana = mana;
        _health = health;
        _itemDto = itemDto;
    }
}
using TMPro;
using UnityEngine;
using System.Linq;

public class EquipStats : MonoBehaviour
{
    public TextMeshProUGUI vidaTxt;
    public TextMeshProUGUI manaTxt;
    public TextMeshProUGUI danoTxt;

    private int _currentHealth;
    private int _currentDamage;
    private int _currentMana;

    private int _healthModifier = 0;
    private int _damageModifier = 0;
    private int _manaModifier = 0;

    private void Update()
    {
        var equippedItems = GetComponentsInChildren<Item>().ToList();

        _currentHealth = 0 + _healthModifier;
        _currentDamage = 0 + _damageModifier;
        _currentMana = 0 + _manaModifier;
        foreach (var item in equippedItems)
        {
            _currentHealth += item.GetVida();
            _currentDamage += item.GetDano();
            _currentMana += item.GetMana();
        }


        vidaTxt.text = $"Vida: {_currentHealth}";
        danoTxt.text = $"Dano: {_currentDamage}";
        manaTxt.text = $"Mana: {_currentMana}";
    }

    public void AddHealthModifier(int qtd)
    {
        _healthModifier += qtd;
    }

    public void AddDamageModifier(int qtd)
    {
        _damageModifier += qtd;
    }

    public void AddManaModifier(int qtd)
    {
        _manaModifier += qtd;
    }
}
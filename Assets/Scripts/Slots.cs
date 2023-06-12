using UnityEngine;
using UnityEngine.EventSystems;

public class Slots : MonoBehaviour, IDropHandler
{
    public ItemType slotType;
    public bool isInventory = false;

    public void OnDrop(PointerEventData eventData)
    {
        // se o slot não é compativel, não transfere o item
        if (eventData.pointerDrag.GetComponent<Item>().itemType != slotType && !isInventory)
        {
            return;
        }

        if (transform.childCount == 0) // se nao tiver item no slot alvo
        {
            var dropped = eventData.pointerDrag; // objeto soltado no slot
            var draggableItem = dropped.GetComponent<Drag>();
            draggableItem.parentAftDrag = transform;
        }
        else if (transform.childCount == 1 && // se tem um item no slot alvo
                 eventData.pointerDrag.GetComponent<Item>().itemType ==
                 slotType // o tipo do item é compatível com o slot
                 && !isInventory) // e não é um slot do inventário
        {
            var draggableItem = eventData.pointerDrag.GetComponent<Drag>(); // item que está vindo 
            var slotDeOndeEstaVindo = draggableItem.parentAftDrag;
            var slotAlvo = transform.GetChild(0).GetComponent<Drag>().parentAftDrag;

            transform.GetChild(0).SetParent(slotDeOndeEstaVindo);
            draggableItem.parentAftDrag = slotAlvo;
            //substituir os stats
        }
    }
}
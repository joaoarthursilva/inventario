using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler
{
    public Image image;
    [HideInInspector] public Transform parentAftDrag;

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentAftDrag = transform.parent; // slot de onde saiu
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentAftDrag); // slot onde foi largado, a variavel é alterada pelo script Slots
        image.raycastTarget = true;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        var item = gameObject.GetComponent<Item>();
        FindObjectOfType<InfoBoxManager>().SetDto(item.GetDto(), item.GetDano(), item.GetMana(), item.GetVida());

        // aparecer infos do item
    }
}
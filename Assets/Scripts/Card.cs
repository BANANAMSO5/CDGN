using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour,
    IPointerEnterHandler,
    IPointerExitHandler
{
    public Hand hand;

    public void OnPointerEnter(PointerEventData eventData)
    {
        hand.SetHoverCard(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hand.SetHoverCard(null);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour,
    IBeginDragHandler,
    IDragHandler,
    IEndDragHandler
{
    public Hand hand;

    private Vector3 startPosition;
    private Canvas canvas;

    private void Awake()
    {
        canvas = GetComponentInParent<Canvas>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //hand.SetHoverCard(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //hand.SetHoverCard(null);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        startPosition = transform.position;

        // 一番手前に表示
        transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position +=
            (Vector3)eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // 仮: 元の場所へ戻す
        transform.position = startPosition;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    [SerializeField]
    private float spacing = 180f;

    [SerializeField]
    private float hoverOffset = 30f;

    private Card hoverCard;

    public void SetHoverCard(Card card)
    {
        hoverCard = card;
        UpdateLayout();
    }

    private void Start()
    {
        UpdateLayout();
    }

    public void UpdateLayout()
    {
        int count = transform.childCount;

        for (int i = 0; i < count; i++)
        {
            RectTransform card =
                transform.GetChild(i).GetComponent<RectTransform>();

            float x =
                (i - (count - 1) * 0.5f) * spacing;

            float y = 0;

            if (hoverCard != null &&
                hoverCard.transform == card)
            {
                y += hoverOffset;
            }

            card.anchoredPosition =
                new Vector2(x, y);
        }
    }
}

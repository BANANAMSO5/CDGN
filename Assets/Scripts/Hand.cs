using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    [SerializeField]
    private float spacing = 180f;

    [SerializeField]
    private float hoverOffset = 30f;

    [SerializeField]
    private Card cardPrefab;

    private List<Card> cards = new();

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

    public void AddCard()
    {
        Card card = Instantiate(cardPrefab, transform);

        cards.Add(card);

        RefreshHand();
    }

    private void RefreshHand()
    {
        int count = cards.Count;
        float spacing = 150f;

        float totalWidth = (count - 1) * spacing;
        float startX = -totalWidth / 2f;

        for (int i = 0; i < count; i++)
        {
            cards[i].transform.localPosition =
                new Vector3(startX + i * spacing, 0, 0);
        }
    }
}

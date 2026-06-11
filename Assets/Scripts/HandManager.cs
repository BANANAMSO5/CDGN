using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandManager : MonoBehaviour
{
    public List<Transform> cards = new();

    [SerializeField]
    public Hand hand;

    public void AddCard()
    {
        hand.AddCard();
    }
}

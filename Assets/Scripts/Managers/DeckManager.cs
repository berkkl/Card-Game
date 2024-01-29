using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class DeckManager : MonoBehaviour
{
    public static DeckManager instance;
    void Awake() {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
    
    public GameObject cardPrefab;
    public Transform cardParent;
    public Vector2 cardSize = new Vector2(117, 175);
    public float cardSpacing = 13f; // Spacing between cards
    public List<Card> handCards;
    public List<Card> deckPile = new List<Card>(); // The deck of cards
    private List<Card> discardPile = new List<Card>(); // The discard pile
    private void Start()
    {
    }
    public void InitializeDeck(Card[] cards)
    {
        deckPile.Clear();
        foreach (var card in cards)
        {
            if (!deckPile.Contains(card)) // Ensure no duplicates
            {
                deckPile.Add(card);
            }
        }
    }
    
    public Card DrawCardFromDeck(int index)
    {
        Card cardData = DrawCard();

        if (cardData != null)
        {
            GameObject cardObject = Instantiate(cardPrefab, cardParent);
            Image cardImage = cardObject.GetComponentInChildren<Image>();
            cardImage.transform.localPosition = new Vector3((cardSize.x + cardSpacing) * (index - 2), 0, 0); // Position cards with spacing
            CardDisplay cardDisplay = cardObject.GetComponent<CardDisplay>();
            cardDisplay.SetCardData(cardData);
        }
        
        return cardData;
    }
    public void ShuffleDeck()
    {
        for (int i = 0; i < deckPile.Count; i++)
        {
            Card temp = deckPile[i];
            int randomIndex = Random.Range(i, deckPile.Count);
            deckPile[i] = deckPile[randomIndex];
            deckPile[randomIndex] = temp;
        }
    }

    public Card DrawCard()
    {
        if (deckPile.Count <= 0)
        {
            return null; // No more cards to draw
        }

        Card cardDrawn = deckPile[0];
        deckPile.RemoveAt(0);
        return cardDrawn;
    }

    public void DiscardCard(Card card)
    {
        discardPile.Add(card);
    }
}
using UnityEngine;

public class DeckController : MonoBehaviour
{
    public DeckManager deckManager;

    public void DrawCardFromDeck()
    {
        Card cardData = deckManager.DrawCard();

        if (cardData != null)
        {
            GameObject cardObject = Instantiate(deckManager.cardPrefab, deckManager.cardParent);
            CardDisplay cardDisplay = cardObject.GetComponent<CardDisplay>();
            cardDisplay.SetCardData(cardData);
        }
    }

    public void ShuffleDeck()
    {
        deckManager.ShuffleDeck();
    }

    // Example method for discarding a card
    public void DiscardCard(Card card)
    {
        deckManager.DiscardCard(card);
    }
}
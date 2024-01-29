using UnityEngine;

public class GameManager : MonoBehaviour
{    
    public static GameManager instance;
    public Card[] allCards; // Add a public field for all card ScriptableObjects

    void Awake() {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        // Initialize the deck from the GameManager
        DeckManager.instance.InitializeDeck(allCards);
        
        // Draw the initial 5 cards
        for(int i = 0; i < 5; i++) 
        {
            Card cardToAdd = DeckManager.instance.DrawCardFromDeck(i);
            DeckManager.instance.handCards.Add(cardToAdd);
        }
    }
}
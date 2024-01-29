using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler Instance;

    public GameObject cardPrefab;
    public int poolSize = 30;

    private Queue<GameObject> cardPool = new Queue<GameObject>();

    void Awake()
    {
        Instance = this;
        InitializePool();
    }

    void InitializePool()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject newCard = Instantiate(cardPrefab, transform);
            newCard.SetActive(false);
            cardPool.Enqueue(newCard);
        }
    }

    public GameObject GetCardFromPool()
    {
        if (cardPool.Count > 0)
        {
            GameObject card = cardPool.Dequeue();
            card.SetActive(true);
            return card;
        }
        else
        {
            // Optional: Instantiate new cards if the pool runs out.
            GameObject newCard = Instantiate(cardPrefab, transform);
            return newCard;
        }
    }

    public void ReturnCardToPool(GameObject card)
    {
        card.SetActive(false);
        cardPool.Enqueue(card);
    }
}
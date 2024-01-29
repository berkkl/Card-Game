using UnityEngine;
using UnityEngine.UI;
using TMPro; // If using TextMeshPro

public class CardDisplay : MonoBehaviour
{
    public Card cardData;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    //public Image artworkImage;

    public void SetCardData(Card card)
    {
        cardData = card;

        nameText.text = card.cardName;
        descriptionText.text = card.description;
        //artworkImage.sprite = card.artwork; 
        gameObject.SetActive(true);
    }
    
    public void ReturnToPool()
    {
        gameObject.SetActive(false);
    }
}
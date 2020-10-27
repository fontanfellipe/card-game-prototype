using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCard : MonoBehaviour
{
    public Card card;

    public Text nameCardField;
    public Text descriptionCardField;
    public Image imageCardField;
    public Text attackCardField;
    public Text defenseCardField;

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void Show (Card showingCard)
    {
        card = showingCard;
        nameCardField.text = card.hero;
        descriptionCardField.text = card.description;
        imageCardField.sprite = card.image;
        attackCardField.text = "" + card.attack.ToString();
        defenseCardField.text = "" + card.defense.ToString();
        GetComponent<Image>().color = card.color;
        gameObject.SetActive(true);
    }
}

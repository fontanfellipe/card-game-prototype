using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameController : MonoBehaviour
{
    public List<Card> gameCards;

    public List<ShowCard> activeCards;

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void GetCard ()
    {
        int cardNumber = UnityEngine.Random.Range(0, 3);
        Card chosenCard = gameCards[cardNumber];
        activeCards[0].Show(chosenCard);
    }
}

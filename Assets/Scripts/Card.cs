using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public string hero;
    public string description;
    public Sprite image;
    public int attack;
    public int defense;
    public Color color;
}

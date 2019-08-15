using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Card Game", menuName = "Card/Card 13")]
public class CardModel : ScriptableObject
{
    public int number;
    public Color_Card color;
    public Ki_Hieu kihieu;
    public Sprite image;
}
public enum Color_Card
{
    Red,Black
}
public enum Ki_Hieu
{
    Nothing,J,Q,K,A
}

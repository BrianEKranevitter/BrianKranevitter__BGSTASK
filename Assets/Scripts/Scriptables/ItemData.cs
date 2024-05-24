using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "ItemData", menuName = "ItemData")]
public class ItemData : ScriptableObject
{
    public int price;
    public Item item;
}
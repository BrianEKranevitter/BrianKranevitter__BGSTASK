using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitManager : MonoBehaviour
{

    SpriteRenderer[] head, torso, legs;
    
    public void ChangeOutfit(Sprite[] newOutfit, OutfitType type)
    {
        switch (type)
        {

            case OutfitType.Head:

                for (int i = 0; i < head.Length; i++)
                {
                    head[i].sprite = newOutfit[i];
                }
                break;

            case OutfitType.Torso:

                for (int i = 0; i < torso.Length; i++)
                {
                    torso[i].sprite = newOutfit[i];
                }
                break;

            case OutfitType.Legs:

                for (int i = 0; i < legs.Length; i++)
                {
                    legs[i].sprite = newOutfit[i];
                }
                break;
        }
    }
}
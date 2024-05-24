using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public UI_ShopManager sm;
    OutfitManager ofm;
    [SerializeField]
    GameObject equipedMessage;
    public int price;
    public Sprite[] parts;
    public bool equiped;
    public OutfitType type;

    void Awake()
    {
        ofm = FindObjectOfType<OutfitManager>();
    }
    public void Sell()
    {
        if (!equiped)
            sm.SellItem(this, price);
        else
            ShowEquipedMessage();
    }

    public void Equip()
    {
        if (!equiped)
        {
            ofm.ChangeOutfit(parts, type);
            equiped = true;
            sm.ChangeEquiped(this, type);
        }
        else
            ShowEquipedMessage();
    }

    void ShowEquipedMessage()
    {
        equipedMessage.SetActive(true);
        StartCoroutine(ShowEquipedMessageTimer());
    }

    IEnumerator ShowEquipedMessageTimer()
    {
        yield return new WaitForSeconds(1);
        equipedMessage.SetActive(false);
    }
}
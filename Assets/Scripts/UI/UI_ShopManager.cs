using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_ShopManager : MonoBehaviour
{
    public InventorySlot[] inventorySlots;
    [SerializeField]
    Image ExpMsg, InvFullMsg;
    [SerializeField]
    GameObject[] itemPanels;
    public Item equipedHead, equipedPants, equipedTorso;







    public void TryToBuyItem(ItemData data)
    {

    }
    public void BuyItem(ItemData data)
    {

    }

    public void SellItem(Item item, int price)
    {

    }
    public void ShowExpensiveMessage()
    {

    }
    public void ShowInventoryFullMessage()
    {

    }

    public void ChangePanel(int index)
    {

    }

    public void LookForSlot()
    {

    }

    public void ChangeEquiped(Item item, OutfitType type)
    {

    }
}
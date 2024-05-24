using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_ShopManager : MonoBehaviour
{
    [SerializeField]
    GameObject shopHolder;
    public InventorySlot[] inventorySlots;
    [SerializeField]
    GameObject ExpMsg, InvFullMsg;
    [SerializeField]
    GameObject[] itemPanels;
    public Item equipedHead, equipedPants, equipedTorso;

    private void Awake()
    {
        ShopTrigger.onShopTriggerIn += OpenShop;
        ShopTrigger.onShopTriggerOut += CloseShop;
    }


    void OpenShop()
    {
        shopHolder.SetActive(true);
    }

    void CloseShop()
    {
        shopHolder.SetActive(false);
    }

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
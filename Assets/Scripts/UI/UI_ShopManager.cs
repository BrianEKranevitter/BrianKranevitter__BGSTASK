using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

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
        var slotValues = LookForSlot(data);

        if (data.price > GameManager.Instance.gold)
            ShowExpensiveMessage();
        else if (slotValues.Item1)
            BuyItem(data, slotValues.Item2);
        else
            ShowInventoryFullMessage();
    }

    public void BuyItem(ItemData data, int slotIndex)
    {
        GameManager.Instance.UpdateGold(-data.price);
        UI_GeneralManager.Instance.UpdateGoldText();
        Item _item = GameObject.Instantiate(data.item, inventorySlots[slotIndex].transform);
        inventorySlots[slotIndex].item = _item;
        _item.sm = this;
    }

    public void SellItem(Item item, int price)
    {
        GameManager.Instance.UpdateGold(item.price);
        UI_GeneralManager.Instance.UpdateGoldText();
        Destroy(item.gameObject);
    }

    public void ShowExpensiveMessage()
    {
        ExpMsg.SetActive(true);
        StartCoroutine(ShowExpensiveMessageTimer());
    }

    public void ShowInventoryFullMessage()
    {
        InvFullMsg.SetActive(true);
        StartCoroutine(ShowInventoryFullMesssageTimer());
    }

    public void ChangePanel(int index)
    {
        for (int i = 0; i < itemPanels.Length; i++)
        {
            if (i != index)
                itemPanels[i].SetActive(false);
            else
                itemPanels[i].SetActive(true);
        }
    }

    public Tuple<bool, int> LookForSlot(ItemData data)
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            if (inventorySlots[i].item == null)
            {
                return Tuple.Create(true, i);
            }
        }
        return Tuple.Create(false, 0);
    }

    public void ChangeEquiped(Item item, OutfitType type)
    {
        switch (type)
        {

            case OutfitType.Head:

                if (equipedHead != null) equipedHead.equiped = false;
                equipedHead = item;
                break;

            case OutfitType.Torso:

                if (equipedTorso != null) equipedTorso.equiped = false;
                equipedTorso = item;
                break;

            case OutfitType.Legs:

                if (equipedPants != null) equipedPants.equiped = false;
                equipedPants = item;
                break;
        }
    }

    IEnumerator ShowExpensiveMessageTimer()
    {
        yield return new WaitForSeconds(2);
        ExpMsg.SetActive(false);
    }

    IEnumerator ShowInventoryFullMesssageTimer()
    {
        yield return new WaitForSeconds(2);
        InvFullMsg.SetActive(false);
    }
}
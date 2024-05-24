using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShopTrigger : MonoBehaviour
{
    public static Action onShopTriggerIn, onShopTriggerOut;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 6)
        {
            Debug.Log("PlayerEntered");
            onShopTriggerIn?.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Debug.Log("PlayerExit");
            onShopTriggerOut?.Invoke();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_GeneralManager : MonoBehaviour
{
    public static UI_GeneralManager Instance { get; private set; }
    public TextMeshProUGUI currentGoldText;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
    public void UpdateGoldText()
    {
        currentGoldText.text = "" + GameManager.Instance.gold;
    }
}
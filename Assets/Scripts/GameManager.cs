using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public int initialGold;

    [HideInInspector]
    public int gold;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

       // UpdateGold(initialGold);
    }

    public void UpdateGold(int value)
    {
        gold += value;
    }
}
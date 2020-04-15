﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject explainControls;

    public TextMeshProUGUI nameMulkyWay;
    public TextMeshProUGUI counterStars;

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);

        nameMulkyWay.text = "";
    }

    //Counting Stars - OneRepublic
    public void CountingStars(int amount)
    {
        counterStars.text = amount + " stars left";
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuMiniManager : MonoBehaviour
{
    [SerializeField] public GameObject ShopPanel;
    [SerializeField] public int Score;
    [SerializeField] public Text ScoreText;

    private void Update()
    {
        Score = PlayerPrefs.GetInt("allScore");
        ScoreText.text = "Score: " + Score.ToString();
    }

    public void OpenShopButtonClick()
    {
       ShopPanel.SetActive(true); 
    }
}

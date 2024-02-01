using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int _score;
    public static int allScore;
    public int ScoreMenu;

    [SerializeField] private Text allScoreText;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text gameOverScoreText;
    [SerializeField] private GameObject _soldGO;

    [Space(20)] 
    [SerializeField] private Text buyButtonText;
    private void Start()
    {
        _score = PlayerPrefs.GetInt("score");
        allScore = PlayerPrefs.GetInt("allScore");
        Item.itemStatus = PlayerPrefs.GetInt("itemStatus");
        PlayerPrefs.SetInt("score", _score = 0);
    }

    private void Update()
    {
        PlayerPrefs.SetInt("score", _score);
        PlayerPrefs.SetInt("allScore", allScore);
        PlayerPrefs.SetInt("itemStatus", Item.itemStatus);
        ScoreMenu = PlayerPrefs.GetInt("score");
        scoreText.text = "Score: " + _score;
        gameOverScoreText.text = "Score: " + _score;
        allScoreText.text = "Score: " + ScoreMenu;
       if (Item.itemStatus == 1)
        {
            _soldGO.SetActive(true);
        }
        else
        {
            _soldGO.SetActive(false);
        }

       if (allScore < 300)
       {
           buyButtonText.text = "Not enough score";
       }
       if(allScore >= 300)
       {
           buyButtonText.text = "Price - Score: 300";
       }
        
    }
    public void Buy()
    {

        if (allScore >= 300)
        {
            allScore -= 300;
            Item.itemStatus = 1;

        }
    }
}

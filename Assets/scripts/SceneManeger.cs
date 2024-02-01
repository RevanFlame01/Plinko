using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManeger : MonoBehaviour
{
   public void Play()
    {
        SceneManager.LoadScene("game");
        collector.hp = 3;
        PlayerPrefs.DeleteKey("Tutorial");
    }
    public void Exit()
    {
        SceneManager.LoadScene("menu");
    }
}

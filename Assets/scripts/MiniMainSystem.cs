using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniMainSystem : MonoBehaviour
{
   public void GoToMenu()
   {
      SceneManager.LoadScene("menu");
   } 
}

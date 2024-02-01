using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMiniSystem : MonoBehaviour
{
   public GameObject ShopPanel;
   public Animator AN;

   public void ExitPanelClikcButton()
   {
      AN.Play("ExitAnimation");
   }

   public void ExitPanel()
   {
      ShopPanel.SetActive(false);
   }
}

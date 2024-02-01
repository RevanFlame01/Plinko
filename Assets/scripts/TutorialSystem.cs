using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TutorialSystem : MonoBehaviour
{
    public Animator anim;
    public int Tut;
    [Space(20)]
    [Header("All Tutorial Objects")]
    public GameObject Tut1;
    public GameObject Tut2;
    public GameObject Tut3;
    public GameObject Tut4;
    public GameObject Tut5;
    public GameObject Character;
    public GameObject Character2;
    public GameObject Character3;
    public Image PanelTutorial;
    public void DoneTutorial()
    {
        Tut = 1;
        PlayerPrefs.SetInt("Tutorial", Tut);
        gameObject.SetActive(false);
    }

    public void StartTut2()
    {
        anim.Play("Tut1Exit");
        
    }
    public void ExitTut2()
    {
        anim.Play("Tut2Exit");
        ballsSpawner.activator = true;
    }

    public void Open2Tutorial()
    {
        Tut1.SetActive(false);
        Tut2.SetActive(true);
    }

    public void Open3Tutorial()
    {
        Tut2.SetActive(false);
        Color newColor = new Color(PanelTutorial.color.r, PanelTutorial.color.g, PanelTutorial.color.b,0f);
        PanelTutorial.color = newColor;
        Character.SetActive(false);
        Character2.SetActive(false);
        Character3.SetActive(false);
        Tut3.SetActive(true);
    }

    public void Open4Tutorial()
    {
        Tut3.SetActive(false);
        Tut4.SetActive(true);
    }

    public void Open5Tutorial()
    {
        Tut4.SetActive(false);
        Tut5.SetActive(true);
    }

    public void DoneTutorialButton()
    {
        Tut = 1;
        PlayerPrefs.SetInt("Tutorial",Tut);
        gameObject.SetActive(false);
        ballsSpawner.activator = true;
    }
}

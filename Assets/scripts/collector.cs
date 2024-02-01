using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class collector : MonoBehaviour
{
    [SerializeField] private GameObject redLine;
    [SerializeField] private GameObject greenLine;
    [SerializeField] private GameObject blueLine;
    [SerializeField] private GameObject purpleLine;
    [SerializeField] private GameObject gameOverPanel;
    private float changeColorTimer;
    
    public static int activeColor;

    private bool redCollision;
    private bool greenCollision;
    private bool blueCollision;
    private bool purpleCollision;

    public static int hp = 3;
    private int laserActiv;
    
    [SerializeField] private GameObject laserGO;
    [SerializeField] private GameObject laserPartical;
    [SerializeField] private GameObject laserButton;

    [SerializeField] private Text hpText;
    
    void Start()
    {
        activeColor = Random.Range(1, 4);
        
    }

    
    void Update()
    {
        hpText.text = "HP: " + hp;
        changeColorTimer -= 1f * Time.deltaTime;
        if (changeColorTimer <= 0)
        {
            activeColor = Random.Range(1, 4);
            laserActiv++;
            changeColorTimer = 10f;
        }
        if (laserActiv >= 4)
        {
            laserButton.SetActive(true);
        }
        
        if (activeColor == 1)
        {
            redLine.gameObject.SetActive(true);
            greenLine.gameObject.SetActive(false);
            blueLine.gameObject.SetActive(false);
            purpleLine.gameObject.SetActive(false);
        }
        if (activeColor == 2)
        {
            redLine.gameObject.SetActive(false);
            greenLine.gameObject.SetActive(true);
            blueLine.gameObject.SetActive(false);
            purpleLine.gameObject.SetActive(false);
        }
        if (activeColor == 3)
        {
            redLine.gameObject.SetActive(false);
            greenLine.gameObject.SetActive(false);
            blueLine.gameObject.SetActive(true);
            purpleLine.gameObject.SetActive(false);
        }
        if (activeColor == 4)
        {
            redLine.gameObject.SetActive(false);
            greenLine.gameObject.SetActive(false);
            blueLine.gameObject.SetActive(false);
            purpleLine.gameObject.SetActive(true);
        }


        if ( activeColor == 1 && redCollision && Input.GetMouseButtonDown(0)) 
        {
            score._score += 10;
            score.allScore += 10;
            particalsOnBall.destroy = true;
        }
        if (redCollision && activeColor != 1 && Input.GetMouseButtonDown(0) )
        {
            hp--;
            particalsOnBall.destroy = true;
        }

        if (activeColor == 2 && greenCollision && Input.GetMouseButtonDown(0))
        {
            score._score += 10;
            score.allScore += 10;
            particalsOnBall.destroy = true;
        }
        if (greenCollision && activeColor != 2 && Input.GetMouseButtonDown(0))
        {
            hp--;
            particalsOnBall.destroy = true;
        }

        if (activeColor == 3 && blueCollision && Input.GetMouseButtonDown(0))
        {
            score._score += 10;
            score.allScore += 10;
            particalsOnBall.destroy = true;
        }
        if (blueCollision && activeColor != 3 && Input.GetMouseButtonDown(0))
        {
            hp--;
            particalsOnBall.destroy = true;
        }

        if (activeColor == 4 && purpleCollision && Input.GetMouseButtonDown(0))
        {
            score._score += 10;
            score.allScore += 10;
            particalsOnBall.destroy = true;
        }
        if (purpleCollision && activeColor != 4 && Input.GetMouseButtonDown(0))
        {
            hp--;
            particalsOnBall.destroy = true;
        }

        if (hp <= 0 )
        {
            gameOverPanel.gameObject.SetActive(true);
            ballsSpawner.activator = false;
            particalsOnBall.destroy = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("red"))
        {
            redCollision = true;
            
        }
        if (collision.gameObject.CompareTag("green"))
        {
            greenCollision = true;
            
        }
        if (collision.gameObject.CompareTag("blue"))
        {
            blueCollision = true;
            
        }
        if (collision.gameObject.CompareTag("purple"))
        {
            purpleCollision = true;
            
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("red"))
        {
            redCollision = false;
           
        }
        if (collision.gameObject.CompareTag("blue"))
        {
            blueCollision = false;
            
        }
        if (collision.gameObject.CompareTag("green"))
        {
            greenCollision = false;
            
        }
        if (collision.gameObject.CompareTag("purple"))
        {
            purpleCollision = false;
        }
    }

    public void Laser()
    {
        laserActiv = 0;
        laserButton.SetActive(false);
        Instantiate(laserGO, new Vector3(3, -1.5f, 0), Quaternion.identity);
        Quaternion rot = Quaternion.Euler(0, transform.eulerAngles.y -90, 0);
        Instantiate(laserPartical, new Vector3(3, -1.5f, 0), rot);
    }
}

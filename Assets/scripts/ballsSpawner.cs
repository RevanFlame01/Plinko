using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] balls;

    private float spawnTimer;
    private float complicationTime;
    private int ballsCount = 1;

    private Vector3 spawnPosition;

    public static bool activator = false;
    public GameObject TutorialObject;
    private void Update()
    {
        if (TutorialObject.activeSelf == false)
        {
            activator = true;
        }
        if (activator)
        {
            spawnTimer -= 1f * Time.deltaTime;
            if (spawnTimer <= 0)
            {
                Spawner();
                spawnTimer = 2f;
            }
            complicationTime = complicationTime + Time.deltaTime;
            if (complicationTime >= 60)
            {
                ballsCount++;
                complicationTime = 0;
            }
        }
        if (!activator)
        {
            DestroyBall();
        }
    }

    public void Spawner()
    {
        for (int i = 0; i < ballsCount; i++)
        {
            spawnPosition = new Vector3(Random.Range(-2f, 2f), 5.3f, 0);
            Instantiate(balls[Random.Range(0, balls.Length)], spawnPosition, Quaternion.identity);
        }
    }

    private void DestroyBall()
    {
        GameObject[] red = GameObject.FindGameObjectsWithTag("red");
        foreach (GameObject element in red)
        {
            Destroy(element);
        }
        GameObject[] blue = GameObject.FindGameObjectsWithTag("blue");
        foreach (GameObject element in blue)
        {
            Destroy(element);
        }
        GameObject[] green = GameObject.FindGameObjectsWithTag("green");
        foreach (GameObject element in green)
        {
            Destroy(element);
        }
        GameObject[] purple = GameObject.FindGameObjectsWithTag("purple");
        foreach (GameObject element in purple)
        {
            Destroy(element);
        }
        GameObject[] game_oblect = GameObject.FindGameObjectsWithTag("bomb");
        foreach (GameObject element in game_oblect)
        {
            Destroy(element);
        }
    }
}

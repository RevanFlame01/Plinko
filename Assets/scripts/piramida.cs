using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piramida : MonoBehaviour
{

    [SerializeField]private GameObject partical;
    [SerializeField] private GameObject parentsPosition;
    private float dealiteTimer = 0;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(partical, parentsPosition.transform.position, Quaternion.identity);
    }
    private void Update()
    {
        dealiteTimer = dealiteTimer + Time.deltaTime;
        if (dealiteTimer >= 10)
        {
            DealiteParticals();
            dealiteTimer = 0;
        }

    }

    void DealiteParticals()
    {
        GameObject[] game_oblect = GameObject.FindGameObjectsWithTag("partical");
        foreach (GameObject element in game_oblect)
        {
            Destroy(element);
        }
    }
}

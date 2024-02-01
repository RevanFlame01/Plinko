using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    [SerializeField] private GameObject explosionParticals;
    
    private void OnMouseDown()
    {
        score.allScore += 10;
        score._score += 10;
        Instantiate(explosionParticals, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}

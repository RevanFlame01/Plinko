using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deadZone : MonoBehaviour
{

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Destroy(collision.gameObject);
        if (collision.gameObject.CompareTag("bomb"))
        {
            collector.hp--;
        }
    }
}

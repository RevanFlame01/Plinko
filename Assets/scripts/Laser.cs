using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        Destroy(gameObject, 5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("red"))
        {
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.CompareTag("green"))
        {
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.CompareTag("blue"))
        {
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.CompareTag("purple"))
        {
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.CompareTag("bomb"))
        {
            Destroy(collision.gameObject);

        }
    }
}

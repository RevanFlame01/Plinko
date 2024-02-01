using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particalsOnBall : MonoBehaviour
{
    [SerializeField] private GameObject partical;
    public static bool destroy;
    private void Update()
    {
        if (destroy)
        {
            Instantiate(partical, transform.position, Quaternion.identity);
            destroy = false;
        }
    }
}

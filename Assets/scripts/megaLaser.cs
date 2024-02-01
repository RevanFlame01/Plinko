using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class megaLaser : MonoBehaviour
{
    [SerializeField] private GameObject superLaser;
    [SerializeField] private GameObject superLaserPartical;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Quaternion rot = Quaternion.Euler(transform.eulerAngles.x + 90, 0, 0);
        Instantiate(superLaserPartical, new Vector3(0, 10, 0), rot);
        Instantiate(superLaser, new Vector3(0, 10, 0), Quaternion.identity);
    }
}

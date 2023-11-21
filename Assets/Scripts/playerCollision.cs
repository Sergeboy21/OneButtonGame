using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    private Health healthScript;

    private Vector3 tonk;


    private void Start()
    {
        healthScript = GetComponent<Health>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "building")
        {
            healthScript.health--;
            Destroy(collision.gameObject);
            tonk.y = 0;
        }
    }
}
